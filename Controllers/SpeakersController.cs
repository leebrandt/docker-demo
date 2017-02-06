using System.Collections.Generic;
using System.Linq;
using Kcdc.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    public class SpeakersController
    {
        private readonly KcdcContext _context;
        public SpeakersController(KcdcContext context)
        {
            _context = context;
        }
         // GET api/speakers
        [HttpGet]
        public IEnumerable<Speaker> Get()
        {
            return _context.Speakers.ToList();
        }
    }
}