using CoastalVilla_VillaAPI.Data;
using CoastalVilla_VillaAPI.Models;
using CoastalVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CoastalVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }
    }
}
