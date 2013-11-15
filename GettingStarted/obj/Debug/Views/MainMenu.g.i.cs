﻿#pragma checksum "..\..\..\Views\MainMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4C2E56B786C91735026D7E1751C4A5B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Przewodnik.Views {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.Grid, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Przewodnik.Views.MainMenu MainMenuGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton TouristAttractionsButton;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton EventsButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton TwitterButton;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton WeatherButton;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton MapsButton;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\Views\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton PostcardButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Przewodnik;component/views/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainMenuGrid = ((Przewodnik.Views.MainMenu)(target));
            return;
            case 2:
            this.TouristAttractionsButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 40 "..\..\..\Views\MainMenu.xaml"
            this.TouristAttractionsButton.Click += new System.Windows.RoutedEventHandler(this.touristAttractions_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EventsButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 61 "..\..\..\Views\MainMenu.xaml"
            this.EventsButton.Click += new System.Windows.RoutedEventHandler(this.calendarPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TwitterButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 83 "..\..\..\Views\MainMenu.xaml"
            this.TwitterButton.Click += new System.Windows.RoutedEventHandler(this.twitterPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.WeatherButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            return;
            case 6:
            this.MapsButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 134 "..\..\..\Views\MainMenu.xaml"
            this.MapsButton.Click += new System.Windows.RoutedEventHandler(this.mapPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PostcardButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

