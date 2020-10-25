using System.Collections.Generic;
using ProvaHiPlatForm.Exemplos.Questao_3.Model;
using System.Linq;
namespace ProvaHiPlatForm.Exemplos.Questao_3
{
    public class EleitorBll
    {
        private static List<Casa> _listaCasas = new List<Casa>();
        
        public static void Executar()
        {
            AddListaCasa();
            var listaRuas = ObterListRuas();    
            listaRuas.ForEach(rua=>
            {
                 System.Console.WriteLine("Rua que irá percorrer será /n");   
                 System.Console.WriteLine($"Rua -> {rua.Nome} - Cep -> {rua.Cep}");
            });
        }

        private static List<Rua> ObterListRuas()
        {
            return _listaCasas.OrderByDescending(pX=> pX.TotalEleitores).Select(pX=> pX.Rua).ToList();
        }

        private static void AddListaCasa()
        {
            _listaCasas.Add(new Casa()
            {
                Rua = new Rua()
                {
                    Cep = "74955030",
                    Nome = "T-63"
                },
                Numero = 1,
                TotalEleitores =500
            });
            _listaCasas.Add(new Casa()
            {
                Rua = new Rua()
                {
                    Cep = "74955035",
                    Nome = "T-7"
                },
                Numero = 73,
                TotalEleitores =376
            });
            _listaCasas.Add(new Casa()
            {
                Rua = new Rua()
                {
                    Cep = "74954030",
                    Nome = "Xuxuzal"
                },
                Numero = 1,
                TotalEleitores =123
            });
            _listaCasas.Add(new Casa()
            {
                Rua = new Rua()
                {
                    Cep = "7499040",
                    Nome = "Irlanda"
                },
                Numero = 90,
                TotalEleitores =990
            });
            _listaCasas.Add(new Casa()
            {
                Rua = new Rua()
                {
                    Cep = "7455322",
                    Nome = "Portugal"
                },
                Numero = 1,
                TotalEleitores =874
            });
            _listaCasas.Add(new Casa()
            {
                Rua = new Rua()
                {
                    Cep = "74355432",
                    Nome = "Camassari"
                },
                Numero = 5,
                TotalEleitores =21
            });
            

        }
    }
}