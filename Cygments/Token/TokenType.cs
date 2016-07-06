using System.Collections.Generic;

namespace Cygments.Token {
    public class TokenType : ITokenType {
        private readonly TokenType _parent;

        public TokenType(string name, string cSSClass)
            : this(name, cSSClass, null) {}

        public TokenType(string name, string cSSClass, TokenType parent) {
            _parent = parent;
            Name = name;
            CSSClass = cSSClass;
        }

        public string Name { get; }
        public string CSSClass { get; }

        public string[] Split() {
            var stack = new Stack<string>();
            var token = this;

            while (token != null) {
                stack.Push(token.Name);
                token = token._parent;
            }

            return stack.ToArray();
        }

        public bool IsSubtypeOf(TokenType other) {
            var token = this;

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