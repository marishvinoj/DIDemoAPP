﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public interface ICountryManager
    {
        IList<string> GetCountryList();
    }
}
