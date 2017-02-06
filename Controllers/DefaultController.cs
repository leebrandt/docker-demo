using System.Collections.Generic;
using System.Linq;
using Kcdc.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Kcdc.Api.Controllers
{
    public class DefaultController : Controller
    {
        private readonly KcdcContext _context;
        public DefaultController(KcdcContext context)
        {
            _context = context;
        }
         // GET api
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }
    }
}