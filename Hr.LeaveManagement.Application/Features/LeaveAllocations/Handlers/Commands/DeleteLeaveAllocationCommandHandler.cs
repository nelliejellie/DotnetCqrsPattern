using AutoMapper;
using Hr.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using Hr.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hr.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationRequest, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteLeaveAllocationRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.leaveAllocationDto.Id);
            if (leaveAllocation != null)
                await _leaveAllocationRepository.Delete(leaveAllocation);
            return Unit.Value;

        }
    }
}
