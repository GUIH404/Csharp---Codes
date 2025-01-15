
int contador = 0;
double media = 0;
double soma = 0;

List<double> numeros = new List<double>();

while (true)
{

    Console.WriteLine("Digite um número (ou 'sair' para finalizar):");
    String entrada = Console.ReadLine();

    if (double.TryParse(entrada, out double numero))
    {

        numeros.Add(numero);
        contador++;
        
        

    }else if (entrada.ToLower() == "sair")
    {

        break;

    } else
    {
        Console.Clear();
        Console.WriteLine("Opção invalida");
        Console.ReadKey();
        Console.Clear();

    }
}



foreach (double numero in numeros)
{

    soma += numero;
    media = soma / contador;

}

Console.WriteLine("\nNúmeros armazenados:");
Console.WriteLine(string.Join(",", numeros));
Console.WriteLine();
Console.WriteLine($"{soma:F2}");
Console.WriteLine($"{media:F2}");
