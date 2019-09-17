using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVendas.Models
{
    public enum MenuItemType
    {
        Inicio,
        Empresa,
        Vendas,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
