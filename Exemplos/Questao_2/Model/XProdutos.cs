using ProvaHiPlatForm.Exemplos.Questao_2.Enumerados;

namespace ProvaHiPlatForm.Exemplos.Questao_2.Model
{
    public class XProdutos
    {
        public string NomeProduto { get; set; }
        public EnumProdutos TipoProdutos { get; set; }
        public int Validade{ get; set; }
        public double Custo{get;set;} 
        public int Volume { get; set; }
        public bool Gelado{get;set;}
    }
}