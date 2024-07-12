using GoShop.Domain.Entities;
using GoShop.Domain.Interfaces;
using GoShop.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilePhoneController : ControllerBase
    {
        private readonly IMobilePhoneService _mobilePhoneService;

        public MobilePhoneController(IMobilePhoneService mobilePhoneService)
        {
            _mobilePhoneService = mobilePhoneService;
        }

        // GET: api/MobilePhones
        [HttpGet]
        public async Task<ActionResult<List<MobilePhoneFiltersModel>>> GetAll([FromQuery] MobilePhoneFiltersModel model, CancellationToken cancellationToken)
        {
            var result = await _mobilePhoneService.GetAllAsync(model, cancellationToken);
            return Ok(result);
        }

        // GET: api/MobilePhones/Count
        [HttpGet("count")]
        public async Task<ActionResult<int>> GetCountByFilters([FromQuery] MobilePhoneFiltersModel model, CancellationToken cancellationToken)
        {
            var count = await _mobilePhoneService.GetCountByFiltersAsync(model, cancellationToken);
            return Ok(count);
        }

        [HttpPost]
        public async Task<ActionResult<MobilePhoneEntity>> CreateAsync([FromQuery] MobilePhoneEntity entity, CancellationToken cancellationToken)
        {
            var result = await _mobilePhoneService.CreateAsync(entity, cancellationToken);
            return Ok(result);
        }
    }
}
