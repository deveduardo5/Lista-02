// 7. Um ciclista deseja saber a distância total que percorreu. Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição.

double distanciaTotal = 0;
double distancia;
Console.WriteLine("Digite as distâncias percorridas em cada dia até que digite um valor negativo para sair.");
while (true)
{
    Console.Write("Distância: ");
    distancia = double.Parse(Console.ReadLine());
    if (distancia < 0)
    {
        break;
    }
    distanciaTotal += distancia;
    Console.WriteLine($"Distância total: {distanciaTotal}");
}

// do while
distanciaTotal = 0;
do
{
    Console.Write("Distância: ");
    distancia = double.Parse(Console.ReadLine());
    if (distancia < 0)
    {
        break;
    }
    distanciaTotal += distancia;
    Console.WriteLine($"Distância total: {distanciaTotal}");
} while (true);

// for
distanciaTotal = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Distância: ");
    distancia = double.Parse(Console.ReadLine());
    if (distancia < 0)
    {
        break;
    }
    distanciaTotal += distancia;
    Console.WriteLine($"Distância total: {distanciaTotal}");
}
