using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageGalleryPractice
{
    public partial class MainPage : ContentPage
    {
        Int16 _pictureId = 1;

        public MainPage()
        {
            InitializeComponent();



        }

        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", _pictureId)),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }


        void LeftButton(Object sender, EventArgs e)
        {
            _pictureId--;
            if (_pictureId == 0)
                _pictureId = 10;

            LoadImage();
        }

        void RightButton(Object sender, EventArgs e)
        {
            _pictureId++;
            if (_pictureId == 11)
                _pictureId = 1;

            LoadImage();
        }


    }
}
