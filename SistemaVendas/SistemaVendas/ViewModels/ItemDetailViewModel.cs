using System;

using SistemaVendas.Models;

namespace SistemaVendas.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Empresa Empresa { get; set; }
        public ItemDetailViewModel(Empresa empresa = null)
        {
            Title = empresa?.RazaoSocial;
            Empresa = empresa;
        }
    }
}
