using System.ComponentModel;
using System.Xml.Serialization;

namespace OwinUrlRewriter.Model
{
    public class RuleMatch
    {
        public RuleMatch()
        {
            IgnoreCase = true;
        }

        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("ignoreCase")]
        [DefaultValue(true)]
        public bool IgnoreCase { get; set; }
    }
}