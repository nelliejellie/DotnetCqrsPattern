﻿using Hr.LeaveManagement.Application.DTOs.Commons;
using Hr.LeaveManagement.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto : BaseDto
    {
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public Guid LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
    }
}
