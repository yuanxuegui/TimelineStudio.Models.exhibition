﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TimelineStudio.Models.exhibition.Domain
{
    [XmlRoot(ElementName = "exhibition", Namespace = "http://www.sec.ac.cn/exhibition-1.2", IsNullable = false)]
    public class Exhibition : IItemFinder<Area, string>, IPropertyFinder
    {
        private string descriptionField;

        [XmlElement("description")]
        public string Description
        {
            get { return descriptionField; }
            set { descriptionField = value; }
        }
        private ObservableCollection<Property> propertyItemsField;

        [XmlElement("property")]
        public ObservableCollection<Property> PropertyItems
        {
            get { return propertyItemsField; }
            set { propertyItemsField = value; }
        }
        private ObservableCollection<Area> areaItemsField;

        [XmlElement("area")]
        public ObservableCollection<Area> AreaItems
        {
            get { return areaItemsField; }
            set { areaItemsField = value; }
        }

        public Area GetItemByKey(string key)
        {
            foreach (Area area in areaItemsField)
            {
                if (area.Equals(key))
                    return area;
            }
            return null;
        }

        public string GetPropertyValue(string name)
        {
            foreach (Property property in propertyItemsField)
            {
                if (name.Equals(property.Name))
                {
                    return property.Value;
                }
            }
            return null;
        }
    }
}
