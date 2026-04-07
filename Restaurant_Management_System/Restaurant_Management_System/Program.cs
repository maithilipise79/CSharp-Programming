 
using Restaurant_Management_System.Workflow;

public class Program
{
    public static async Task Main(string[] args)
    {
        await EntityHandler.EntityHandlerProcess();
    }
}