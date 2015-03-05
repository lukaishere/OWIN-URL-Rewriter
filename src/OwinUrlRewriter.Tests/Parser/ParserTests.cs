using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OwinUrlRewriter.Model;
using OwinUrlRewriter.Tests.Properties;

namespace OwinUrlRewriter.Tests.Parser
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        public void Parses_Simple_Rewrite01()
        {
            var data = new RuleParser.Parser().Parse(Resources.RuleRewriteSimple01);
            Assert.IsNotNull(data);

            var rule = data.Rules[0];

            Assert.IsNotNull(rule);
            Assert.AreEqual("Rule1", rule.Name);
            
            Assert.IsNotNull(rule.Match);
            Assert.AreEqual("capture", rule.Match.Url);
            Assert.IsTrue(rule.Match.IgnoreCase);

            Assert.IsNotNull(rule.Action);
            Assert.AreEqual(RuleActionType.Rewrite, rule.Action.Type);
            Assert.AreEqual("rewriteUrl", rule.Action.Url);
        }

        [TestMethod]
        public void Parses_Simple_Rewrite02()
        {
            var data = new RuleParser.Parser().Parse(Resources.RuleRewriteSimple_IgnoreCase);
            Assert.IsNotNull(data);

            var rule = data.Rules[0];

            Assert.IsNotNull(rule);
            Assert.AreEqual("Rule1", rule.Name);
            Assert.IsTrue(rule.StopProcessing);

            Assert.IsNotNull(rule.Match);
            Assert.AreEqual("capture", rule.Match.Url);
            Assert.IsFalse(rule.Match.IgnoreCase);

            Assert.IsNotNull(rule.Action);
            Assert.AreEqual(RuleActionType.Rewrite, rule.Action.Type);
            Assert.AreEqual("rewriteUrl", rule.Action.Url);
            Assert.IsTrue(rule.Action.AppendQueryString);
        }

        [TestMethod]
        public void Parses_Simple_Rewrite03()
        {
            var data = new RuleParser.Parser().Parse(Resources.RuleRewriteSimple03);
            Assert.IsNotNull(data);

            var rule = data.Rules[0];

            Assert.IsNotNull(rule);
            Assert.IsTrue(rule.StopProcessing);

            Assert.IsNotNull(rule.Match);
            Assert.IsFalse(rule.Match.IgnoreCase);

            Assert.IsNotNull(rule.Action);
            Assert.AreEqual(RuleActionType.Rewrite, rule.Action.Type);
            Assert.AreEqual("rewriteUrl", rule.Action.Url);
            Assert.IsFalse(rule.Action.AppendQueryString);
        }

        [TestMethod]
        public void SerializeTest1()
        {
            var rule = new Rule()
            {
                Name = "Rule1",
                Action = new RuleAction()
                {
                    Type = RuleActionType.Rewrite,
                    Url = "rewrite",
                    AppendQueryString = false
                },
                Match = new RuleMatch
                {
                    Url = "matchUrl"                    
                }
            };

            var data = new Rewrite {Rules = new RuleCollection {rule, rule}};
            Console.WriteLine(Serialize(data));
        }
        private string Serialize<T>(T value)
        {
            var serializer = new XmlSerializer(typeof (T));
            StringWriter stringWriter = new StringWriter();
            XmlWriter writer = XmlWriter.Create(stringWriter);
            serializer.Serialize(writer, value);

            var result = stringWriter.ToString();

            writer.Close();

            return result;
        }
    }
}
