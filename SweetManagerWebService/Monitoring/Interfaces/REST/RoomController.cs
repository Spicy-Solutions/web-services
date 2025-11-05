using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using SweetManagerWebService.IAM.Infrastructure.Pipeline.Middleware.Attributes;
using SweetManagerWebService.Monitoring.Domain.Model.Queries;
using SweetManagerWebService.Monitoring.Domain.Services.Room;
using SweetManagerWebService.Monitoring.Interfaces.REST.Resources.Room;
using SweetManagerWebService.Monitoring.Interfaces.REST.Transform.Room;

namespace SweetManagerWebService.Monitoring.Interfaces.REST;

[Route("api/v1/[controller]")]
[ApiController]
[Authorize]
[Produces(MediaTypeNames.Application.Json)]
public class RoomController(IRoomCommandService roomCommandService, IRoomQueryService roomQueryService) : ControllerBase
{
    [HttpPost("set-up")]
    public async Task<IActionResult> BulkRoomsByTypeRoom(BulkRoomsResource resource)
    {
        try
        {
            var bulkRoomsCommand = BulkRoomsCommandFromResourceAssembler.ToCommandFromResource(resource);

            var result = await roomCommandService.Handle(bulkRoomsCommand);

            if (result)
                return Ok();
            else
                return StatusCode(StatusCodes.Status500InternalServerError);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("create-room")]
    public async Task<IActionResult> CreateRoom([FromBody] CreateRoomResource resource)
    {
        try
        {
            var command = CreateRoomCommandFromResourceAssembler.ToCommandFromResource(resource);
            var result = await roomCommandService.Handle(command);

            return Ok("Room created successfully.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"[CreateRoom] Argument error: {ex.Message}");
            return BadRequest(new { error = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new
            {
                error = ex.Message,
                stack = ex.StackTrace
            });
        }

    }

    [HttpPut("update-room-state")]
    public async Task<IActionResult> updateRoomState([FromBody] UpdateRoomStateResource resource)
    {
        var result = await roomCommandService.Handle(
            UpdateRoomStateCommandFromResource.ToCommandFromResource(resource));
        if (result is false)
        {
            return BadRequest();
        }

        return Ok(result); 
    }
    
    [HttpGet("get-room-by-id")]
    public async Task <IActionResult> RoomById([FromQuery] int id)
    {
        var room = await roomQueryService.Handle(new GetRoomsByIdQuery(id));
        if (room is null)
            return BadRequest();

        var roomResource = RoomResourceFromEntityAssembler
            .ToResourceFromEntity(room);
        return Ok(roomResource);
    }
    
    [HttpGet("get-room-by-state")]
    public async Task <IActionResult> RoomByState([FromQuery] string state)
    {
        var rooms = await roomQueryService.Handle(new GetRoomsByStateQuery(state));
        if (state is null)
            return BadRequest();

        var roomResource = rooms.Select(RoomResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(roomResource);
    }
    
    [HttpGet("get-all-rooms")]
    public async Task <IActionResult> AllRooms([FromQuery] int hotelId)
    {
        var rooms = await roomQueryService.Handle(new GetAllRoomsQuery(hotelId));

        var roomResource = rooms.Select(RoomResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(roomResource); 
    }
    
   [HttpGet("get-room-by-type-room")]
    public async Task <IActionResult> RoomByTypeRoomId([FromQuery] int typeRoomId)
    {
        var rooms = await roomQueryService.Handle(new GetRoomsByTypeRoomIdQuery(typeRoomId));

        var roomResource = rooms.Select(RoomResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(roomResource); 
    }
}