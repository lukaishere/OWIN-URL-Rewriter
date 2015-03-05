using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace OwinUrlRewriter.Model
{
    public class Rewrite
    {
        [XmlArray("rules")]
        [XmlArrayItem("rule")]
        public RuleCollection Rules { get; set; }
    }

    [CollectionDataContract(ItemName = "rule")]
    public class RuleCollection : List<Rule>
    {
    }
   
    public class Rule
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlElement("match")]
        public RuleMatch Match { get; set; }

        [XmlElement("action")]
        public RuleAction Action { get; set; }

        [XmlAttribute("stopProcessing")]
        public bool StopProcessing { get; set; }
    }
}