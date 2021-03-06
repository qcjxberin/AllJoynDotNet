﻿using AllJoynDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using TestApp.Shared;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestApp.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ISample currentSample;
        public MainPage()
        {
            this.InitializeComponent();
            Log.OnMessage += Log_OnMessage;
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            //new GetLibraryInfo().Start();
            //currentSample = new CreateInterfaceTest();
            currentSample = new AboutServiceTest();
            currentSample.Start();
        }

        private void Log_OnMessage(object sender, string e)
        {
            if (Dispatcher.HasThreadAccess)
                logger.Text += e;
            else
            {
                 var _ = Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                 {
                     logger.Text += e;
                 });
            }
        }
    }
}
