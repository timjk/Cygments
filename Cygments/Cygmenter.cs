using System;

namespace Cygments {
    public static class Cygmenter {
        public static ICygmenterBuilder WithFile(string fileName) {
            //auto pick lexer/formatter
            throw new NotImplementedException();
        }

        public static ICygmenterBuilder WithCode() {
            throw new NotImplementedException();
        }
    }
}