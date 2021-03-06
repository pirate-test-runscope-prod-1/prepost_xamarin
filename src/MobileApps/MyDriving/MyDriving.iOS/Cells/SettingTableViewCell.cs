// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System;
using Foundation;
using UIKit;

namespace MyDriving.iOS
{
    public partial class SettingTableViewCell : UITableViewCell
    {
        public SettingTableViewCell(IntPtr handle) : base(handle)
        {
        }

        public SettingTableViewCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
        }

        public string Name
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        public string Value
        {
            get { return valueLabel.Text; }
            set { valueLabel.Text = value; }
        }
    }
}