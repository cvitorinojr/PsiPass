using System;
using System.Net;
using System.Threading.Tasks;
using Domain.Dtos.User;
using Domain.Entities.User;
using Domain.Interfaces.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        public IUserDerivateService _service { get; set; }

        public UserTypeController(IUserDerivateService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.GetAllType());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
       
    }
}
