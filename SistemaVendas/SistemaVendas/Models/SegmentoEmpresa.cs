using System;
namespace SistemaVendas.Models
{
    public class SegmentoEmpresa
    {
        public int Id { get; set; }
        public string DesSegmento { get; set; }
        public string Empresa { get; set; }
        public Boolean Ativo { get; set; }
    }
}
