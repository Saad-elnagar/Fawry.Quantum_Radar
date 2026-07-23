



namespace Fawry.Quantum_Radar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<IViolationRule>
            {
                new SpeedRule(),
                new SeatbeltRule()
            };

            var radar = new QuantumRadar(rules);
             
            var vehicle1 = new RadarObservation(
                "ABC1234",
                DateTime.Now,
                VehicleType.Private,
                94,
                false
                );

            var vehicle2 = new RadarObservation("XYZ5678", DateTime.Now, VehicleType.Truck, 50, true);

            var vehicle3 = new RadarObservation("DEF9999", DateTime.Now, VehicleType.Bus, 65, false);

            radar.Observe(vehicle1);
            radar.Observe(vehicle2);
            radar.Observe(vehicle3);

            foreach (var fine in radar.GetAllPossibleFines())
            {
                FineReceiptPrinter.Print(fine);
            }

            foreach (var kvp in radar.GetAllViolatedRules())
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }




        }
    }
}
