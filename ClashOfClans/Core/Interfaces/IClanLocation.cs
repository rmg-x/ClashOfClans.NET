﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClanLocation
    {
        int Id { get; }

        string Name { get; }
        
        bool IsCountry { get; }
    }
}