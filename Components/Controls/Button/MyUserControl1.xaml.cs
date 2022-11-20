using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Zoho.Logging;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Components.Controls.Button
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //TestNugetReferences();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Windows.UI.Xaml.Controls.Button btn = ((Windows.UI.Xaml.Controls.Button)sender);
            //ResourceLoaderTextBlock.Text = L10N.GetString(btn.Content.ToString());
        }
    }
}
