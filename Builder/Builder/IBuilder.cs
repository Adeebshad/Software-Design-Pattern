using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void Engine();
        void Transmission();
        void Battery();
        void Alternator();
        void Radiator();

        void Engine180();
        void Transmission180();
        void Battery180();
        void Alternator180();
        void Radiator180();

        void Engine360();
        void Transmission360();
        void Battery360();
        void Alternator360();
        void Radiator360();

        void EngineSpecial();
        void TransmissionSpecial();
        void BatterySpecial();
        void AlternatorSpecial();
        void RadiatorSpecial();

    }
}
