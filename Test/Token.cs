using Xunit;
using Tkn = Cygments.Token.Token;

namespace TokenTests {
    public class Token {
        [Fact]
        public void TokenSubtype() {
            Assert.True(Tkn.Name.Builtin.Psuedo.IsSubtypeOf(Tkn.Name.Builtin.Psuedo));
            Assert.True(Tkn.Name.Builtin.Psuedo.IsSubtypeOf(Tkn.Name.Value));
            Assert.False(Tkn.Name.Value.IsSubtypeOf(Tkn.Name.Builtin.Psuedo));
        }

        [Fact]
        public void TokenType() {
            var token = Tkn.Literal.Date;

            Assert.Equal(token.Split(), new[] {Tkn.Value.Name, Tkn.Literal.Value.Name, Tkn.Literal.Date.Name});
        }
    }
}