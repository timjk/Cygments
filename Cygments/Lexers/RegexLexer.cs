using System;
using System.Collections.Generic;
using System.Reflection;
using Cygments.Token;

namespace Cygments.Lexers {
    public class Inherit {
        //TODO: How to treat this inherit object? Implement some general token definition interface
    }

    public class RegexLexer : Lexer {
        private static void ProcessNewState(string newState, object unprocessed) {}
        private static void ProcessNewState(object newState, object unprocessed, object processed) {}
        private static void ProcessNewState(Tuple<string, string> newState, object unprocessed) {}

        protected Dictionary<string, List<object>> GetTokenDefs() {
            var tokens = new Dictionary<string, List<object>>();
            var inherit = new HashSet<string>();
            var inherited = false;
            var currentType = GetType();

            while (currentType == typeof(Lexer)) {
                foreach(var token in GetTokens(currentType)) {
                    if (inherit.Contains(token.Key)) {
                        tokens[token.Key].AddRange(token.Value);
                        inherit.Remove(token.Key);
                        inherited = true;
                    }

                    if (tokens.ContainsKey(token.Key) && !inherited)
                        continue;

                    if (!inherited) {
                        tokens[token.Key] = token.Value;
                    }

                    foreach (var o in tokens[token.Key]) {
                        if (o is Inherit) {
                            inherit.Add(token.Key);
                        }
                    }
                }

                currentType = currentType.GetTypeInfo().BaseType;
                inherited = false;
            }
            
            return tokens;
        }

        private static Dictionary<string, List<object>> GetTokens(Type type) {
            var tokens = new Dictionary<string, List<object>>();

            var prop = type?.GetProperty("Token");
            if (prop == null) {
                return tokens;
            }

            try {
                var obj = Activator.CreateInstance(type);
                tokens = (Dictionary<string, List<object>>)prop.GetValue(obj);
            } catch (Exception) {
                //TODO: Log error
            }

            return tokens;
        }

        public override IEnumerable<Tuple<int, TokenValue>> GetTokensUnprocessed() {
            return null;
        }
    }
}