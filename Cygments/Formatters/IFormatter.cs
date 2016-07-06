using System.Collections.Generic;
using System.IO;
using Cygments.Token;

namespace Cygments.Formatters {
    public interface IFormatter {
        string GetStyleDefs();
        Stream Format(IEnumerable<TokenValue> tokenSource, string outFile);
    }
}