using System.Collections.Generic;
using System.IO;
using Cygments.Lexers;
using Cygments.Token;

namespace Cygments.Filters {
    public interface IFilter {
        IEnumerable<TokenValue> Filter(ILexer lexer, Stream stream);
    }
}