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
      public static readonly TokenType Constant = new TokenType("Constant", "kc", Token.Keyword.Value);
      public static readonly TokenType Declaration = new TokenType("Declaration", "kd", Token.Keyword.Value);
      public static readonly TokenType Namespace = new TokenType("Namespace", "kn", Token.Keyword.Value);
      public static readonly TokenType Psuedo = new TokenType("Psuedo", "kp", Token.Keyword.Value);
      public static readonly TokenType Reserved = new TokenType("Reserved", "kr", Token.Keyword.Value);
      public static readonly TokenType Type = new TokenType("Type", "kt", Token.Keyword.Value);
    }

    public static class Name {
      public static readonly TokenType Value = new TokenType("Name", "n", Token.Value);
      public static readonly TokenType Attribute = new TokenType("Attribute", "na", Token.Name.Value);
      public static class Builtin {
        public static readonly TokenType Value = new TokenType("Builtin", "nb", Token.Name.Value);
        public static readonly TokenType Psuedo = new TokenType("Psuedo", "bp", Token.Name.Builtin.Value);
      }
      public static readonly TokenType Class = new TokenType("Class", "nc", Token.Name.Value);
      public static readonly TokenType Constant = new TokenType("Constant", "no", Token.Name.Value);
      public static readonly TokenType Decorator = new TokenType("Decorator", "nd", Token.Name.Value);
      public static readonly TokenType Entity = new TokenType("Entity", "ni", Token.Name.Value);
      public static readonly TokenType Exception = new TokenType("Exception", "ne", Token.Name.Value);
      public static class Function {
        public static readonly TokenType Value = new TokenType("Function", "nf", Token.Name.Value);
        public static readonly TokenType Magic = new TokenType("Magic", "fm", Token.Name.Function.Value);
      }
      public static readonly TokenType Property = new TokenType("Property", "py", Token.Name.Value);
      public static readonly TokenType Label = new TokenType("Label", "nl", Token.Name.Value);
      public static readonly TokenType Namespace = new TokenType("Namespace", "nn", Token.Name.Value);
      public static readonly TokenType Other = new TokenType("Other", "nx", Token.Name.Value);
      public static readonly TokenType Tag = new TokenType("Tag", "nt", Token.Name.Value);
      public static class Variable {
        public static readonly TokenType Value = new TokenType("Variable", "nv", Token.Name.Value);
        public static readonly TokenType Class = new TokenType("Class", "vc", Token.Name.Variable.Value);
        public static readonly TokenType Global = new TokenType("Global", "vg", Token.Name.Variable.Value);
        public static readonly TokenType Instance = new TokenType("Instance", "vi", Token.Name.Variable.Value);
        public static readonly TokenType Magic = new TokenType("Magic", "vm", Token.Name.Variable.Value);
      }
    }

    public static class Literal {
      public static readonly TokenType Value = new TokenType("Literal", "l", Token.Value);
      public static readonly TokenType Date = new TokenType("Date", "ld", Token.Literal.Value);
    }

    public static class String {
      public static readonly TokenType Value = new TokenType("String", "s", Token.Value);
      public static readonly TokenType Affix = new TokenType("Affix", "sa", Token.String.Value);
      public static readonly TokenType Backtick = new TokenType("Backtick", "sb", Token.String.Value);
      public static readonly TokenType Char = new TokenType("Char", "sc", Token.String.Value);
      public static readonly TokenType Delimiter = new TokenType("Delimiter", "dl", Token.String.Value);
      public static readonly TokenType Doc = new TokenType("Doc", "sd", Token.String.Value);
      public static readonly TokenType Double = new TokenType("Double", "s2", Token.String.Value);
      public static readonly TokenType Escape = new TokenType("Escape", "se", Token.String.Value);
      public static readonly TokenType Heredoc = new TokenType("Heredoc", "sh", Token.String.Value);
      public static readonly TokenType Interpol = new TokenType("Interpol", "si", Token.String.Value);
      public static readonly TokenType Other = new TokenType("Other", "sx", Token.String.Value);
      public static readonly TokenType Regex = new TokenType("Regex", "sr", Token.String.Value);
      public static readonly TokenType Single = new TokenType("Single", "s1", Token.String.Value);
      public static readonly TokenType Symbol = new TokenType("Symbol", "ss", Token.String.Value);
    }

    public static class Number {
      public static readonly TokenType Value = new TokenType("Number", "m", Token.Value);
      public static readonly TokenType Bin = new TokenType("Bin", "mb", Token.Number.Value);
      public static readonly TokenType Float = new TokenType("Float", "mf", Token.Number.Value);
      public static readonly TokenType Hex = new TokenType("Hex", "mh", Token.Number.Value);
      public static class Integer {
        public static readonly TokenType Value = new TokenType("Integer", "mi", Token.Number.Value);
        public static readonly TokenType Long = new TokenType("Long", "il", Token.Number.Integer.Value);
      }
      public static readonly TokenType Oct = new TokenType("Oct", "mo", Token.Number.Value);
    }

    public static class Operator {
      public static readonly TokenType Value = new TokenType("Operator", "o", Token.Value);
      public static readonly TokenType Word = new TokenType("Word", "ow", Token.Operator.Value);
    }

    public static class Comment {
      public static readonly TokenType Value = new TokenType("Comment", "c", Token.Value);
      public static readonly TokenType Hashbang = new TokenType("Hashbang", "ch", Token.Comment.Value);
      public static readonly TokenType Multiline = new TokenType("Multiline", "cm", Token.Comment.Value);
      public static readonly TokenType Preproc = new TokenType("Preproc", "cp", Token.Comment.Value);
      public static readonly TokenType PreprocFile = new TokenType("PreprocFile", "cpf", Token.Comment.Value);
      public static readonly TokenType Single = new TokenType("Single", "c1", Token.Comment.Value);
      public static readonly TokenType Special = new TokenType("Special", "cs", Token.Comment.Value);
    }

    public static class Generic {
      public static readonly TokenType Value = new TokenType("Generic", "g", Token.Value);
      public static readonly TokenType Deleted = new TokenType("Deleted", "gd", Token.Generic.Value);
      public static readonly TokenType Emph = new TokenType("Emph", "ge", Token.Generic.Value);
      public static readonly TokenType Error = new TokenType("Error", "gr", Token.Generic.Value);
      public static readonly TokenType Heading = new TokenType("Heading", "gh", Token.Generic.Value);
      public static readonly TokenType Inserted = new TokenType("Inserted", "gi", Token.Generic.Value);
      public static readonly TokenType Output = new TokenType("Output", "go", Token.Generic.Value);
      public static readonly TokenType Prompt = new TokenType("Prompt", "gp", Token.Generic.Value);
      public static readonly TokenType Strong = new TokenType("Strong", "gs", Token.Generic.Value);
      public static readonly TokenType Subheading = new TokenType("Subheading", "gu", Token.Generic.Value);
      public static readonly TokenType Traceback = new TokenType("Traceback", "gt");
    }
  }
}
