// 6. Durante uma eleição, um mesário deve contar os votos. O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0. O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for.

int votosCandidatoA = 0;
int votosCandidatoB = 0;
int voto;
Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B) até que digite 0 para sair.");
while (true)
{
    Console.Write("Voto: ");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0)
    {
        break;
    }
    if (voto == 1)
    {
        votosCandidatoA++;
    }
    else if (voto == 2)
    {
        votosCandidatoB++;
    }
    Console.WriteLine($"Votos candidato A: {votosCandidatoA}");
    Console.WriteLine($"Votos candidato B: {votosCandidatoB}");
}

// do while
votosCandidatoA = 0;
votosCandidatoB = 0;
do
{
    Console.Write("Voto: ");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0)
    {
        break;
    }
    if (voto == 1)
    {
        votosCandidatoA++;
    }
    else if (voto == 2)
    {
        votosCandidatoB++;
    }
    Console.WriteLine($"Votos candidato A: {votosCandidatoA}");
    Console.WriteLine($"Votos candidato B: {votosCandidatoB}");
} while (true);

// for
votosCandidatoA = 0;
votosCandidatoB = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Voto: ");
    voto = int.Parse(Console.ReadLine());
    if (voto == 0)
    {
        break;
    }
    if (voto == 1)
    {
        votosCandidatoA++;
    }
    else if (voto == 2)
    {
        votosCandidatoB++;
    }
    Console.WriteLine($"Votos candidato A: {votosCandidatoA}");
    Console.WriteLine($"Votos candidato B: {votosCandidatoB}");
}
