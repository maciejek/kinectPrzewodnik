﻿#pragma checksum "..\..\..\Views\AttractionArticle.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1961C5C1375A5BAF334404570037B797"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
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
    /// AttractionArticle
    /// </summary>
    public partial class AttractionArticle : System.Windows.Controls.Grid, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Przewodnik.Views.AttractionArticle AttractionArticleGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid bigImageGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton FirstImageButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image firstImageSource;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton SecondImageButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image secondImageSource;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Kinect.Toolkit.Controls.KinectTileButton ThirdImageButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image thirdImageSource;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\AttractionArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descriptionTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Przewodnik;component/views/attractionarticle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AttractionArticle.xaml"
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
            this.AttractionArticleGrid = ((Przewodnik.Views.AttractionArticle)(target));
            return;
            case 2:
            this.bigImageGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.FirstImageButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 24 "..\..\..\Views\AttractionArticle.xaml"
            this.FirstImageButton.Click += new System.Windows.RoutedEventHandler(this.KinectTileButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.firstImageSource = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.SecondImageButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 30 "..\..\..\Views\AttractionArticle.xaml"
            this.SecondImageButton.Click += new System.Windows.RoutedEventHandler(this.KinectTileButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.secondImageSource = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.ThirdImageButton = ((Microsoft.Kinect.Toolkit.Controls.KinectTileButton)(target));
            
            #line 36 "..\..\..\Views\AttractionArticle.xaml"
            this.ThirdImageButton.Click += new System.Windows.RoutedEventHandler(this.KinectTileButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.thirdImageSource = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.descriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

