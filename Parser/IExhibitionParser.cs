using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TimelineStudio.Models.exhibition.Domain;

namespace TimelineStudio.Models.exhibition.Parser
{
    public interface IExhibitionParser
    {
        Exhibition Parse(string file);
    }
}
