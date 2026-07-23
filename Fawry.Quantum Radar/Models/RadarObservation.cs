

namespace Fawry.Quantum_Radar.Models
{   
        public record RadarObservation(
        string PlateNumber,
        DateTime Date,
        VehicleType VehicleType,
        double Speed,
        bool IsSeatbeltFastened
    );
    
}
