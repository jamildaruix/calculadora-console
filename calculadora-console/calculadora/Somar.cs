namespace calculadora
{
    public class Somar : Calculadora 
    {
        public Somar(int numeroUm, int numeroDois) : base(numeroUm, numeroDois)
        {
        }

        public void Calcular()
        {
            Console.WriteLine("A soma entre  {0} + {1} é: {2}", NumeroUm, NumeroDois, NumeroUm + NumeroDois);
        }
    }


}
