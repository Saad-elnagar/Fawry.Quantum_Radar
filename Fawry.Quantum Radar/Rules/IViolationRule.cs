namespace Fawry.Quantum_Radar.Rules
{

    // each rule inspects an observation and returns a violation if one occurred or null otherwise.
    public interface IViolationRule
    {
        ViolationResult? Check(RadarObservation observation);
    }
}   
