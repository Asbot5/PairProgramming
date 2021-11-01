using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PairProgramming.Managers;
using PairProgramming.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PairProgramming.Controllers
{
    [ApiController]
    [Route("Music")]
    public class MusicRecordController
    {
        private readonly MusicRecordManager _manager = new MusicRecordManager();

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<MusicRecord> GetAll()
        {
            return _manager.GetAllRecords();
        }

        [HttpGet]
        [Route("{Title}")]
        public IEnumerable<MusicRecord> GetTitles(string  title)
        {
            return _manager.GetByTitle(title);
        }
    }
}

