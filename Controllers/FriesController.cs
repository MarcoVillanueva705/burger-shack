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
    public class FriesController : ControllerBase
    {
        private readonly FriesService _bs;

        public FriesController(FriesService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Fries>> Get()
        {
            try
            {
                return Ok(_bs.Get());
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Fries> Get(int id)
        {
            try
            {
                return Ok(_bs.GetById(id));
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Fries> Create([FromBody] Fries newData)
        {
            try
            {
                return Ok(_bs.Create(newData));
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Fries> Edit([FromBody] Fries update, int id)
        {
            try
            {
                update.Id = id;
                return Ok(_bs.Edit(update));
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            try
            {
                return Ok(_bs.Delete(id));
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }
    }
}