using Fawry.Quantum_Radar.Models;
using Fawry.Quantum_Radar.Rules;


namespace Fawry.Quantum_Radar.Core
{

    // a rule-based, extensible radar system.
    // Receives an observation from a vehicle, runs it through all registered rules
    // collects any resulting violations into a single Fine, and tracks how many  times each rule has been violated.
    public class QuantumRadar
    {
        private readonly List<IViolationRule> _rules;
        private readonly List<Fine> _fines;
        private readonly Dictionary<string, int> _violationCounts;
        
        public QuantumRadar(List<IViolationRule> rules)
        {
            _rules = rules;
            _fines = new List<Fine>();
            _violationCounts = new Dictionary<string, int>();
        }

        
        public void Observe(RadarObservation observation)
        { 
            var detectedViolations = new List<ViolationResult>();
            foreach (var rule in _rules)
            {
                var violation = rule.Check(observation);

                if (violation != null)
                {
                    detectedViolations.Add(violation);
                    if (_violationCounts.ContainsKey(violation.RuleName))
                        _violationCounts[violation.RuleName]++;
                    else
                        _violationCounts[violation.RuleName] = 1;

                }
            }
            if (detectedViolations.Any())
            {
                var fine = new Fine(observation.PlateNumber, observation.Date, detectedViolations);
                _fines.Add(fine);
            }
        }

        public List<Fine> GetAllPossibleFines()
        {
            return _fines;
        }

        public Dictionary<string, int> GetAllViolatedRules()
        {
            return _violationCounts;
        }
    }
}