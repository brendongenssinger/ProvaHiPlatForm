using System;
using System.Collections;
using System.Collections.Generic;
using ProvaHiPlatForm.Exemplos.Questao_2.Enumerados;
using ProvaHiPlatForm.Exemplos.Questao_2.Interfaces;
using ProvaHiPlatForm.Exemplos.Questao_2.Model;

namespace ProvaHiPlatForm.Exemplos.Questao_2
{
    public class HiperMercadoBll
    {   
        private IHiperMercado _hiperMercado;
        public void CalcularFormula(XProdutos pProduto)
        {
            double preco = HiperMercado.HI.FormulaMagica(pProduto.Custo,pProduto.Validade);
            CriarInstancia(pProduto.TipoProdutos);
            preco = _hiperMercado.CalcularValorProduto(pProduto,preco);
            System.Console.WriteLine($"Preco do produto {pProduto.NomeProduto} é R$ {preco.ToString("0.00")}");
        }

        private void CriarInstancia(EnumProdutos tipoProdutos)
        {
            if(tipoProdutos == EnumProdutos.Carnes)
                _hiperMercado = new HiperMercadoCarnes();
            else if (tipoProdutos == EnumProdutos.Bebidas)                
                _hiperMercado = new HiperMercadoBebidas();
             else
                throw new Exception("Não existe esse tipo de produto cadastro no fonte.");
        }
    }
}