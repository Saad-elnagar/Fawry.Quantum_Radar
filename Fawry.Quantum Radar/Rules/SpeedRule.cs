
namespace Fawry.Quantum_Radar.Rules
{
    public class SpeedRule : IViolationRule
    {
        public ViolationResult? Check(RadarObservation observation)
        {
            double SpeedAllowed  = observation.VehicleType switch
            {
                VehicleType.Truck => 60,
                VehicleType.Private => 80,
                VehicleType.Bus => 70,
                _ => 80
            };
            if (observation.Speed <= SpeedAllowed)
                return null;

            return new ViolationResult(
                RuleName: "SpeedRule",
                Description: $"speed of {observation.Speed} exceeded max allowed {SpeedAllowed}",
                FineAmount: 300  
            );



        }
    }
}
