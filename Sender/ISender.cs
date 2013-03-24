using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimelineStudio.Models.exhibition.Sender
{
    public interface ISender
    {
        bool Send(string message);
    }
}
