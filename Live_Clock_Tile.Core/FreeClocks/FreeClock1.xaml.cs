﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Live_Clock_Tile.Core;
using System.IO.IsolatedStorage;

namespace Live_Clock_Tile
{
    public partial class FreeClock1 : UserControl
    {

        public FreeClock1()
        {
            InitializeComponent();
            updateUI();
        }

        private void updateUI()
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (settings["clock24"].ToString() == "true")
            {
                hour.Text = DateTime.Now.ToString("HH");
            }
            else
            {
                hour.Text = DateTime.Now.ToString("hh");
            }
            date.Text = DateTime.Now.ToString("MMMM dd - yyyy");
            minute.Text = DateTime.Now.ToString("mm");
            ampm.Text = DateTime.Now.ToString("tt");
        }
    }
}
