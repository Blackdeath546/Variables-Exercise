namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string activity = "Bank Heist";

            string currency = "Dollars";
            
            int teamMembers = 4;
            
            char vaultNumber = 'B';
            
            bool isBankOpen = false;

            double goalHeistAmount = 1000000.00;
            
            decimal actualBankHeistAmount = 500.00m;
            
            Console.WriteLine($"Today we are planning for a {activity} with {teamMembers} teammembers" +
                              $" to obtain {goalHeistAmount} {currency}." +
                              $"\nUnfortunately we only obtained {actualBankHeistAmount} {currency} from " +
                              $"{vaultNumber}." +
                              $"\nThe bank's open status is {isBankOpen}. How did we miss that!");
        }
    }
}
