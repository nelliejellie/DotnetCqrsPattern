﻿using Hr.LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestCommandRequest : IRequest<Unit>
    {
        public LeaveRequestDto leaveRequestDto { get; set; }
    }
}
