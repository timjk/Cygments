using System;
using System.Collections.Generic;
using System.Linq;
using Cygments.Filters;
using Cygments.Token;

namespace Cygments.Lexers {
  public class Lexer {
    public string Name { get; }
    public string[] Aliases { get; }
    public string[] Filenames { get; }
    public string[] AliasFilenames { get; }
    public string[] MimeTypes { get; }
    public int Priority { get; }

    private readonly LexerOptions _options = new LexerOptions();
    private ICollection<IFilter> _filters = new List<IFilter>();

    public Lexer() { }

    public Lexer(ICollection<IFilter> filters) {
      _filters = filters;
    }

    public Lexer(LexerOptions options) {
      _options = options;
    }

    public Lexer(ICollection<IFilter> filters, LexerOptions options) {
      _options = options;
      _filters = filters;
    }

    public void AddFilter(IFilter filter) {
      _filters.Add(filter);
    }

    public float AnalyzeText(string text) {
      throw new NotImplementedException();
    }

    public IEnumerable<TokenValue> GetTokens(string text, bool unfiltered = false) {
      //TODO: PreProcess 
      return GetTokensUnprocessed()
        .Select(x => x.Item2);
    }

    public virtual IEnumerable<Tuple<int, TokenValue>> GetTokensUnprocessed() {
      throw new NotImplementedException();
    }
  }
}
