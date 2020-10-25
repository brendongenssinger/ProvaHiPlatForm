using ProvaHiPlatForm.Exemplos.Questao_2.Model;

namespace ProvaHiPlatForm.Exemplos.Questao_2
{
    public class HiperMercadoBebidas : HiperMercadoBase
    {
        public HiperMercadoBebidas()
        {
        }

        public override double CalcularValorProduto(XProdutos pProduto, double pPreco)
        {
            pPreco = SomarGastoFrigobar(pProduto.Gelado,pPreco);

            if(pProduto.Volume <= pProduto.Validade)
                return pPreco;
                
            // Caso tenha mais volume do que a quantidade de dias resta da validade 

            else 
            {
                var calc = pProduto.Volume - pProduto.Validade;
                return pPreco + (pPreco * (calc/100));
            }
        }
    }
}