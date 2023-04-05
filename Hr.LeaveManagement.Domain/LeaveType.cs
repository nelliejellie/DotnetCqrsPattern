﻿using Hr.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string? Name { get; set; }
        public int? DefaultType { get; set; }
    }
}
