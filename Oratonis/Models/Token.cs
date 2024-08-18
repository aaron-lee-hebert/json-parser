namespace Oratonis.Models {
    public class Token(Enums.TokenType type, string value = "") {
        public Enums.TokenType Type { get; } = type;
        public string Value { get; } = value;
    }
}
