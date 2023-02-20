// See https://aka.ms/new-console-template for more information

using calculadora;

bool showMenu = true;

//Laço para não sair do console enquanto a variavel showMenu for verdadeiro
while (showMenu)
{
    int numero1, numero2, opcao;

    Menu.DisplayInicial();
    numero1 = Menu.PrimeiroValor();
    numero2 = Menu.SegundoValor();
    opcao = Menu.SelecionarOpcaoCalculo();

    switch (opcao)
    {
        case 1:
            Somar somar = new Somar(numero1, numero2);
            somar.Calcular();
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 2:
            Subtrair subtrair = new Subtrair(numero1, numero2);
            subtrair.Calcular();
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 3:
            Multiplicar multiplicar = new Multiplicar(numero1, numero2);
            multiplicar.Calcular();
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 4:
            Dividir dividir = new Dividir(numero1, numero2);
            dividir.Calcular();
            showMenu = Menu.ReiniciarDisplay();
            break;

        case 5:
            Console.Write("Tchau !!! ");
            showMenu = false;
            break;

        default:
            Console.WriteLine("Dados com erros, aguarde 5 segundos para a tela carregar display inicial");
            Thread.Sleep(5000);
            Menu.DisplayInicial();
            break;
    }

}
