using Microsoft.AspNetCore.Mvc;
using MiPrimerWebApiM3.Contexts;
using MiPrimerWebApiM3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase{
        private readonly ApplicationDbContext context;

        public AutoresController(ApplicationDbContext context) {
            this.context=context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get() {
            return context.Autores.ToList();
        }
    }
}