using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.UI.Views;

namespace Testing1234
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            
            camera.Shutter();
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            camera.CameraOptions = camera.CameraOptions == CameraOptions.Back ? CameraOptions.Front : CameraOptions.Back;
        }
    }
}

