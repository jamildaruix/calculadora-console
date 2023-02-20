namespace calculadora
{
    /// <summary>
    /// CLasse statica para criação do menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Display inicial
        /// </summary>
        public static void DisplayInicial()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("CALCULADORA NO CONSOLE:");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");

        }

        /// <summary>
        /// Opção para reiniciar a calculadora
        /// </summary>
        /// <returns></returns>
        public static bool ReiniciarDisplay()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Deseja reiniciar a calculadora: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1 - Sim.");
            Console.WriteLine("2 - Não.");
            Console.WriteLine("\n");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.DisplayInicial();
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Digitar primeiro valor
        /// </summary>
        /// <returns></returns>
        public static int PrimeiroValor()
        {
            Console.Write("Entre com primeiro valor :");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            return numero ;
        }

        /// <summary>
        /// Digitar o segundo valor
        /// </summary>
        /// <returns></returns>
        public static int SegundoValor()
        {
            Console.Write("Entre com segundo valor :");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            return numero;
        }

        /// <summary>
        /// Opção selecionada para calculo
        /// </summary>
        /// <returns></returns>
        public static int SelecionarOpcaoCalculo()
        {
            Console.WriteLine("Selecione a opção de calculo :");

            Console.WriteLine("1 - Soma.");
            Console.WriteLine("2 - Subitração.");
            Console.WriteLine("3 - Multiplicação.");
            Console.WriteLine("4 - Divisão.");
            Console.WriteLine("5 - Sair da calculadora.");
            Console.WriteLine("\n");

            Console.WriteLine("Opção :");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
