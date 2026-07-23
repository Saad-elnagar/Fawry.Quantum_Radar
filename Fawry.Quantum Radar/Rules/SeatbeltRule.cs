namespace Fawry.Quantum_Radar.Rules
{
    public class SeatbeltRule : IViolationRule
    {

        private readonly decimal _FineAmount = 100m;
        public ViolationResult? Check(RadarObservation observation)
        {

            if (observation.IsSeatbeltFastened)
                return null;

            var result = new ViolationResult("SeatbeltRule", "Seatbelt not fastened", _FineAmount);

            return result;
        }
    }
}
