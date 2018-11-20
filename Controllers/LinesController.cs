using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CuantoGastoApp.Model;
using CuantoGastoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CuantoGastoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesController : ControllerBase
    {
        private readonly ILineService _lineService;

        public LinesController(ILineService lineService)
        {
            _lineService = lineService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Line line)
        {
            line.CreateDate = DateTime.UtcNow;
            
            _lineService.SaveLine(line);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
