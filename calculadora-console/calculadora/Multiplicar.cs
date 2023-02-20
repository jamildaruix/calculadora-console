namespace calculadora
{
    public class Multiplicar : Calculadora
    {
        public Multiplicar(int numeroUm, int numeroDois) : base(numeroUm, numeroDois)
        {
        }

        public void Calcular()
        {
            Console.Write("A multiplicaçao entre {0} * {1} é: {2}", NumeroUm, NumeroDois, NumeroUm * NumeroDois);
        }
    }


}
