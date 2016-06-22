using System;
using System.Collections.Generic;
using System.Linq;

namespace Cygments.Token {
  public interface ITokenType {
    string Name { get; }
    string CSSClass { get; }
  }

  public class TokenType : ITokenType {
    private readonly TokenType _parent;

    public string Name { get; }
    public string CSSClass { get; }

    public TokenType (string name, string cSSClass)
     : this(name, cSSClass, null) {
    }

    public TokenType (string name, string cSSClass, TokenType parent) {
       _parent = parent;
      Name = name;
      CSSClass = cSSClass; 
    }

    public string[] Split() {
      Stack<string> stack = new Stack<string>();
      TokenType token = this;

      while (token != null) {
       stack.Push(token.Name);
       token = token._parent;
      }

      return stack.ToArray();
    }

    public bool IsSubtypeOf(TokenType other) {
      TokenType token = this;

      while (token != null) {
        if (other.Name == token.Name) {
          return true;
        }
        token = token._parent;
      }
      return false;
    }
  }
}
