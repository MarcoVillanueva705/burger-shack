using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerShack.Models;
using BurgerShack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerShack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurgerFriesController : ControllerBase
    {
        private readonly BurgerFriesService _bfs;

        public BurgerFriesController(BurgerFriesService bfs)
        {
            _bfs = bfs;
        }

        [HttpPost]
        public ActionResult<String> Create([FromBody] BurgerFries newData)
        {
            try
            {
                _bfs.Create(newData);
                return Ok("Success");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("/removeFries")]
        public ActionResult<String> Edit([FromBody] BurgerFries bfs)
        {
            try
            {
                return Ok(_bfs.Delete(bfs));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}