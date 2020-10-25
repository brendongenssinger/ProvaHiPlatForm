namespace ProvaHiPlatForm.Exemplos.Questao_1
{
    public class Caminhao : IAutomoves
    {
        public void Acelerar()
        {
            System.Console.WriteLine("Acelerando o caminhão.");
        }

        public void Freiar()
        {
            System.Console.WriteLine("Freiando o caminhão.");
        }

        public void Parar()
        {
            System.Console.WriteLine("Parando caminhão.");
        }
    }
}