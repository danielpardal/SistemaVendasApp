using System;
using System.Collections.Generic;
using SistemaVendas.ViewModels;
using Xamarin.Forms;

namespace SistemaVendas.Views
{
    public partial class EmpresaPage : ContentPage
    {
        ItemsViewModel viewModel;

        public EmpresaPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Models.Empresa;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Empresas.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
