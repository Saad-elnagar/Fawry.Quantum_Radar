
namespace Fawry.Quantum_Radar.Models
{
    public static class FineReceiptPrinter
    {
        public static void Print(Fine fine)
        {
            Console.WriteLine($"Traffic fine for car {fine.PlateNumber}");
            Console.WriteLine($"Total amount: {fine.TotalAmount} EGP");
            Console.WriteLine("Violations:");
            foreach (var v in fine.Violations)
                Console.WriteLine($"- {v.Description} : {v.FineAmount} EGP");
        }
    }
}
