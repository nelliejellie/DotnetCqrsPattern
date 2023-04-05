﻿using Hr.LeaveManagement.Application.DTOs.LeaveAllocation;
using Hr.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<Guid>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
