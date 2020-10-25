using System;
using ProvaHiPlatForm.Exemplos;
using System.Collections.Generic;
using System.Linq;
using ProvaHiPlatForm.Exemplos.Questao_1.Bll;
using ProvaHiPlatForm.Exemplos.Questao_1;

namespace ProvaHiPlatForm
{
    public static class Inicio
    {   
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Executando a prova.");

            switch (ObterOpcao())
            {
                case 1:
                new AutomoveisBLL().ExecutarAutomovel(new Caminhao());
                new AutomoveisBLL().ExecutarAutomovel(new Carro());
                new AutomoveisBLL().ExecutarAutomovel(new Moto());
                break;
                default:
                break;
            }
            
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
