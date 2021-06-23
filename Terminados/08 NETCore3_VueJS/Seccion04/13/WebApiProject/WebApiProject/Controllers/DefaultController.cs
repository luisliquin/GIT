using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Controllers {
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase {
        public string Index() {
            return "running ...";
        }
    }
}
