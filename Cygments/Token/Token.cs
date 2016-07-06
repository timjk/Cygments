namespace Cygments.Token {
    public static class Token {
        public static readonly TokenType Value = new TokenType("Token", "");
        public static readonly TokenType Text = new TokenType("Text", "");
        public static readonly TokenType Whitespace = new TokenType("Whitespace", "w");
        public static readonly TokenType Escape = new TokenType("Escape", "esc");
        public static readonly TokenType Error = new TokenType("Error", "err");
        public static readonly TokenType Other = new TokenType("Other", "x");
        public static readonly TokenType Punctuation = new TokenType("Punctuation", "p");

        public static class Keyword {
            public static readonly TokenType Value = new TokenType("Keyword", "k", Token.Value);
            public static readonly TokenType Constant = new TokenType("Constant", "kc", Value);
            public static readonly TokenType Declaration = new TokenType("Declaration", "kd", Value);
            public static readonly TokenType Namespace = new TokenType("Namespace", "kn", Value);
            public static readonly TokenType Psuedo = new TokenType("Psuedo", "kp", Value);
            public static readonly TokenType Reserved = new TokenType("Reserved", "kr", Value);
            public static readonly TokenType Type = new TokenType("Type", "kt", Value);
        }

        public static class Name {
            public static readonly TokenType Value = new TokenType("Name", "n", Token.Value);
            public static readonly TokenType Attribute = new TokenType("Attribute", "na", Value);
            public static readonly TokenType Class = new TokenType("Class", "nc", Value);
            public static readonly TokenType Constant = new TokenType("Constant", "no", Value);
            public static readonly TokenType Decorator = new TokenType("Decorator", "nd", Value);
            public static readonly TokenType Entity = new TokenType("Entity", "ni", Value);
            public static readonly TokenType Exception = new TokenType("Exception", "ne", Value);
            public static readonly TokenType Property = new TokenType("Property", "py", Value);
            public static readonly TokenType Label = new TokenType("Label", "nl", Value);
            public static readonly TokenType Namespace = new TokenType("Namespace", "nn", Value);
            public static readonly TokenType Other = new TokenType("Other", "nx", Value);
            public static readonly TokenType Tag = new TokenType("Tag", "nt", Value);

            public static class Builtin {
                public static readonly TokenType Value = new TokenType("Builtin", "nb", Name.Value);
                public static readonly TokenType Psuedo = new TokenType("Psuedo", "bp", Value);
            }

            public static class Function {
                public static readonly TokenType Value = new TokenType("Function", "nf", Name.Value);
                public static readonly TokenType Magic = new TokenType("Magic", "fm", Value);
            }

            public static class Variable {
                public static readonly TokenType Value = new TokenType("Variable", "nv", Name.Value);
                public static readonly TokenType Class = new TokenType("Class", "vc", Value);
                public static readonly TokenType Global = new TokenType("Global", "vg", Value);
                public static readonly TokenType Instance = new TokenType("Instance", "vi", Value);
                public static readonly TokenType Magic = new TokenType("Magic", "vm", Value);
            }
        }

        public static class Literal {
            public static readonly TokenType Value = new TokenType("Literal", "l", Token.Value);
            public static readonly TokenType Date = new TokenType("Date", "ld", Value);
        }

        public static class String {
            public static readonly TokenType Value = new TokenType("String", "s", Token.Value);
            public static readonly TokenType Affix = new TokenType("Affix", "sa", Value);
            public static readonly TokenType Backtick = new TokenType("Backtick", "sb", Value);
            public static readonly TokenType Char = new TokenType("Char", "sc", Value);
            public static readonly TokenType Delimiter = new TokenType("Delimiter", "dl", Value);
            public static readonly TokenType Doc = new TokenType("Doc", "sd", Value);
            public static readonly TokenType Double = new TokenType("Double", "s2", Value);
            public static readonly TokenType Escape = new TokenType("Escape", "se", Value);
            public static readonly TokenType Heredoc = new TokenType("Heredoc", "sh", Value);
            public static readonly TokenType Interpol = new TokenType("Interpol", "si", Value);
            public static readonly TokenType Other = new TokenType("Other", "sx", Value);
            public static readonly TokenType Regex = new TokenType("Regex", "sr", Value);
            public static readonly TokenType Single = new TokenType("Single", "s1", Value);
            public static readonly TokenType Symbol = new TokenType("Symbol", "ss", Value);
        }

        public static class Number {
            public static readonly TokenType Value = new TokenType("Number", "m", Token.Value);
            public static readonly TokenType Bin = new TokenType("Bin", "mb", Value);
            public static readonly TokenType Float = new TokenType("Float", "mf", Value);
            public static readonly TokenType Hex = new TokenType("Hex", "mh", Value);
            public static readonly TokenType Oct = new TokenType("Oct", "mo", Value);

            public static class Integer {
                public static readonly TokenType Value = new TokenType("Integer", "mi", Number.Value);
                public static readonly TokenType Long = new TokenType("Long", "il", Value);
            }
        }

        public static class Operator {
            public static readonly TokenType Value = new TokenType("Operator", "o", Token.Value);
            public static readonly TokenType Word = new TokenType("Word", "ow", Value);
        }

        public static class Comment {
            public static readonly TokenType Value = new TokenType("Comment", "c", Token.Value);
            public static readonly TokenType Hashbang = new TokenType("Hashbang", "ch", Value);
            public static readonly TokenType Multiline = new TokenType("Multiline", "cm", Value);
            public static readonly TokenType Preproc = new TokenType("Preproc", "cp", Value);
            public static readonly TokenType PreprocFile = new TokenType("PreprocFile", "cpf", Value);
            public static readonly TokenType Single = new TokenType("Single", "c1", Value);
            public static readonly TokenType Special = new TokenType("Special", "cs", Value);
        }

        public static class Generic {
            public static readonly TokenType Value = new TokenType("Generic", "g", Token.Value);
            public static readonly TokenType Deleted = new TokenType("Deleted", "gd", Value);
            public static readonly TokenType Emph = new TokenType("Emph", "ge", Value);
            public static readonly TokenType Error = new TokenType("Error", "gr", Value);
            public static readonly TokenType Heading = new TokenType("Heading", "gh", Value);
            public static readonly TokenType Inserted = new TokenType("Inserted", "gi", Value);
            public static readonly TokenType Output = new TokenType("Output", "go", Value);
            public static readonly TokenType Prompt = new TokenType("Prompt", "gp", Value);
            public static readonly TokenType Strong = new TokenType("Strong", "gs", Value);
            public static readonly TokenType Subheading = new TokenType("Subheading", "gu", Value);
            public static readonly TokenType Traceback = new TokenType("Traceback", "gt", Value);
        }
    }
}