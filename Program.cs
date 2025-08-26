namespace Lanchonet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double total = 0;
            do
            {
                Console.WriteLine("Menu da lanchonete");
                Console.WriteLine("1-Coca-cola- R$8,00");
                Console.WriteLine("2-Pizza R$50,00");
                Console.WriteLine("3-Hamburger R$25,00");
                Console.WriteLine("4-Cachorro quente R$20,00");
                Console.WriteLine("5-Batata R$6,00");
                Console.WriteLine("6-Finalizar pedido");
                Console.Write("Qual opção deseja? ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Coca-cola adicionada com sucesso");
                        total += 8.00;
                        break;
                    case 2:
                        Console.WriteLine("Pizza adionada com sucesso");
                        total += 50.00;
                        break;
                    case 3:
                        Console.WriteLine("Hamburger adicionado com sucesso");
                        total += 25.00;
                        break;
                    case 4:
                        Console.WriteLine("Cachorro quente adicionado com sucesso");
                        total += 20.00;
                        break;
                    case 5:
                        Console.WriteLine("Batata adicionada com sucesso");
                        total += 6.00;
                        break;
                    case 6:
                        Console.WriteLine("Pedido finalizado");
                        break;
                }

            } while (opcao !=6);

            Console.WriteLine($"Total do pedido: R${total:F2}");
            Console.WriteLine("Obrigado pela compra, volte sempre");




        }
    }
}
