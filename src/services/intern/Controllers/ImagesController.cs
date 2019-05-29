using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Intern.Models;
using Intern.Domains;

namespace Intern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IDatabaseService m_databaseService;
        public ImagesController(IDatabaseService databaseService)
        {
            m_databaseService = databaseService;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var images = await m_databaseService.GetAllImages();
            return Ok(images);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<int> Get(int id)
        {
            return id;
        }

        // POST api/values
        [HttpPost]
        public Image Post([FromBody] Image image)
        {
            return image;
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
