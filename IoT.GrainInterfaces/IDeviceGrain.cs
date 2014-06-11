using System.Threading.Tasks;

namespace IoT.GrainInterfaces
{
    public interface IDeviceGrain : Orleans.IGrain
    {
        Task SetTemperature(double value);

        Task<double> GetTemperature();
    }
}

