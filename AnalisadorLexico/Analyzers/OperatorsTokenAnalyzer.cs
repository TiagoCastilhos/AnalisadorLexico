using AnalisadorLexico.Results;

namespace AnalisadorLexico.Analyzers
{
    public sealed class OperatorsTokenAnalyzer : TokenAnalyzer
    {
        private static IEnumerable<Token> _tokens = new List<Token>
        {
            new Token("+", "OP_ADD"),
            new Token("-", "OP_SUB"),
            new Token("/", "OP_DIV"),
            new Token("*", "OP_MUL"),
            new Token(">", "OP_GT"),
            new Token(">=", "OP_GTE"),
            new Token("<", "OP_LT"),
            new Token("<=", "OP_LTE"),
            new Token("==", "OP_EQ"),
            new Token("<>", "OP_NE")
        };

        public override TokenResult Test(string lexeme)
        {
            foreach (var token in _tokens)
            {
                if (lexeme.Equals(token.Operator))
                    return new TokenResult(lexeme, token.Id);
            }

            return null;
        }
    }
}
