#pragma warning disable 1591
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LINQtoTMX.Serializable
{
    [Serializable]
    public class TranslationUnitVariant
    {
        //changed from "xml:lang" to "lang" was null before when parsed
        [XmlAttribute("lang")]
        public string Language { get; set; }
        
        [XmlAttribute("changeid")]
        public string ChangeId { get; set; }

        [XmlAttribute("changedate")]
        public string ChangeDate { get; set; }

        [XmlAttribute("creationid")]
        public string CreationId { get; set; }

        [XmlAttribute("creationdate")]
        public string CreationDate { get; set; }

        [XmlElement("seg")]
        public string Segment { get; set; }
    }
}
#pragma warning restore 1591