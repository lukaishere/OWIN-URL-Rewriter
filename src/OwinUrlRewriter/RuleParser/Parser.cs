using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using OwinUrlRewriter.Model;

namespace OwinUrlRewriter.RuleParser
{
    class Parser
    {
        public Rewrite Parse(string xml)
        {
            var serializer = new XmlSerializer(typeof(Rewrite));
            var sr = new StringReader(xml);
            var xmlReaderSettings = new XmlReaderSettings
            {
                IgnoreWhitespace = true
            };
            var reader = XmlReader.Create(sr, xmlReaderSettings);

            object o = serializer.Deserialize(reader);
            reader.Close();

            return o as Rewrite;
        }
    }
}
