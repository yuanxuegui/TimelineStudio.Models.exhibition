using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using TimelineStudio.Models.exhibition.Domain;
using TimelineStudio.Models.exhibition.Util;

namespace TimelineStudio.Models.exhibition.Parser
{
    public class XmlSerializerExhibitionParser : IExhibitionParser
    {
        public Exhibition Parse(string file)
        {
            return (Exhibition)XmlSerializerUtil.LoadXml(typeof(Exhibition), file);
        }
    }
}
