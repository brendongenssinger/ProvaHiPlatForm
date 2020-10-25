using System;
using ProvaHiPlatForm.Exemplos;
using System.Collections.Generic;
using System.Linq;
using ProvaHiPlatForm.Exemplos.Questao_1.Bll;
using ProvaHiPlatForm.Exemplos.Questao_1;
using ProvaHiPlatForm.Exemplos.Questao_2;
using ProvaHiPlatForm.Exemplos.Questao_2.Model;

namespace ProvaHiPlatForm
{
    public static class Inicio
    {   
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Executando a prova.");
            System.Console.WriteLine("Selecione qual questão deseja analisar.");

            switch (ObterOpcao())
            {
                case 1:

                var automovel = new AutomoveisBLL();
                automovel.ExecutarAutomovel(new Caminhao());
                automovel.ExecutarAutomovel(new Carro());
                automovel.ExecutarAutomovel(new Moto());
                break;
                case 2: 
                    CalcularPrecoHiperMercado();
                    break;
                case 3:
                    Eleitor();
                    break;
                default:
                break;
            }
            
        }

        private static void Eleitor()
        {
            
        }

        private static void CalcularPrecoHiperMercado()
        {
            var hiperMercado = new HiperMercadoBll();

            var carne= new XProdutos()
            {
                NomeProduto = "Carne",
                TipoProdutos= Exemplos.Questao_2.Enumerados.EnumProdutos.Carnes,
                Validade = 160, // Dias
                Volume = 150 // Kilos
            };

            hiperMercado.CalcularFormula(carne);

            var bebidas = new XProdutos()
            {
                NomeProduto = "Coca Cola",
                TipoProdutos = Exemplos.Questao_2.Enumerados.EnumProdutos.Bebidas,
                Validade = 360, 
                Volume = 300
            };

            hiperMercado.CalcularFormula(bebidas);
        }

        public static int ObterOpcao()
        {
            System.Console.WriteLine("[1] - Questão 1");
            return Convert.ToInt16(Console.ReadLine().ValidarTexto());
        }

        public static string ValidarTexto(this string objeto)
        {
            var result  = Convert.ToString(objeto).ToCharArray().Select(pX=> char.IsNumber(pX));
            return result.Contains(false) ? "0" : objeto.ToString().Trim();
        }
    }
}
