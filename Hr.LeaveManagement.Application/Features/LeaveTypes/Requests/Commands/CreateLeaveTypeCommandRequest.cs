﻿using Hr.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommandRequest : IRequest<Guid>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
