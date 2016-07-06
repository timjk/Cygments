using System;
using System.Collections.Generic;
using Cygments.Token;

namespace Cygments.Lexers {
    public interface ILexer {
        void AddFilter(string filter, string[] options);
        float AnalyseText(string text);
        IEnumerable<TokenValue> GetTokens(string text, bool unfiltered);
        IEnumerable<Tuple<object>> GetTokensUnprocessed(string text);
    }
}