﻿#pragma checksum "C:\Users\Raajit\Documents\Visual Studio 2013\Projects\Live Clock Tile\Live_Clock_Tile.Core\FreeClocks\FreeClock6.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9823EC8E7F05305B10305F54C5C5DA47"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Live_Clock_Tile.FreeClocks {
    
    
    public partial class FreeClock6 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid minute;
        
        internal System.Windows.Controls.Grid hour;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Live_Clock_Tile.Core;component/FreeClocks/FreeClock6.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.minute = ((System.Windows.Controls.Grid)(this.FindName("minute")));
            this.hour = ((System.Windows.Controls.Grid)(this.FindName("hour")));
        }
    }
}

