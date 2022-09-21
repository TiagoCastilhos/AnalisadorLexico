using AnalisadorLexico.Results;

namespace AnalisadorLexico.Analyzers
{
    public abstract class TokenAnalyzer
    {
        public abstract TokenResult Test(string lexeme);
    }
}
