﻿#pragma checksum "..\..\..\Pages\TopAppsWrapped.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58F34834071400603D0A29553F6FA9E51D9746D1F4AB36E00F0359958CA443A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WindowsStoreClone.Pages;


namespace WindowsStoreClone.Pages {
    
    
    /// <summary>
    /// TopAppsWrapped
    /// </summary>
    public partial class TopAppsWrapped : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Pages\TopAppsWrapped.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WindowsStoreClone.Pages.TopAppsWrapped TopAppsWrappedPage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\TopAppsWrapped.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopAppsWrappedPageMainGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\TopAppsWrapped.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\TopAppsWrapped.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer TopAppsWrappedPageMainSV;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\TopAppsWrapped.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel TopAppsWrappedPageMainWrapPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/WindowsStoreClone;component/pages/topappswrapped.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TopAppsWrapped.xaml"
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
            this.TopAppsWrappedPage = ((WindowsStoreClone.Pages.TopAppsWrapped)(target));
            return;
            case 2:
            this.TopAppsWrappedPageMainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\TopAppsWrapped.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.Back_Btn);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TopAppsWrappedPageMainSV = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 49 "..\..\..\Pages\TopAppsWrapped.xaml"
            this.TopAppsWrappedPageMainSV.ScrollChanged += new System.Windows.Controls.ScrollChangedEventHandler(this.TopAppsWrappedPageMainSV_ScrollChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TopAppsWrappedPageMainWrapPanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
