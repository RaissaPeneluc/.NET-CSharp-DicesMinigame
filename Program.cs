Console.Clear();

Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

Console.WriteLine("Jogo da Sorte");
Console.WriteLine("-------------");
Console.WriteLine($"Primeiro dado: {roll1}");
Console.WriteLine($"Segundo dado: {roll2}");
Console.WriteLine($"Terceiro dado: {roll3}");
Console.WriteLine("-------------");

int soma = roll1 + roll2 + roll3;

Console.WriteLine($"Rolagem dos dados: {roll1} + {roll2} + {roll3} = {soma}");
Console.WriteLine(" ");

int pontuacao = soma;

// IF Aninhado para evitar bug de receber dois bônus em uma rolagem.

// Se dois dados rolados resultarem no mesmo valor
if (roll1.Equals(roll2) || roll1.Equals(roll3) || roll2.Equals(roll3))
{
    // Se os três dados rolados resultarem no mesmo valor
    if (roll1.Equals(roll2) && roll2.Equals(roll3))
    {
        Console.WriteLine("Você tirou 3 dados iguais! Ganhou +6 pontos bônus!");
        pontuacao += 6;

    }
    else
    {
        Console.WriteLine("Você tirou 2 dados iguais! Ganhou +2 pontos bônus!");
        pontuacao += 2;
    }

    Console.WriteLine($"Sua pontuação total, incluindo o bônus é: {pontuacao}");
    Console.WriteLine(" ");

}

// Sistema de Regras para Vitória.

if (pontuacao == 7)
{
    Console.WriteLine($"Com a pontuação {pontuacao} que você atingiu, seu prêmio é uma viagem!");
}
else if (pontuacao >= 10)
{
    if (pontuacao >= 16)
    {
        Console.WriteLine($"Com a pontuação {pontuacao} que você atingiu, seu prêmio é um carro novo!");

    }
    else
    {
        Console.WriteLine($"Com a pontuação {pontuacao} que você atingiu, seu prêmio é um laptop novo!");

    }
}

else
{
    Console.WriteLine($"Com a pontuação {pontuacao} que você atingiu, seu prêmio é um gatinho!");
}

