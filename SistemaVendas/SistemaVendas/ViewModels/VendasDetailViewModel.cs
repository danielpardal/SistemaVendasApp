using System;
using SistemaVendas.Models;

namespace SistemaVendas.ViewModels
{
    public class VendasDetailViewModel : BaseViewModel
    {
        public Vendas Venda { get; set; }
        public VendasDetailViewModel(Vendas venda = null)
        {
            Title = venda?.DataVenda;
            Venda = venda;
        }
    }
}
