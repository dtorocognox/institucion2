﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion2.Model
{
    class Dummy
    {
        public string DummyId { get {
                return Guid.NewGuid().ToString();
            } }
    }
}
