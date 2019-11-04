using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using JeopicodusAPI.Models;

namespace JeopicodusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FillInTheBlankontroller : ControllerBase
    {
        private JeopicodusAPIContext _db;

        public FillInTheBlankontroller(JeopicodusAPIContext db)
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
            return _db.FillInTheBlank.FirstOrDefault(entry => entry.FillInTheBlankId == id);
        }
    }
}