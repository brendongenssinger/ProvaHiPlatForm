namespace ProvaHiPlatForm.Exemplos.Questao_1
{
    public class Moto : IAutomoves
    {
        public void Acelerar()
        {
            System.Console.WriteLine("Acelerando a moto."); 
        }

        public void Freiar()
        {
            System.Console.WriteLine("Freaindo a moto.");
        }

        public void Parar()
        {
            System.Console.WriteLine("Parando a moto.");
        }
    }
}