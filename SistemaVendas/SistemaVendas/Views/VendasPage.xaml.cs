using System;
using System.Collections.Generic;
using System.ComponentModel;
using SistemaVendas.Models;
using SistemaVendas.ViewModels;
using Xamarin.Forms;

namespace SistemaVendas.Views
{
    [DesignTimeVisible(true)]
    public partial class VendasPage : ContentPage
    {
        VendasViewModel viewModel;

        public VendasPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new VendasViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Vendas;
            if (item == null)
                return;

            await Navigation.PushAsync(new VendasDetailPage(new VendasDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        /*async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }*/

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Vendas.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
