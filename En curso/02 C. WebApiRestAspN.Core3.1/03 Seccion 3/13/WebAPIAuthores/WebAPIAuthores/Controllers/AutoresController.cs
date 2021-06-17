using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPIAuthores.Entidades;
using System.Data.Entity.DbContext;

namespace WebAPIAuthores.Controllers {
    [ApiController]
    [Route("api/autores")]
    public class AutoresController : ControllerBase{

        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDBContext context) {
            this.context=context;
        }

        [HttpGet]
        public ActionResult<List<Autor>> Get() {
            return new List<Autor>() {
                new Autor() { Id=1, Nombre="Felipe" },
                new Autor() { Id=2, Nombre="Claudia" }
            };
        }

        [HttpPost]
        public async Task<ActionResult>Post(Autor autor) {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}