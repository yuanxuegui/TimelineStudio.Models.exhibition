using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimelineStudio.Models.exhibition.Sender;

namespace TimelineStudio.Models.exhibition.Domain
{
    public interface ICommandContext
    {
        string BuildCommand(Command command);
    }
}
