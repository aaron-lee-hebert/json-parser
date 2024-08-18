using Oratonis.Enums;
using Oratonis.Models;
using System.Text.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace Oratonis {
    public partial class Lexar(string input) {
        private readonly string input = input;
        private int position;
        private int braceDepth;
        private int bracketDepth;

        public List<Token> GetTokens() {
            List<Token> tokens = [];

            if (position >= input.Length) return tokens;

            while (position < input.Length) { 
                var currentValue = input[position];

                string


            }
        }
    }
}
