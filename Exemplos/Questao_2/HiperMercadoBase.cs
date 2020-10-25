using ProvaHiPlatForm.Exemplos.Questao_2.Interfaces;
using ProvaHiPlatForm.Exemplos.Questao_2.Model;

namespace ProvaHiPlatForm.Exemplos.Questao_2
{
    public abstract class HiperMercadoBase : IHiperMercado
    {
        public virtual double CalcularValorProduto(XProdutos pProduto, double pPreco)
        {
            throw new System.NotImplementedException();
        }
        protected virtual double SomarGastoFrigobar(bool ehGelado,double pPreco)
        {
            if(ehGelado)
                return pPreco + (pPreco*0.03);
            else 
                return pPreco;
        }
    }
}