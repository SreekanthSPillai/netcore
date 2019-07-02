﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sample.Data
{

    public class EmployeeModel: BaseEntity
    {
        
        public string Name
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public decimal Salary
        {
            get;
            set;
        }
    }
}
