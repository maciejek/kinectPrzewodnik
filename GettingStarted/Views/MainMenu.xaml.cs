﻿using System.Windows;
using System.Windows.Controls;
using System;
using Przewodnik.Content.Traslations;
using Przewodnik.ViewModels;

namespace Przewodnik.Views
{

    partial class MainMenu : IKinectPage
    {
        private KinectPageFactory pageFactory;
        private WeatherViewModel wvm;

        public MainMenu(KinectPageFactory pageFactory)
        {
            InitializeComponent();
            this.pageFactory = pageFactory;
            
            //wvm = new WeatherViewModel();
            //BitmapImage bmi = new BitmapImage(new Uri(wvm.wm.WeatherImage, UriKind.Relative));
            //weatherImage.Source = bmi;
            //temperature.Text = wvm.wm.Temperature;
            //description.Text = wvm.wm.Description;
        }

        public Grid GetView()
        {
            return MainMenuGrid;
        }

        public void OnNavigateTo()
        {
            prepareTranslation();
        }

        private void touristAttractions_Click(object sender, RoutedEventArgs e)
        {
            IKinectPage attractions = pageFactory.GetAttractionsGrid();
            pageFactory.NavigateTo(attractions);
        }

        private void twitterPageButton_Click(object sender, RoutedEventArgs e)
        {
            IKinectPage twitterPage = pageFactory.GetTwitterPageGrid();
            pageFactory.NavigateTo(twitterPage);
        }

        private void calendarPageButton_Click(object sender, RoutedEventArgs e)
        {
            string parameter = DateTime.Now.ToString("yyyy-MM-dd");
            IKinectPage calendarPage = pageFactory.GetCalendarPageGrid(parameter);
            pageFactory.NavigateTo(calendarPage);
        }

        private void mapPageButton_Click(object sender, RoutedEventArgs e)
        {
            IKinectPage mapPage = pageFactory.GetMapPageGrid();
            pageFactory.NavigateTo(mapPage);
        }

        private void postcardPageButton_Click(object sender, RoutedEventArgs e)
        {
            IKinectPage postcardPage = pageFactory.GetPostcardPageGrid();
            pageFactory.NavigateTo(postcardPage);
        }

        private void prepareTranslation()
        {
            Atrakcje.Text = AppResources.GetText("M_atrakcje_turystyczne");
            Atrakcje_opis.Text = AppResources.GetText("M_atrakcje_turystyczne_description");
            Wydarzenia.Text = AppResources.GetText("M_wydarzenia");
            Twitter.Text = AppResources.GetText("M_twitter");
            Pogoda.Text = AppResources.GetText("M_pogoda");
            Mapy.Text = AppResources.GetText("M_plan_miasta");
            Widokowka.Text = AppResources.GetText("M_widokowka");
            
        }

    }


}
