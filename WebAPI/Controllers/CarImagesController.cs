using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] CarImage carImage)
        {
            var result = _carImageService.AddCarImage(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);            
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm] int carImageId)
        {
            var result=_carImageService.DeleteCarImage(carImageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }        
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int carId)
        {
            var result = _carImageService.GetCarImagesByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm]IFormFile file, [FromForm] CarImage carImage)
        {
            var result=_carImageService.UpdateCarImage(file, carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}