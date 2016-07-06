using System;

namespace Cygments {
    internal class CygmenterBuilder : ICygmenterBuilder {
        private string _code;

        public CygmenterBuilder(string code) {
            _code = code;
        }

        public ICygmenterBuilder WithLexer() {
            throw new NotImplementedException();
        }

        public ICygmenterBuilder WithFormatter() {
            throw new NotImplementedException();
        }

        public string Highlight() {
            throw new NotImplementedException();
        }

        public void Highlight(string file) {
            //auto pick lexer/formatter
            throw new NotImplementedException();
        }

        public string Format() {
            throw new NotImplementedException();
        }

        public void Format(string file) {
            throw new NotImplementedException();
        }

        public string Lex() {
            throw new NotImplementedException();
        }

        public void Lex(string file) {
            throw new NotImplementedException();
        }
    }
}