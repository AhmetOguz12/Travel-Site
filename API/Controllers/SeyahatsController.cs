using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeyahatsController : ControllerBase
    {
        ISeyahatService _seyahatService;

        public SeyahatsController(ISeyahatService seyahatService)
        {
            _seyahatService = seyahatService;
        }

        [HttpGet("getAll")]
        public ActionResult GetAll()
        {
            var result = _seyahatService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public ActionResult Add(AddSeyahat seyahat)
        {
            var result = _seyahatService.Add(seyahat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            var result = _seyahatService.Delete(new Seyahat
            {
                Id = id
            });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]
        public ActionResult Update(UpdateSeyahat seyahat)
        {
            var result = _seyahatService.Update(seyahat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
