using System.Runtime.Serialization;

int soma = 0;
int k = 0;
int indice = 13;

while (k < indice)
{
    k++;
    soma = soma + k;
}

Console.WriteLine(soma);
Console.WriteLine();

//------ Sequência Fibonacci

List<int> seqFibonacci = [0, 1];
int i = 0;

while(i < 20)
{
    int nextNumber = seqFibonacci[i] + seqFibonacci[i+ 1];
    seqFibonacci.Add(nextNumber);
    i++;
}

Console.WriteLine("Veja se um número pertence a sequência de Fibonacci:");
Console.Write("Digite o número aqui: ");
int entradaUsuario = Convert.ToInt32(Console.ReadLine());

if (seqFibonacci.Contains(entradaUsuario))
{
    Console.WriteLine($"O número digitado ({entradaUsuario}) pertence a sequência de Fibonecci\n");
}
else
{
    Console.WriteLine($"O número digitado ({entradaUsuario}) não pertence a sequência de Fibonecci\n");
}


Console.WriteLine("Sequencia Fibonacci:");
foreach (int j in seqFibonacci)
{
    Console.Write(j + ", ");
}



