using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ŞehirsController : ControllerBase
    {

        IŞehirService _şehirService;

        public ŞehirsController(IŞehirService şehirService)
        {
            _şehirService = şehirService;
        }

        [HttpGet("getlAll")]
        public ActionResult GetAll()
        {
            var result = _şehirService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public ActionResult Add(AddŞehir şehir)
        {
            var result = _şehirService.Add(şehir);
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
            var result = _şehirService.Delete(new Şehir
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
        public ActionResult Update(UpdateŞehir şehir)
        {
            var result = _şehirService.Update(şehir);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
