using Antlr.Runtime;
using NUnit.Framework;

namespace WikiUml.Test
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void parsing_simple_class_will_return_class()
        {
            var input = new ANTLRStringStream("[MyClass]");
            var lexer = new WikiUmlLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new WikiUmlParser(tokens);
            var x = parser.parse();
            Assert.Fail();
        }
    }
}
