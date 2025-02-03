// 8. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0. O programa deve calcular o total de minutos atendidos, utilizando while, do while e for.

int chamadasAtendidas = 0;
int tempo;
while (true)
{
    Console.Write("Tempo de duração da chamada (minutos): ");
    tempo = int.Parse(Console.ReadLine());
    if (tempo == 0)
    {
        break;
    }
    chamadasAtendidas += tempo;
    Console.WriteLine($"Total de minutos atendidos: {chamadasAtendidas}");
}

// do while
chamadasAtendidas = 0;
do
{
    Console.Write("Tempo de duração da chamada (minutos): ");
    tempo = int.Parse(Console.ReadLine());
    if (tempo == 0)
    {
        break;
    }
    chamadasAtendidas += tempo;
    Console.WriteLine($"Total de minutos atendidos: {chamadasAtendidas}");
} while (true);

// for
chamadasAtendidas = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Tempo de duração da chamada (minutos): ");
    tempo = int.Parse(Console.ReadLine());
    if (tempo == 0)
    {
        break;
    }
    chamadasAtendidas += tempo;
    Console.WriteLine($"Total de minutos atendidos: {chamadasAtendidas}");
}
