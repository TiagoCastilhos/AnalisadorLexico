using AnalisadorLexico.Analyzers;

var analyzers = new List<TokenAnalyzer>
{
    new AttributionTokenAnalyzer(),
    new ReservedTokenAnalyzer(),
    new NumbersTokenAnalyzer(),
    new OperatorsTokenAnalyzer(),
    new DelimiterTokenAnalyzer(),
    new IdentifiersTokenAnalyzer()
};

var userInput = "1";

while (userInput == "1")
{
    Console.WriteLine("Digite uma string de entrada (use espaco para separar os lexemas):");
    Console.WriteLine();

    var entries = Console.ReadLine().Split(' ');

    foreach (var entry in entries)
    {
        foreach (var analyzer in analyzers)
        {
            var result = analyzer.Test(entry);

            if (result != null)
            {
                Console.WriteLine($"'{result.Lexeme}' -> {result.Token}");
                break;
            }
        }
    }

    Console.WriteLine("Digite 1 para continuar ou qualquer outra tecla para sair");
    userInput = Console.ReadLine();
}