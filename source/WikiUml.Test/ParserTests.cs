using Antlr.Runtime;
using NUnit.Framework;

namespace WikiUml.Test
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void parsing_empty_class_will_return_empty_class()
        {
            var diagram = ParseWikiUml("[]");
            Assert.AreEqual(1, diagram.umlClasses.Count);
            Assert.IsNullOrEmpty(diagram.umlClasses[0].Name);
        }

        [Test]
        public void parsing_class_with_name_will_return_class_with_name()
        {
            var diagram = ParseWikiUml("[MyClass]");
            Assert.AreEqual("MyClass", diagram.umlClasses[0].Name);
        }

        [Test]
        public void parsing_class_with_member_will_return_class_with_member()
        {
            var diagram = ParseWikiUml("[|foo]");
            Assert.AreEqual("foo", diagram.umlClasses[0].Members[0].Name);
        }

        [Test]
        public void parsing_class_with_method_will_return_class_with_method()
        {
            var diagram = ParseWikiUml("[||baz()]");
            Assert.AreEqual("baz", diagram.umlClasses[0].Methods[0].Name);
        }

        private Diagram ParseWikiUml(string wikiUml)
        {
            var input = new ANTLRStringStream(wikiUml);
            var lexer = new WikiUmlLexer(input);
            var tokens = new CommonTokenStream(lexer);
            var parser = new WikiUmlParser(tokens);
            return parser.diagram();
        }
    }
}
