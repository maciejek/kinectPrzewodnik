﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using Przewodnik.Content.Traslations;
using Przewodnik.Utilities.DataLoader;
using Przewodnik.Views;
using Przewodnik.Utilities;
using System.Windows.Media;
using Przewodnik.Controls;
using Przewodnik.ViewModels;
using System.Windows.Media.Imaging;

namespace Przewodnik
{
    public partial class MainWindow : Window
    {

        private const int MinimumScreenWidth = 1920;
        private const int MinimumScreenHeight = 1080;

        private Navigator _navigator;
        private KinectPageFactory _pageFactory;
        private PeriodicLoader _periodicLoader;
        private static KinectController _kinectController;
        public static KinectController KinectController
        {
            get
            {
                return _kinectController;
            }
        }

        private MouseMovementDetector _movementDetector;
        private DesignResources _designResources;

        private WeatherViewModel wvm;

        private Thread _loaderThread;

        public MainWindow(KinectController controller)
        {
            _designResources = new DesignResources();
            _designResources.AdjustResolution();
            InitializeComponent();
            Loaded += OnLoaded;

            _navigator = new Navigator(this);
            _pageFactory = new KinectPageFactory(_navigator);
            _navigator.SetMainMenu(_pageFactory.GetMainMenu());
            _navigator.SetSleepScreen(_pageFactory.GetSleepScreen());

            _kinectController = controller;
            _kinectController.EngagedUserColor = (Color)this.Resources["EngagedUserColor"];
            _kinectController.TrackedUserColor = (Color)this.Resources["TrackedUserColor"];
            _kinectController.EngagedUserMessageBrush = (Brush)this.Resources["EngagedUserMessageBrush"];
            _kinectController.TrackedUserMessageBrush = (Brush)this.Resources["TrackedUserMessageBrush"];
            _kinectController.Navigator = _navigator;
            //_kinectController.StartKinect();
            kinectRegion.HandPointersUpdated += (sender, args) => _kinectController.OnHandPointersUpdated(this.kinectRegion.HandPointers);
            DataContext = _kinectController;

            _movementDetector = new MouseMovementDetector(this);
            _movementDetector.IsMovingChanged += OnIsMouseMovingChangedNoWake;
            _movementDetector.Start();
            _periodicLoader = new PeriodicLoader(300);
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            double height = SystemParameters.PrimaryScreenHeight;
            double width = SystemParameters.PrimaryScreenWidth;
            if (width < MinimumScreenWidth || height < MinimumScreenHeight)
            {
                MessageBoxResult continueResult = MessageBox.Show(Properties.Resources.SmallerScreenResolutionMessage, Properties.Resources.SmallerScreenResolutionTitle, MessageBoxButton.YesNo);
                if (continueResult == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    MinHeight = height;
                    MinWidth = width;
                }
            }
            EarlyLoad();

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (null == e)
            {
                throw new ArgumentNullException("e");
            }

            try
            {
                switch (e.Key)
                {
                    case Key.Escape:
                        {
                            this.Close();
                        } break;
                    case Key.Up:
                        {
                            if (_kinectController.KinectSensorChooser.Kinect.ElevationAngle < _kinectController.KinectSensorChooser.Kinect.MaxElevationAngle)
                                _kinectController.KinectSensorChooser.Kinect.ElevationAngle += 1;
                        } break;
                    case Key.Down:
                        {
                            if (_kinectController.KinectSensorChooser.Kinect.ElevationAngle > _kinectController.KinectSensorChooser.Kinect.MinElevationAngle)
                                _kinectController.KinectSensorChooser.Kinect.ElevationAngle -= 1;
                        } break;

                }
            }
            catch (Exception) { }


            base.OnKeyUp(e);
        }

        private void OnIsMouseMovingChangedNoWake(object sender, EventArgs e)
        {
            WindowBezelHelper.UpdateBezel(this, _movementDetector.IsMoving);
        }

        private void OnIsMouseMovingChanged(object sender, EventArgs e)
        {
            WindowBezelHelper.UpdateBezel(this, _movementDetector.IsMoving);
            _kinectController.IsInEngagementOverrideMode = _movementDetector.IsMoving;
        }

        public void EarlyLoad()
        {
            LoadingScreen loadingScreen = new LoadingScreen(_pageFactory);
            _navigator.NavigateTo(loadingScreen);
            TopRow.Height = new GridLength(0);
            loadingScreen.LoadEnded += LoadEnded;
            _loaderThread = new Thread(loadingScreen.StartLoading);
            _loaderThread.Name = "EarlyLoader";
            _loaderThread.Start();
        }

        private void LoadEnded(object sender, EventArgs e)
        {
            if (e == null)
            {
                MessageBox.Show("Brak połączenia z Internetem. Sprawdź swoje łącze i spróbuj ponownie");
                this.Close();
            }
            else
            {
                SetActualWeather();
                WeatherLoader.Instance.loadWeather += LoadWeather;
                Application.Current.Dispatcher.Invoke(new Action(() => { _kinectController.StartKinect(); }));
                _periodicLoader.Start();
                _movementDetector.IsMovingChanged -= OnIsMouseMovingChangedNoWake;
                _movementDetector.IsMovingChanged += OnIsMouseMovingChanged;
                _movementDetector.Start();
                _navigator.GoSleep();
            }
        }

        public void Wake()
        {
            ShowTopBar(true);
        }
        public void Sleep()
        {
            TopRow.Dispatcher.Invoke(new Action(() => TopRow.Height = new GridLength(0)));
            SetView(_pageFactory.GetSleepScreen().GetView());
        }

        public void ShowTopBar(bool show)
        {
            if (show) TopRow.Height = new GridLength(150);
            else TopRow.Height = new GridLength(0);
        }

        public void ShowBackButton(bool enable)
        {
            if (enable)
            {
                BackButton.Visibility = System.Windows.Visibility.Visible;
                Weather.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                BackButton.Dispatcher.Invoke(new Action(() => BackButton.Visibility = System.Windows.Visibility.Hidden));
                BackButton.Dispatcher.Invoke(new Action(() => Weather.Visibility = System.Windows.Visibility.Visible));
            }
        }

        public void SetView(Grid grid)
        {
            Action action = delegate()
            {
                PageContentGrid.Children.Clear();
                PageContentGrid.Children.Add(grid);
            };
            PageContentGrid.Dispatcher.Invoke(action);
        }

        private void BackAction(object sender, RoutedEventArgs e)
        {
            _navigator.GoBack();
        }

        private void LoadWeather(object sender, EventArgs e)
        {
            SetActualWeather();
        }

        private void SetActualWeather()
        {
            wvm = new WeatherViewModel();
            DateTime dt = DateTime.Now;

            this.Dispatcher.Invoke((Action)(() =>
            {
                WeatherImage.Source = new BitmapImage(new Uri(wvm.wm.WeatherImage, UriKind.Relative));
                WeatherDegree.Text = wvm.wm.Temperature;
                DayOfWeek.Text = dt.ToString("dddd", AppResources.GetCultureInfo()).ToLower();
                Today.Text = dt.ToString("m", AppResources.GetCultureInfo()).ToLower();
            }));

            this.Dispatcher.BeginInvoke(new ThreadStart(() => Weather.DataContext = wvm));
        }

    }
}
