namespace calculadora
{
    public class Dividir : Calculadora
    {
        public Dividir(int numeroUm, int numeroDois) : base(numeroUm, numeroDois)
        {
        }

        public void Calcular()
        {
            if (NumeroDois == 0)
            {
                Console.WriteLine("O Segundo número não pode ser igual a zero, pois vai dar erro no calculo");
            }
            else
            {
                Console.WriteLine("A divisão para {0} / {1} é : {2}", NumeroUm, NumeroDois, NumeroUm / NumeroDois);
            }
        }
    }


}
