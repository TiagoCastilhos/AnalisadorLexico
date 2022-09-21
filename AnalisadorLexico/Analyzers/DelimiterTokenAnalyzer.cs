using System.Text.RegularExpressions;
using AnalisadorLexico.Results;

namespace AnalisadorLexico.Analyzers
{
    public sealed class DelimiterTokenAnalyzer : TokenAnalyzer
    {
        private static Regex _expression = new Regex("[(\\()*(\\))*(\\{)*(\\})*(\\.)*(\\n)*(\\t)*(\\r)*]+", RegexOptions.Compiled);

        public override TokenResult Test(string lexeme)
        {
            if (_expression.IsMatch(lexeme))
                return new TokenResult(lexeme, "DELIM");

            return null;
        }
    }
}
