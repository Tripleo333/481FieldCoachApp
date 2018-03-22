﻿#pragma checksum "..\..\ResourceTypeDialogBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "191F3E1575DA33E0ECAE3963631AD824E5E9D0D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Some481;
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


namespace Some481 {
    
    
    /// <summary>
    /// ResourceTypeDialogBox
    /// </summary>
    public partial class ResourceTypeDialogBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VideoResourceButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TextResourceButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShareResourceButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResourceTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResourceVideoURLBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle VideoPreview;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviewURLButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ResourceTypeDialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResourceTitleTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/CoachingApp;component/resourcetypedialogbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ResourceTypeDialogBox.xaml"
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
            this.VideoResourceButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\ResourceTypeDialogBox.xaml"
            this.VideoResourceButton.Click += new System.Windows.RoutedEventHandler(this.VideoResourceButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextResourceButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ResourceTypeDialogBox.xaml"
            this.TextResourceButton.Click += new System.Windows.RoutedEventHandler(this.TextResourceButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShareResourceButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\ResourceTypeDialogBox.xaml"
            this.ShareResourceButton.Click += new System.Windows.RoutedEventHandler(this.ShareResourceButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResourceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ResourceVideoURLBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.VideoPreview = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.PreviewURLButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ResourceTypeDialogBox.xaml"
            this.PreviewURLButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ResourceTitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

