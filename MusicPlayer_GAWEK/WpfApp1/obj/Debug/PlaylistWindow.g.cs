﻿#pragma checksum "..\..\PlaylistWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DFCD2316D64911157652EA0086731072051877200A55B437F41ABB77B1C9757A"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// PlaylistWindow
    /// </summary>
    public partial class PlaylistWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\PlaylistWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PlayList;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\PlaylistWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removebutton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PlaylistWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TrackUp_button;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PlaylistWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TrackDown_button;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/playlistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlaylistWindow.xaml"
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
            this.PlayList = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.removebutton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\PlaylistWindow.xaml"
            this.removebutton.Click += new System.Windows.RoutedEventHandler(this.removebutton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TrackUp_button = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\PlaylistWindow.xaml"
            this.TrackUp_button.Click += new System.Windows.RoutedEventHandler(this.TrackUp_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TrackDown_button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\PlaylistWindow.xaml"
            this.TrackDown_button.Click += new System.Windows.RoutedEventHandler(this.TrackDown_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
