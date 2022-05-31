using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.Business.Abstract;
using Vehicles.Business.Concrete;
using Vehicles.Entities;

namespace Vehicles_Managment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        public ActionResult<IEnumerable<Car>> Get()
        {

            return _carService.GetLists();
        }
        [HttpGet("{color}")]
        public ActionResult<IEnumerable<Car>> Get(string color)
        {
           
            return _carService.GetSelectedColor(color);
        }
        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car car)
        {
            
            return _carService.HeadLight(car);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _carService.Delete(id);
           return Ok();
        }
    }
}
