﻿#pragma checksum "..\..\Prompt.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EC2765E109976FE3E1EA8128EE4C0CDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverCityOS;
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


namespace SilverCityOS {
    
    
    /// <summary>
    /// Prompt
    /// </summary>
    public partial class Prompt : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel mainStack;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock message;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid middleSec;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image modePic;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel rightStack;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showBill;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer itemListScroll;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel itemList;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Prompt.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SilverCityOS;component/prompt.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Prompt.xaml"
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
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.mainStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.middleSec = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.modePic = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.rightStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.showBill = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Prompt.xaml"
            this.showBill.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.itemListScroll = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 9:
            this.itemList = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            
            #line 66 "..\..\Prompt.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Okay);
            
            #line default
            #line hidden
            return;
            case 11:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

