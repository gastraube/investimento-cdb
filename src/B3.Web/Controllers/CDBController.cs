using System.Collections.Generic;
using System.Linq;
using B3.Domain.Interfaces;
using B3.Domain.Models;
using B3.Web.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace B3.Web.Controllers
{
    [Route("api/[controller]")]
    public class CDBController : Controller
    {
        private readonly ICDBService _cDBService;

        public CDBController(ICDBService cDBService)
        {
            _cDBService = cDBService;
        }

        [EnableCors("default")]
        [HttpGet()]
         public  ActionResult<CDB> GetCDB(int initialValue, int months)
         {
            return _cDBService.CalculateCDB(initialValue, months);
         }
    }
}