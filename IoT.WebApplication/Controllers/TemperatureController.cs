using IoT.GrainInterfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace IoT.WebApplication.Controllers
{
    public class TemperatureController : ApiController
    {
        public Task<double> Get(int id)
        {
            var grain = DeviceGrainFactory.GetGrain(id);
            return grain.GetTemperature();
        }

        public Task Post(int id, [FromBody] double value)
        {
            var grain = DeviceGrainFactory.GetGrain(id);
            return grain.SetTemperature(value);
        }

    }
}

