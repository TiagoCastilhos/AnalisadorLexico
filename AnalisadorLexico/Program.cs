using AnalisadorLexico.Analyzers;

var analyzers = new List<TokenAnalyzer>
{
    new OperatorsTokenAnalyzer(),
    new DelimiterTokenAnalyzer(),
    new NumbersTokenAnalyzer(),
    new IdentifiersTokenAnalyzer()
    //adicionar os outros analyzers
};

Console.WriteLine("Digite uma string de entrada (use espaco para separar os lexemas):");
Console.WriteLine();

//descomentar a linha abaixo e remover a linha onde seta entradas como uma string fixa
//var entradas = Console.ReadLine().Split(' ');
var entradas = "if ( a > b ) { soma = 10 }".Split(' ');

foreach (var entrada in entradas)
{
    foreach (var analyzer in analyzers)
    {
        var result = analyzer.Test(entrada);

        if (result != null)
        {
            Console.WriteLine($"'{result.Lexeme}' -> {result.Token}");
            break;
        }
    }
}


Console.ReadKey();