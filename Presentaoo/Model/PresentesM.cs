using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class PresentesM
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoM Tipo { get; set; }
        public MarcaM Marca { get; set; }
        public FinalidadeM Finalidade { get; set; }
        public string Cor { get; set; }
        public double Tamanho { get; set; }
        public decimal Preco { get; set; }
        public FornecedorM Fornecedor { get; set; }
    }
}
