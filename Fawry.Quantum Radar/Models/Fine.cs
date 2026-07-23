
namespace Fawry.Quantum_Radar.Models
{
    public class Fine
    {
        public string PlateNumber { get;  }
        public DateTime Date { get;  }
        public List<ViolationResult> Violations { get;}
        public decimal TotalAmount => Violations.Sum(v => v.FineAmount);

        public Fine(string plateNumber, DateTime date, List<ViolationResult> violations)
        {
            PlateNumber = plateNumber;
            Date = date;
            Violations = violations;
        }

    }
}
