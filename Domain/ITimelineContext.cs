using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimelineStudio.Models.exhibition.Domain
{
    public interface ITimelineContext
    {
        Area GetArea();
        Timeline GetTimeline();
    }
}
