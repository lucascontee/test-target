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
Console.WriteLine("\n----------------------------------------------------\n");

//------ Sequência Fibonacci ------

List<int> seqFibonacci = [0, 1];
int i = 0;

while (i < 20)
{
    int nextNumber = seqFibonacci[i] + seqFibonacci[i + 1];
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
Console.WriteLine();
Console.WriteLine("\n----------------------------------------------------\n");




//------ 03 - Faturamento mensal ------
//Não encontrei o json / xml, então criei um array com dados ficticios

Console.WriteLine("\nFaturamento mensal: ");

List<int> faturamentoMensal = [1500, 0, 0, 2000, 1800, 1750, 1900, 1600, 0, 0, 2100, 1850, 1700, 1950, 1600, 0, 0, 2150, 2000, 1750, 1950, 1800, 0, 0, 2050, 1850, 1900, 2000, 0, 0, 0];
faturamentoMensal.RemoveAll(i => i == 0);

Console.WriteLine("\nMenor valor de faturmento ocorrido: " + faturamentoMensal.Min());
Console.WriteLine("Maior valor de faturmento ocorrido: " + faturamentoMensal.Max());

double mediaFaturamentoMensal = faturamentoMensal.Average();

Console.WriteLine("Media mensal: " + mediaFaturamentoMensal);

int contadorDeDias = 0;
foreach (int faturamentoDia in faturamentoMensal) 
{
    if(faturamentoDia > mediaFaturamentoMensal)
    {
        contadorDeDias++;
    }
}

Console.WriteLine($"O faturamento foi maior que a média em {contadorDeDias} dias\n");
Console.WriteLine("\n----------------------------------------------------\n");




//------ 04 - Faturamento mensal por estado------
Console.WriteLine("Faturamento mensal por estado: aaa\n");

double faturamentoSP = 67836.43;
double faturamentoRJ = 36678.66;
double faturamentoMG = 29229.88;
double faturamentoES = 27165.48;
double faturamentoOutros = 19849.53;

double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

Console.WriteLine("Faturamento total: " + faturamentoTotal);
double procentagemSP = faturamentoSP * 100 / faturamentoTotal;
Console.WriteLine("Faturamento em % de SP: " + procentagemSP.ToString("F2") + "%");

double procentagemRJ = faturamentoRJ * 100 / faturamentoTotal;
Console.WriteLine("Faturamento em % de RJ: " + procentagemRJ.ToString("F2") + "%");

double porcentagemMG = faturamentoMG * 100 / faturamentoTotal;
Console.WriteLine("Faturamento em % de MG: " + porcentagemMG.ToString("F2") + "%");

double porcentagemES = faturamentoES * 100 / faturamentoTotal;
Console.WriteLine("Faturamento em % de ES: " + porcentagemES.ToString("F2") + "%");

double porcentagemOutros = faturamentoOutros * 100 / faturamentoTotal;
Console.WriteLine("Faturamento em % dos outros estados: " + porcentagemOutros.ToString("F2") + "%\n\n");

Console.WriteLine("\n----------------------------------------------------\n");


//------ 05 - Invertendo Strings ------

Console.WriteLine("Invertendo Strings");
Console.Write("Digite uma string para ser invertida: ");
var stringUsuario = Console.ReadLine();

stringUsuario.ToCharArray();
string invertida = "";

for (int a = stringUsuario.Length - 1; a >= 0; a--)
{
    invertida += stringUsuario[a];
}

Console.WriteLine("String invertida: " + invertida);

