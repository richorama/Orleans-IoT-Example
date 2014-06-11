using IoT.GrainInterfaces;
using Orleans;
using System;
using System.Threading.Tasks;

namespace IoT.GrainImplementation
{
    public class DeviceGrain : Orleans.GrainBase, IDeviceGrain
    {
        double temp;
        const double MAX_TEMP = 100;

        public Task SetTemperature(double value)
        {
            var id = this.GetPrimaryKeyLong();

            if (value >= MAX_TEMP && temp < MAX_TEMP)
                Console.WriteLine("Temperature threshold exceeded for device {0}", id);

            if (value < MAX_TEMP && temp >= MAX_TEMP)
                Console.WriteLine("Temperature back to normal for device {0}", id);

            this.temp = value;
            return TaskDone.Done;
        }

        public Task<double> GetTemperature()
        {
            return Task.FromResult<double>(this.temp);
        }
    }
}

