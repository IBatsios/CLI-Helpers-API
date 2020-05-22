using System.Collections.Generic;
using CLI_Helper.Data;
using CLI_Helper.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLI_Helper.Controllers
{
    [Route("api/helpers")]
    [ApiController]
    public class HelpersController : ControllerBase
    {
        private readonly IHelperRepo _repository;

        public HelpersController(IHelperRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockHelperRepo _repository = new MockHelperRepo();

        //Get api/helpers
        [HttpGet]
        public ActionResult<IEnumerable<HelpersController>> GetAllHelpers()
        {
            var helperItems = _repository.GetAppCommands();

            return Ok(helperItems);
        }

        //GET api/helpers/{id}
        [HttpGet("{id}")]
        public ActionResult<Helper> GetCommandById(int id)
        {
            var helperItem = _repository.GetHelperById(id);

            return Ok(helperItem);
        }
    }
}