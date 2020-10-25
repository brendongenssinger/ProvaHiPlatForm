namespace ProvaHiPlatForm.Exemplos.Questao_1
{
    public class Carro : IAutomoves
    {
        public void Acelerar()
        {
            System.Console.WriteLine("Acelerando o carro.");
        }

        public void Freiar()
        {
            System.Console.WriteLine("Freiando o carro.");
        }

        public void Parar()
        {
            System.Console.WriteLine("Parando o carro.");
        }
    }
}