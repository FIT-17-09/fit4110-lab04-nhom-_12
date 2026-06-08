using CoreBusiness.API.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CoreBusiness.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateEventRequest request)
    {
        return Ok(new
        {
            message = "Event received",
            data = request
        });
    }
}