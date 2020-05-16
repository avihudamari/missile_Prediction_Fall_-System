﻿#pragma checksum "..\..\GraphUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22AD8901B988784BC95A887DD3E363AD9BAE8FAD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using Microsoft.Maps.MapControl.WPF;
using PL;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace PL {
    
    
    /// <summary>
    /// GraphUC
    /// </summary>
    public partial class GraphUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\GraphUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart Graph;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GraphUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Axis XLabels;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\GraphUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TodayButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\GraphUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ThisMounthButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\GraphUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button THisYearButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GraphUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AllTimeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/graphuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GraphUC.xaml"
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
            this.Graph = ((LiveCharts.Wpf.CartesianChart)(target));
            return;
            case 2:
            this.XLabels = ((LiveCharts.Wpf.Axis)(target));
            return;
            case 3:
            this.TodayButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\GraphUC.xaml"
            this.TodayButton.Click += new System.Windows.RoutedEventHandler(this.TodayButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ThisMounthButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\GraphUC.xaml"
            this.ThisMounthButton.Click += new System.Windows.RoutedEventHandler(this.ThisMounthButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.THisYearButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\GraphUC.xaml"
            this.THisYearButton.Click += new System.Windows.RoutedEventHandler(this.THisYearButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AllTimeButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\GraphUC.xaml"
            this.AllTimeButton.Click += new System.Windows.RoutedEventHandler(this.AllTimeButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

