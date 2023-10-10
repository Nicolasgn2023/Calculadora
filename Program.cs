

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
                Console.WriteLine("|           5.Potência             |");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|             6.Sair               |");
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
                            potencia();
                            break;
                        case 6:
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
               
                try
                {
                    Console.WriteLine("Digite um número:");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Digite outro número:");
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            double soma = n1 + n2;
                            Console.WriteLine($"O resultado da sua soma é : {n1} + {n2} = {soma}");
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("O número digitado é inválido! Tente novamente.");

                        }
                    }

                }
                catch
                {
                    Console.WriteLine("O número digitado é inválido! Tente novamente.");
                    somar();
                }


            }

            static void subtrair()
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Digite outro número:");
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            double sub = n1 - n2;
                            Console.WriteLine($"O resultado da sua subtração é: {n1} - {n2} = {sub}");
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Você digitou um número inválido! Tente novamente.");
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Você digitou um número inválido! Tente novamente.");
                    subtrair();
                }
            }

            static void multiplicar()
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Digite outro número:");
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            double mult = n1 * n2;
                            Console.WriteLine($"O resultado da sua multiplicação é: {n1} X {n2} = {mult}");
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("O número digitado é inválido! Tente novamente.");

                        }


                    }
                }
                catch
                {
                    Console.WriteLine("O número digitado é inválido! Tente novamente.");
                    multiplicar();
                }

            }

            static void dividir()
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Digite outro número:");
                            double n2 = Convert.ToDouble(Console.ReadLine());
                            if (n2 != 0)
                            {
                                double dividir = n1 / n2;
                                double restodiv = n1 % n2;
                                Console.WriteLine($"O resultado da sua divisão é: {n1} ÷ {n2} = {dividir} com resto {restodiv}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Não é possível dividir um número por 0.");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("O número digitado é inválido! Tente novamente.");
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("O número digitado é inválido! Tente novamente.");
                    dividir();
                }
            }

            static void potencia()
            {
                try
                {
                    Console.WriteLine("Digite um número:");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    while (true)
                    { 
                    try
                    {
                        Console.WriteLine("Digite o expoente:");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                         double potencia = Math.Pow(n1,n2);
                        Console.WriteLine($"O resultado da pontência de: {n1}^{n2} = {potencia} ");
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("O número digitado é inválido!");


                    }
                    }
                }
                catch
                {
                    Console.WriteLine("O número digitado é inválido! Tente novamente.");
                    potencia();
                }
            }

        }

       

    }
}







