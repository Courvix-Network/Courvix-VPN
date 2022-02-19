using System;
using System.Collections.Generic;
using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CourvixVPN.API.Models;

namespace CourvixVPN.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            this.FindControl<ItemsControl>("UsersControl").Items = new List<Controls.Server>
            {
                new("Epic", "100DOWN", "Banned from Path, Inc."),
                new("Even epicer", "OVHInternal", "GotInternal LLC")
            };
        }
    }
}