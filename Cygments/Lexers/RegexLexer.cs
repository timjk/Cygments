using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using Cygments.Token;

namespace Cygments.Lexers {
    // TODO: In Pygments IState is a tuple with a compiled regex, and action and a new_state
    // The tuple can be replaced with a class e.g. 'include('comments')', 'inherit'
    // new_state can be a string, tuple, or a special class 'combined'
    // Action can be a Token, nothing, a special class 'bygroups'
    // Defining these types is going to be quite a challenge
    public interface IState {
        Regex Regex { get; }
        object Action { get; }
        IState NewState { get; }
    }

    public class State : IState {
        public Regex Regex { get; }
        public object Action { get; }
        public IState NewState { get; }

        public State(Regex regex, object action, IState newState) {
            Regex = regex;
            Action = action;
            NewState = newState;
        }
    }

    public class Include : State {
        public Include(Regex regex, object action, IState newState) : base(regex, action, newState) {}
    }

    public class Default : IState {
        public Regex Regex { get; }
        public object Action { get; }
        public IState NewState { get; }
        public IState State { get; }
    }

    public class Inherit : IState {
        public Regex Regex { get; }
        public object Action { get; }
        public IState NewState { get; }
    }

    public class RegexLexer : Lexer {
        public RegexOptions RegexOptions;

        private static IState ProcessNewState(IState newState, Dictionary<IState, List<IState>> unprocessed, Dictionary<IState, List<IState>> processed) {
            throw new NotImplementedException();
        }

        protected List<IState> ProcessState(Dictionary<IState, List<IState>> unprocessed, Dictionary<IState, List<IState>> processed, IState state) {
            if (processed.ContainsKey(state)) {
                return processed[state];
            }
            var tokens = new List<IState>();
            processed[state] = new List<IState>();

            foreach (var tokenDef in unprocessed[state]) {
                //TODO: I don't like this type checking
                var includeTokenDefinition = tokenDef as Include;
                if (includeTokenDefinition != null) {
                    if (tokenDef == state) {
                        throw new InvalidOperationException($"Circular state reference {state}");
                    }
                    tokens.AddRange(ProcessState(unprocessed, processed, new State(includeTokenDefinition.Regex, includeTokenDefinition.Action, includeTokenDefinition.NewState)));
                    continue;
                }

                if (tokenDef is Inherit) {
                    continue;
                }

                IState newState;
                var defaultTokenDefinition = tokenDef as Default;
                if (defaultTokenDefinition != null) {
                    newState = ProcessNewState(defaultTokenDefinition.State, unprocessed, processed);
                    tokens.Add(new State(new Regex(""), null, newState));
                    continue;
                }

                var regex = new Regex(tokenDef.Regex.ToString(), RegexOptions);
                var token = tokenDef.Action;

                newState = tokenDef.NewState == null
                    ? null 
                    : ProcessNewState(tokenDef.NewState, unprocessed, processed);
                tokens.Add(new State(regex, token, newState));
            }
            return tokens;
        }

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