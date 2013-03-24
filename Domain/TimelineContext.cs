using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimelineStudio.Models.exhibition.Domain
{
    public class TimelineContext : ITimelineContext
    {
        private Area area;

        public TimelineContext(Area area)
        {
            this.area = area;
        }

        public Area GetArea()
        {
            return area;
        }

        public Timeline GetTimeline()
        {
            return area.Timeline;
        }
    }
}
