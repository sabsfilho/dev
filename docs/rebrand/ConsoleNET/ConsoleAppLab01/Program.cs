internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("ConsoleAppLab01 Start");
        await AsyncBreakfast.BreakfastApp.Make();
    }
}