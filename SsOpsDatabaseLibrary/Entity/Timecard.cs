﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SsOpsDatabaseLibrary.Entity
{
    public class Timecard
    {
        public Timecard() {}

        public string Year { get; set; }
        public string WeekNumber { get; set; }
        public Employee EmployeeId { get; set; }
        public DataTable DetailTable { get; set; }
       
    }
}
