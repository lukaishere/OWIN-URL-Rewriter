using System.ComponentModel;
using System.Xml.Serialization;

namespace OwinUrlRewriter.Model
{
    public class RuleAction
    {
        public RuleAction()
        {
            AppendQueryString = true;
        }

        [XmlAttribute("type")]
        public RuleActionType Type { get; set; }

        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("appendQueryString")]
        [DefaultValue(true)]
        public bool AppendQueryString { get; set; }
    }
}
