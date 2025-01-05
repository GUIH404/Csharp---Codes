

int n1, n2, resul, esc;
int op = 0;

while (op == 0)
{

    Console.WriteLine("=================================");
    Console.WriteLine("=Escolha uma operação           =");
    Console.WriteLine("=1 - Somar                      =");
    Console.WriteLine("=2 - Subtrair                   =");
    Console.WriteLine("=3 - Dividir                    =");
    Console.WriteLine("=4 - Multiplicar                =");
    Console.WriteLine("=5 - Sair                       =");
    Console.WriteLine("=================================");

    op = Convert.ToInt32(Console.ReadLine());

    Console.Clear();


    switch (op)
    {

        case 1:

            do
            {

                Console.Clear();

                Console.WriteLine("Digite o primeiro valor");
                Console.WriteLine();
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Digite o segundo valor");
                Console.WriteLine();
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                resul = n1 + n2;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("O resultado da operação é " + resul);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("=1 - Continuar Operação         =");
                Console.WriteLine("=2 - Sair                       =");
                Console.WriteLine("=================================");

                esc = Convert.ToInt32(Console.ReadLine());


            } while (esc == 1);

            op = 0;

            Console.Clear();

            break;

        case 2:

            do
            {

                Console.Clear();

                Console.WriteLine("Digite o primeiro valor");
                Console.WriteLine();
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Digite o segundo valor");
                Console.WriteLine();
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                resul = n1 - n2;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("O resultado da operação é " + resul);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("=1 - Continuar Operação         =");
                Console.WriteLine("=2 - Sair                       =");
                Console.WriteLine("=================================");

                esc = Convert.ToInt32(Console.ReadLine());


            } while (esc == 1);

            op = 0;

            Console.Clear();

            break;

        case 3:

            do
            {

                Console.Clear();

                Console.WriteLine("Digite o primeiro valor");
                Console.WriteLine();
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Digite o segundo valor");
                Console.WriteLine();
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                resul = n1 / n2;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("O resultado da operação é " + resul);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("=1 - Continuar Operação         =");
                Console.WriteLine("=2 - Sair                       =");
                Console.WriteLine("=================================");

                esc = Convert.ToInt32(Console.ReadLine());


            } while (esc == 1);

            op = 0;

            Console.Clear();

            break;

        case 4:

            do
            {

                Console.Clear();

                Console.WriteLine("Digite o primeiro valor");
                Console.WriteLine();
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Digite o segundo valor");
                Console.WriteLine();
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                resul = n1 * n2;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("O resultado da operação é " + resul);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("=1 - Continuar Operação         =");
                Console.WriteLine("=2 - Sair                       =");
                Console.WriteLine("=================================");

                esc = Convert.ToInt32(Console.ReadLine());


            } while (esc == 1);

            op = 0;

            Console.Clear();

            break;

        case 5:

            Console.Clear();


            break;

        default:

            
            Console.WriteLine("Opção inesxistente");
            Console.ReadLine();

            op = 0;

            Console.Clear();

            break;
    }

}

