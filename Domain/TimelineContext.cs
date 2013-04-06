using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace TimelineStudio.Models.exhibition.Domain
{
    public class TimelineContext : ITimelineContext
    {
        private IList<Property> properties;
        
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

        public void MergeProperties(ObservableCollection<Property> properties)
        {
            if (this.properties == null)
                this.properties = new List<Property>();
            foreach (Property prop in properties)
                this.properties.Add(prop);
        }

        public string GetPropertyValue(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;
            foreach (Property prop in properties)
            {
                if (prop.Name.Equals(name))
                    return prop.Value;
            }
            return null;
        }
    }
}
