﻿#pragma checksum "..\..\..\User Control\Home.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "331D8AEE2BD68C9F8A468426B38FFCA8C3A7B0F4E1F44F92E4E0A06D618F01DB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using View.User_Control;
using WpfAnimatedGif;


namespace View.User_Control {
    
    
    /// <summary>
    /// Home
    /// </summary>
    public partial class Home : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal View.User_Control.Home home;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border thumb1;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border thumb3;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border thumb2;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image scroll;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSale1;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSale2;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\User Control\Home.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSale3;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/user%20control/home.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User Control\Home.xaml"
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
            this.home = ((View.User_Control.Home)(target));
            return;
            case 2:
            this.thumb1 = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.thumb3 = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.thumb2 = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.scroll = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.btnSale1 = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\User Control\Home.xaml"
            this.btnSale1.Click += new System.Windows.RoutedEventHandler(this.btnSale1_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSale2 = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\..\User Control\Home.xaml"
            this.btnSale2.Click += new System.Windows.RoutedEventHandler(this.btnSale2_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSale3 = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\..\User Control\Home.xaml"
            this.btnSale3.Click += new System.Windows.RoutedEventHandler(this.btnSale3_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

