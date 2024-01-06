using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KeyedDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SotrageController : ControllerBase
    {
        private IServiceProvider _serviceProvider;
        public SotrageController( IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;       
        }
        // GET: api/<SotrageController>
        [HttpGet]
        public void Get(string data, string storageType)
        {
            var storageService = _serviceProvider.GetRequiredKeyedService<IStorage>(storageType);
            storageService.StoreData(data);
        }
    }
}
