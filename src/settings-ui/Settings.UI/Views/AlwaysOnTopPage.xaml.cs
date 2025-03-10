﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.PowerToys.Settings.UI.Library;
using Microsoft.PowerToys.Settings.UI.Library.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace Microsoft.PowerToys.Settings.UI.Views
{
    public sealed partial class AlwaysOnTopPage : Page
    {
        private AlwaysOnTopViewModel ViewModel { get; set; }

        public AlwaysOnTopPage()
        {
            var settingsUtils = new SettingsUtils();
            ViewModel = new AlwaysOnTopViewModel(settingsUtils, SettingsRepository<GeneralSettings>.GetInstance(settingsUtils), SettingsRepository<AlwaysOnTopSettings>.GetInstance(settingsUtils), ShellPage.SendDefaultIPCMessage);
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
