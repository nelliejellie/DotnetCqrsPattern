using MediatR;
using Hr.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hr.LeaveManagement.Application.Persistence.Contracts;
using Hr.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;

namespace Hr.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeRequest, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(DeleteLeaveTypeRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.leaveTypeDto.Id);
            if(leaveType != null)
                await _leaveTypeRepository.Delete(leaveType);

            return Unit.Value;
        }
    }
}
