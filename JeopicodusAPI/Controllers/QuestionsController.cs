using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JeopicodusAPI.Models;

namespace JeopicodusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FillInTheBlankController : ControllerBase
    {
        private JeopicodusAPIContext _db;

        public FillInTheBlankController(JeopicodusAPIContext db)
        {
            _db = db;
        }

        // GET api/questions
        [HttpGet]
        public ActionResult<IEnumerable<FillInTheBlank>> Get()
        {
            return _db.FillInTheBlank.ToList();
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public ActionResult<FillInTheBlank> Get(int id)
        {
            return _db.FillInTheBlank.FirstOrDefault(entry => entry.Id == id);
        }
    }
}