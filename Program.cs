

namespace calculadora
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {


                Console.WriteLine("----------------------------------");
                Console.WriteLine("|           Calculadora            |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|            1.Somar               |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|           2.Subtração            |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|         3.Multiplicação          |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|           4.Divisão              |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|             5.Sair               |");
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out int _choice))
                {
                    switch (_choice)
                    {
                        case 1:
                            somar();
                            break;
                        case 2:
                            subtrair();
                            break;
                        case 3:
                            multiplicar();
                            break;
                        case 4:
                            dividir();
                            break;
                        case 5:
                            continuar = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                }

            }
            static void somar()
            {
                Console.WriteLine("Digite um número:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int soma = n1 + n2;
                Console.WriteLine($"O resultado da sua soma é : {n1} + {n2} = {soma}");

            }

            static void subtrair()
            {
                Console.WriteLine("Digite um número:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int sub = n1 - n2;
                Console.WriteLine($"O resultado da sua subtração é: {n1} - {n2} = {sub}");
            }

            static void multiplicar()
            {
                Console.WriteLine("Digite um número:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                int n2 = Convert.ToInt32(Console.ReadLine());
                int mult = n1 * n2;
                Console.WriteLine($"O resultado da sua multiplicação é: {n1} X {n2} = {mult}");

            }

            static void dividir()
            {
                Console.WriteLine("Digite um número:");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite outro número:");
                double n2 = Convert.ToDouble(Console.ReadLine());
                double dividir = n1 / n2;
                double restodiv = n1 % n2;
                Console.WriteLine($"O resultado da sua divisão é: {n1} % {n2} = {dividir} com resto {restodiv}");
            }

        }
    }
}
