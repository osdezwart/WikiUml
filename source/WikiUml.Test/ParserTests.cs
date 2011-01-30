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

        [Test]
        public void parsing_diagram_with_multiple_classes_on_multiple_rows_returns_multiple_classes()
        {
            var diagram = ParseWikiUml("[Foo]\r\n[Bar]");
            Assert.AreEqual(2, diagram.umlClasses.Count);
            Assert.AreEqual("Foo", diagram.umlClasses[0].Name);
            Assert.AreEqual("Bar", diagram.umlClasses[1].Name);
        }

        [Test]
        public void parsing_diagram_with_multiple_classes_on_same_row_returns_multiple_classes()
        {
            var diagram = ParseWikiUml("[Foo][Bar][Qux]");
            Assert.AreEqual(3, diagram.umlClasses.Count);
            Assert.AreEqual("Foo", diagram.umlClasses[0].Name);
            Assert.AreEqual("Bar", diagram.umlClasses[1].Name);
            Assert.AreEqual("Qux", diagram.umlClasses[2].Name);
        }

        [Test]
        public void parsing_diagram_with_multiple_classes_on_same_row_with_spacing_returns_multiple_classes()
        {
            var diagram = ParseWikiUml("    [Foo] [Bar]\r\n");
            Assert.AreEqual(2, diagram.umlClasses.Count);
            Assert.AreEqual("Foo", diagram.umlClasses[0].Name);
            Assert.AreEqual("Bar", diagram.umlClasses[1].Name);
        }

        [Test]
        public void parsing_diagram_with_multiple_classes_sepperated_with_unix_line_endings_returns_multiple_classes()
        {
            var diagram = ParseWikiUml("[Foo]\n[Bar]");
            Assert.AreEqual(2, diagram.umlClasses.Count);
            Assert.AreEqual("Foo", diagram.umlClasses[0].Name);
            Assert.AreEqual("Bar", diagram.umlClasses[1].Name);
        }

        [Test]
        public void parsing_diagram_with_simple_association_between_two_classes_should_return_two_associated_classes()
        {
            var diagram = ParseWikiUml("[Foo]-[Bar]");

            Assert.AreEqual(2, diagram.umlClasses.Count);
            Assert.AreEqual(AssociationType.Simple, diagram.umlClasses[0].Associations[0].Type);
            Assert.AreEqual(AssociationType.Simple, diagram.umlClasses[1].Associations[0].Type);
            Assert.AreEqual(diagram.umlClasses[0], diagram.umlClasses[0].Associations[0].UmlClassA);
            Assert.AreEqual(diagram.umlClasses[1], diagram.umlClasses[1].Associations[0].UmlClassB);
        }

        [Test]
        public void parsing_diagram_with_simple_association_between_two_classes_and_a_simple_association_between_one_of_those_and_a_third_should_return_three_associated_classes()
        {
            var diagram = ParseWikiUml("[Foo]-[Bar]-[Qux]");

            Assert.AreEqual(3, diagram.umlClasses.Count);
            Assert.AreEqual(AssociationType.Simple, diagram.umlClasses[0].Associations[0].Type);
            Assert.AreEqual(AssociationType.Simple, diagram.umlClasses[1].Associations[0].Type);
            Assert.AreEqual(AssociationType.Simple, diagram.umlClasses[1].Associations[1].Type);
            Assert.AreEqual(AssociationType.Simple, diagram.umlClasses[2].Associations[0].Type);
            Assert.AreEqual(diagram.umlClasses[0], diagram.umlClasses[0].Associations[0].UmlClassA);
            Assert.AreEqual(diagram.umlClasses[1], diagram.umlClasses[1].Associations[0].UmlClassB);
            Assert.AreEqual(diagram.umlClasses[1], diagram.umlClasses[1].Associations[1].UmlClassA);
            Assert.AreEqual(diagram.umlClasses[2], diagram.umlClasses[1].Associations[1].UmlClassB);
            Assert.AreEqual(diagram.umlClasses[1], diagram.umlClasses[2].Associations[0].UmlClassA);
            Assert.AreEqual(diagram.umlClasses[2], diagram.umlClasses[2].Associations[0].UmlClassB);
        }

        [Test]
        public void parsing_diagram_with_simple_association_and_multiplicity_between_two_classes_should_return_two_associated_classes()
        {
            Assert.Fail("TO BE IMPLEMENTED");
        }

        [Test]
        public void parsing_diagram_with_simple_association_and_labels_between_two_classes_should_return_two_associated_classes()
        {
            Assert.Fail("TO BE IMPLEMENTED");
        }

        [Test]
        public void parsing_diagram_with_unidirectional_association_between_two_classes_should_return_two_associated_classes()
        {
            Assert.Fail("TO BE IMPLEMENTED");
        }

        [Test]
        public void parsing_diagram_with_bidirectional_association_between_two_classes_should_return_two_associated_classes()
        {
            Assert.Fail("TO BE IMPLEMENTED");
        }

        [Test]
        public void parsing_diagram_with_inheritance_association_between_two_classes_should_return_two_associated_classes()
        {
            Assert.Fail("TO BE IMPLEMENTED");
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
