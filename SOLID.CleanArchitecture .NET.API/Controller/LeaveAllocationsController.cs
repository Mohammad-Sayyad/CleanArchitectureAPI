using MediatR;
using Microsoft.AspNetCore.Mvc;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.RemoveLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.UpdateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SOLID.CleanArchitecture_.NET.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveAllocationsController : ControllerBase
    {

        private readonly IMediator _mediator;
        public LeaveAllocationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
       
        public async Task<ActionResult<List<LeaveAllocationDto>>> Get(bool IsUserLogged = false)
        {
            var leaveAllocations = await _mediator.Send(new GetLeaveAllocationListQuery());
            return Ok(leaveAllocations);
        }

        // GET api/<LeaveAllocationsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveAllocationDetailsDto>> Get(int id)
        {
            var leaveAllocation = await _mediator.Send(new GetLeaveAllocationDetailQuery{Id = id });

            return Ok(leaveAllocation);
        }

        // POST api/<LeaveAllocationsController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post (CreateLeaveAllocationCommand createLeaveAllocation)
        {
            var respone = await _mediator.Send(createLeaveAllocation);
            return CreatedAtAction(nameof(Get), new { id = respone });
        }

        // PUT api/<LeaveAllocationsController>/5
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateLeaveAllocationCommand leaveAllocation)
        {
            await _mediator.Send(leaveAllocation);
            return NoContent();
        }

        // DELETE api/<LeaveAllocationsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteLeaveAllocationCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
