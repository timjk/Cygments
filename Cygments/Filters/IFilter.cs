using System;
using System.IO;
using System.Collections.Generic;
using Cygments.Lexers;
using Cygments.Token;

namespace Cygments.Filters {
  public interface IFilter {
    IEnumerable<TokenValue> Filter(ILexer lexer, Stream stream);
  }
}
