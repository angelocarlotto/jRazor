﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jRazor.Infraestrutura
{

    public interface IJqueryBase
    {
        IJQuery Jquery { get; }
    }
}