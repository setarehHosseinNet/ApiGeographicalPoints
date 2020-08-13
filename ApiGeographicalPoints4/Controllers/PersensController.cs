
using System.Collections.Generic;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Accounting.DataLayer2.Models;

using Accounting.Business2;

namespace ApiGeographicalPoints4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersensController : ControllerBase
    {
        private  Account pers=new Account();

        //public PersensController(Account account)
        //{
        //    pers = account; 
        //}

        // GET: api/Persens
        [HttpGet]
        public async Task<IEnumerable<Persen>> GetPersen()
        {
          
            return await pers.GetPersen();
        }

        // GET: api/Persens/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersen([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var persen = await pers.GetPersen(id);

            if (persen == null)
            {
                return NotFound();
            }

            return Ok(persen);
        }

        // PUT: api/Persens/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersen([FromRoute] int id, [FromBody] Persen persen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != persen.ID)
            {
                return BadRequest();
            }

            var res = await pers.PutPersen(id, persen);

            if(!res)
           
            {
              
                    return NotFound();
              
            }

            return NoContent();
        }

        // POST: api/Persens
        [HttpPost]
        public async Task<IActionResult> PostPersen([FromBody] Persen persen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           var res =await pers.PostPersen(persen);
            if (res==null)
            {
                return BadRequest(ModelState);
            }
            return  CreatedAtAction("GetPersen", new { id = persen.ID }, persen);
        }

        // DELETE: api/Persens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersen([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var persen = await pers.GetPersen(id);
            if (persen == null)
            {
                return NotFound();
            }

            var del = pers.DeletePersen(id);
            if (await del==null)
            {
                return NotFound();
            }
          

            return Ok(del);
        }

        private async Task<bool> PersenExists(int id)
        {
            return await pers.PersenExistsID(id);
        }


        [HttpPost]
        public async Task<IActionResult> PostPersenLogin([FromBody] Persen persen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var res = await pers.Login(persen);
            if (res == "null")
            {
                return BadRequest(ModelState);
            }
            return CreatedAtAction("GetPersen", new { id = persen.Name }, persen);
        }
    }

}