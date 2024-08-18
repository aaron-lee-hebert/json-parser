using Oratonis;
using Oratonis.Enums;

namespace OratonisTests {
    public class LexarTests {
        private static string ValidFile => Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "Assets\\tests\\step1\\", "valid.json");
        private static string InvalidFile => Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory), "Assets\\tests\\step1\\", "invalid.json");
        
        [Test]
        public void Test1() {
            var lexar = new Lexar(File.ReadAllText(ValidFile));

            var result = lexar.NextToken();

            Assert.That(result.Value, Is.EqualTo(TokenType.CurlyOpen.ToString()));
        }
    }
}