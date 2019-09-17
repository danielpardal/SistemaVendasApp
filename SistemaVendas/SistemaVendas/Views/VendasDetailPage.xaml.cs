using System;
using System.Collections.Generic;
using System.ComponentModel;
using SistemaVendas.Models;
using SistemaVendas.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SistemaVendas.Views
{
    [DesignTimeVisible(true)]
    public partial class VendasDetailPage : ContentPage
    {
        VendasDetailViewModel viewModel;

        public VendasDetailPage(VendasDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public VendasDetailPage()
        {
            InitializeComponent();

            var venda = new Vendas
            {
                DataVenda = ""
            };

            viewModel = new VendasDetailViewModel(venda);
            BindingContext = viewModel;
        }
    }
}
