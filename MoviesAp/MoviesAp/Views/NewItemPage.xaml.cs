using System;
using System.Collections.Generic;
using System.ComponentModel;
using MoviesAp.Models;
using MoviesAp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviesAp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}