﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IDepredador
    {
        void Cazar(IPresa presa);
        void Comer(IPresa presa);
    }
}
