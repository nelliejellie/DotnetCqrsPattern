using Hr.LeaveManagement.Application.Features.LeaveRequests.Requests.Commands;
using Hr.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommandRequest, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public DeleteLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;
        }
        public async Task<Unit> Handle(DeleteLeaveRequestCommandRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.leaveRequestDto.Id);
            if (leaveRequest != null)
                await _leaveRequestRepository.Delete(leaveRequest);
            return Unit.Value;
        }
    }
}
