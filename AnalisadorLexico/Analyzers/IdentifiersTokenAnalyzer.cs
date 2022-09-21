using System.Text.RegularExpressions;
using AnalisadorLexico.Results;

namespace AnalisadorLexico.Analyzers
{
    public sealed class IdentifiersTokenAnalyzer : TokenAnalyzer
    {
        private static Regex _expression = new Regex("[a-zA-Z]", RegexOptions.Compiled);

        public override TokenResult Test(string lexeme)
        {
            if (_expression.IsMatch(lexeme))
                return new TokenResult(lexeme, "ID");

            return null;
        }
    }
}
