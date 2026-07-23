

namespace Fawry.Quantum_Radar.Models
{
    public record ViolationResult(
        string RuleName,
        string Description,
        decimal FineAmount
    );
}
