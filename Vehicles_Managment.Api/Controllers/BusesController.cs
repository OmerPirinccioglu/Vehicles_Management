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
    public class BusesController : ControllerBase
    {
        private readonly IVehicleService<Bus> _vehicleService;
        public BusesController(IVehicleService<Bus> vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public ActionResult<IEnumerable<Bus>> Get()
        {
            
            return _vehicleService.GetLists();
        }
        [HttpGet("{color}")]
        public ActionResult<IEnumerable<Bus>> Get(string color)
        {

            return _vehicleService.GetSelectedColor(color);
        }
    }
}
