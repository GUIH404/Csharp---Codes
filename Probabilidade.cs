
//String[] Array = { "Verde", "Verde", "Verde", "Verde", "Verde", "Verde", "Amarelo", "Amarelo", "Amarelo", "Amarelo", "Rosa", "Rosa", "Rosa", "Vermelho", "Vermelho", "Roxo", "Roxo", "Azul" };
//
//Random random = new Random();
//
//int sorteio = random.Next(Array.Length);
//String escolhido = Array[sorteio];
//
//Console.WriteLine($"A cor escolhida foi: {escolhido}");
//
//=============================================[Primeiro Código]=============================================\\
//
//
String[] Cor = { "Verde", "Amarelo", "Rosa", "Vermelho", "Roxo", "Azul" };
int[] probabilidade = { 31, 20, 16, 14, 13, 6 };

Random random = new Random();
int sorteio = random.Next(1, 101);

String resultado = ElementoSorteado(sorteio, Cor, probabilidade);

static String ElementoSorteado(int sorteio, String[] Cor, int[] probabilidade)
{

    int acumulador = 0;

    for (int i = 0; i < Cor.Length; i++)
    {

        acumulador += probabilidade[i];
        if (sorteio <= acumulador)
        {

            Console.WriteLine($"Sua cor é {Cor[i]}");
            return Cor[i];



        }
    }
    throw new Exception("Erro: A soma das probabilidades não cobre o intervalo esperado.");
}
