﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimelineStudio.Models.exhibition.Domain
{
    public interface IPropertyFinder
    {
        string GetPropertyValue(string name);
    }
}
