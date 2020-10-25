namespace ProvaHiPlatForm.Exemplos.Questao_1.Bll
{
    public class AutomoveisBLL
    {
        public void ExecutarAutomovel(IAutomoves automovel, int opcao = -1)
        {
            switch (opcao)
            {
                case 1 :
                    automovel.Acelerar();
                break;
                case 2:
                    automovel.Parar();
                break;
                case 3:
                    automovel.Freiar();
                break;
                default:
                    automovel.Acelerar();
                    automovel.Parar();
                    automovel.Freiar();
                break;
            }
        }
    }
}