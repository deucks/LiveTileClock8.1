﻿#pragma checksum "C:\Users\Raajit\Documents\Visual Studio 2013\Projects\Live Clock Tile 8.1\Live_Clock_Tile.Core\FreeClocks\FreeClock5.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F25F52A573EF337F1B311CD85A86BE4"
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


namespace Live_Clock_Tile {
    
    
    public partial class FreeClock5 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock minute;
        
        internal System.Windows.Controls.Grid minuteHand;
        
        internal System.Windows.Controls.Grid hourHand;
        
        internal System.Windows.Controls.TextBlock hour;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Live_Clock_Tile.Core;component/FreeClocks/FreeClock5.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.minute = ((System.Windows.Controls.TextBlock)(this.FindName("minute")));
            this.minuteHand = ((System.Windows.Controls.Grid)(this.FindName("minuteHand")));
            this.hourHand = ((System.Windows.Controls.Grid)(this.FindName("hourHand")));
            this.hour = ((System.Windows.Controls.TextBlock)(this.FindName("hour")));
        }
    }
}
