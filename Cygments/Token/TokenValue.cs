namespace Cygments.Token {
  public class TokenValue {
    public TokenValue (string tokenType, string value) {
      TokenType = tokenType;
      Value = value;
    }

    public string TokenType { get; }
    public string Value { get; }
  }
}
