Console.WriteLine(@$"Bem-vindo a Wand passagens aereas! Vamos iniciar seu atendimento! ");

int indexPassageiro = 0;
string[] passageiro = new string[5];
string[] origem = new string[5];
string[] destino = new string[5];
string[] data = new string[5];

Console.WriteLine($"Digite a sua senha : ");
int senha = int.Parse(Console.ReadLine());

while (senha != 123456)
{
    Console.WriteLine($"Senha incorreta! Digite novamente:");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
Selecione a opção que desejada:
1 - Cadastrar Passagem
2 - Listar Passagens
0- Sair");
char escolha = char.Parse(Console.ReadLine());

switch (escolha)
{
    case '1':
        Console.WriteLine($"Informe seu nome: ");
        passageiro[indexPassageiro] = Console.ReadLine();
        Console.WriteLine($"Qual a origem do voo?: ");
        origem[indexPassageiro] = Console.ReadLine();
        Console.WriteLine($"Qual o destino do voo?: ");
        destino[indexPassageiro] = Console.ReadLine();
        Console.WriteLine($"Qual a data do voo?: ");
        data[indexPassageiro] = Console.ReadLine();
        indexPassageiro++;
        Console.WriteLine($"Sua passagem foi cadastrada, Boa viagem!");
        break;

    case '2':
        for (int i = 0; i < indexPassageiro; i++)
        {
            Console.WriteLine($"Passagem #{i + 1}");
            Console.WriteLine($"Nome do passageiro: {passageiro[i]}");
            Console.WriteLine($"Origem do voo: {origem[i]}");
            Console.WriteLine($"Destino do voo: {destino[i]}");
            Console.WriteLine($"Data do voo: {data[i]}");
        }
        break;

    case '0':
        Console.WriteLine($"Volte sempre! :)");
        break;
}

while (escolha == '1' || escolha == '2')
{
    Console.WriteLine($"Deseja realizar mais alguma operação? Digite 's' para sim e 'n' para não.");
    char escolha2 = char.Parse(Console.ReadLine());

    if (escolha2 == 's')
    {
        Console.WriteLine(@$"
        Ótimo! Vamos lá.
        Selecione a opção desejada:
        1 - Cadastrar Passagem
        2 - Listar Passagens
        0- Sair");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == '1')
        {
            Console.WriteLine($"Informe seu nome: ");
            passageiro[indexPassageiro] = Console.ReadLine();
            Console.WriteLine($"Qual a origem do voo?: ");
            origem[indexPassageiro] = Console.ReadLine();
            Console.WriteLine($"Qual o destino do voo?: ");
            destino[indexPassageiro] = Console.ReadLine();
            Console.WriteLine($"Qual a data do voo?: ");
            data[indexPassageiro] = Console.ReadLine();
            indexPassageiro++;

            Console.WriteLine($"Sua passagem foi cadastrada, Boa viagem!");
        }
        else if (escolha == '2')
        {
            for (int i = 0; i < indexPassageiro; i++)
            {
                Console.WriteLine($"Passagem #{i + 1}");
                Console.WriteLine($"Nome do passageiro: {passageiro[i]}");
                Console.WriteLine($"Origem do voo: {origem[i]}");
                Console.WriteLine($"Destino do voo: {destino[i]}");
                Console.WriteLine($"Data do voo: {data[i]}");
                Console.WriteLine($"");
            }
        }
    }
    else
    {
        Console.WriteLine($"Volte sempre! :)");
        break;
    }
}