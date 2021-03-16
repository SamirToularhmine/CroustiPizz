﻿using CroustiPizz.Mobile.ViewModels;
using Storm.Mvvm.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace CroustiPizz.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopMapPage: BaseContentPage {
        public ShopMapPage()
        {
            BindingContext = new ShopMapViewModel();
            InitializeComponent();

        }
    }
}