﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstMigration.Context
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public ICollection<Issues> Issues { get; set; }
    }
}
