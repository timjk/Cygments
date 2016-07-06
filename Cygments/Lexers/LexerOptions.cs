namespace Cygments.Lexers {
    public class LexerOptions {
        public bool StripNewline { get; set; }
        public bool StripAll { get; set; }
        public bool EnsureNewline { get; set; }
        public int TabSize { get; set; }
        // TODO: Make Enums
        public string Encoding { get; set; }
        public string InEncoding { get; set; }
    }
}