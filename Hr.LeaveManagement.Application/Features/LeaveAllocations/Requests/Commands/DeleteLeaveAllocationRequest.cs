using Hr.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveAllocationRequest : IRequest<Unit>
    {
        public LeaveAllocationDto leaveAllocationDto { get; set; }
    }
}
