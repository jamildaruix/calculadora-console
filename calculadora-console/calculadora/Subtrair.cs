namespace calculadora
{
    public class Subtrair : Calculadora
    {
        public Subtrair(int numeroUm, int numeroDois) : base(numeroUm, numeroDois)
        {
        }

        public void Calcular()
        {
             Console.WriteLine("A subtração entre {0} - {1} é: {2}", NumeroUm, NumeroDois, NumeroUm - NumeroDois);
        }
    }


}
