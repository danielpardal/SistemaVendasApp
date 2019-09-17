using System;
namespace SistemaVendas.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public string DataVenda { get; set; }
        public Empresa Empresa { get; set; }
        public Usuario UsuarioCadastro { get; set; }
        public Double ValorVenda { get; set; }
        public Boolean EmitidoNf { get; set; }
    }
}
