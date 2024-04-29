using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace HotelWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;
        private readonly IDataAccess<HotelDetail> _iDataAccess;
        public HotelController(IDataAccess<HotelDetail> iDataAccess, ILogger<HotelController> logger)
        {
            _iDataAccess = iDataAccess;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<HotelDetail> Get()
        {
            return _iDataAccess.GetHotels().ToArray();
        }
    }
}
