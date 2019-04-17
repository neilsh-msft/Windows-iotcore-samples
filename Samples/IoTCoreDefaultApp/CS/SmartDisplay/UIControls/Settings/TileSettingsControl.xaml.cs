// Copyright (c) Microsoft Corporation. All rights reserved.

using SmartDisplay.Utils;

namespace SmartDisplay.Controls
{
    public sealed partial class TileSettingsControl : SettingsUserControlBase
    {
        public TileSettingsControlVM ViewModel { get; } = new TileSettingsControlVM();
        protected override SettingsBaseViewModel ViewModelImpl => ViewModel;

        public TileSettingsControl() : base()
        {
            if (DeviceTypeInformation.Type != DeviceTypes.IMX8M)
            {
                InitializeComponent();
            }
        }
    }
}
