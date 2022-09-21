using AnalisadorLexico.Results;
using System.Text.RegularExpressions;

namespace AnalisadorLexico.Analyzers
{
    public sealed class NumbersTokenAnalyzer : TokenAnalyzer
    {
        private static Regex _expression = new Regex("[0-9](\\.[0-9])*", RegexOptions.Compiled);

        public override TokenResult Test(string lexeme)
        {
            if (_expression.IsMatch(lexeme))
                return new TokenResult(lexeme, "NUM");

            return null;
        }
    }

    public record Token(
        string Operator,
        string Id
    );
}
