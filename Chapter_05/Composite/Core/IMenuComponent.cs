﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Xml;


namespace Composite.Core
{
    public interface IMenuComponent
    {
        string Text { get; set; }
        string NavigateUrl { get; set; }
        List<IMenuComponent> Children { get; set; }
    }
}
