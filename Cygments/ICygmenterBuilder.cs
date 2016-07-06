namespace Cygments {
    public interface ICygmenterBuilder {
        ICygmenterBuilder WithLexer();
        ICygmenterBuilder WithFormatter();
        string Highlight();
        string Lex();
        string Format();
        void Highlight(string fileName);
        void Lex(string fileName);
        void Format(string fileName);
    }
}