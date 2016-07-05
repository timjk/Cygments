using System;
using System.Collections.Generic;
using Cygments.Token;

namespace Cygments.Lexers {
  public class RegexLexer : Lexer {
    private static void ProcessNewState(string newState, object unprocessed) {
      return null;
    }

    public override IEnumerable<Tuple<int, TokenValue>> GetTokensUnprocessed() {
      return null;
    }
  }
}

