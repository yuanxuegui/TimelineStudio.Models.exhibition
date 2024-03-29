﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TimelineStudio.Models.exhibition.Domain
{
    public class TimePoint
    {
        private int tickField;

        [XmlAttribute("tick")]
        public int Tick
        {
            get { return tickField; }
            set { tickField = value; }
        }
        private ObservableCollection<Command> commandItemsField;

        [XmlElement("command")]
        public ObservableCollection<Command> CommandItems
        {
            get { return commandItemsField; }
            set { commandItemsField = value; }
        }
    }
}
