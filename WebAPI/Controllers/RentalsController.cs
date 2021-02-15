using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalservice;

        public RentalsController(IRentalService rentalservice)
        {
            _rentalservice = rentalservice;
        }
        [HttpGet("getallrental")]
        public IActionResult GetAll()
        {
            var result = _rentalservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrentcardetail")]
        public IActionResult GetRentalCarDetailDto()
        {
            var result = _rentalservice.GetRentalCarDetailDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addrental")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalservice.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleterental")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalservice.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updaterental")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalservice.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
