namespace ProvaHiPlatForm.Exemplos.Questao_2
{
    public class HiperMercado
    {
        // pCusto em reais.
        // pValidade em dias.
        public static HiperMercado HI = new HiperMercado();
        public double FormulaMagica(double pCusto, int pValidade)
        {
            return pCusto/pValidade;
        }
    }
}