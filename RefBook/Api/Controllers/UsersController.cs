using Microsoft.AspNetCore.Mvc;
using RefBook.Application.Interfaces;
using RefBook.Application.Services;
using RefBook.Domain.Entities;
using RefBook.Application.DTOs;
using Microsoft.AspNetCore.Components.Forms;

namespace RefBook.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService) { _usersService = usersService; }

        [HttpGet]

        public async Task<IActionResult> Get() {
            var users = await _usersService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetById(int id) {

            var user = await _usersService.GetById(id);
            return Ok(user);
        }

        [HttpPost]

        public async Task<IActionResult> create([FromForm] RequestCreateUser user) {

            try
            {
                var users = new Users
                {
                    name = user.name,
                    email = user.email,
                    createAt = DateTime.Now,
                    password_hash = user.password_hash,
                };

                await _usersService.Add(users);

                return Ok(new { message = "Usuario creado con exito" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error{ex.Message}");
            }
            
        }

        [HttpPost("{id:int}")]

        public async Task<IActionResult> Update(int id, [FromBody] Users users) {

            return Ok(_usersService.Update(id, users));
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id) {

            await _usersService.Delete(id);

            return Ok(new {message = "Usuario eliminado con exito"});
        }

    }
}
