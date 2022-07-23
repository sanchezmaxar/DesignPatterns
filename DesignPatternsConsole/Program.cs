using AbstractFactory;
using Common;
using FactoryMethodLib;
using System.Linq;

public class Program
{

    const char ExitChar = 'e';
    public static async Task Main()
    {
        var command = 'a';
        while (command != ExitChar)
        {

            Console.WriteLine("Please select an example: ");
            Console.WriteLine("1.- Factory Method (Pizza Store)");
            Console.WriteLine("2.- Abstract Factory (Food Store)");
            Console.WriteLine("e.- Exit");
            Console.WriteLine("Select: ");
            command = Console.ReadKey().KeyChar;
            Console.WriteLine("\n"+string.Join("",Enumerable.Range(0,10).Select(x=>"-"))+"\n");
            var service = ParseChar(command);

            if (service == null)
            {
                break;
            }
            await service.RunService();

        }

    }


    public static IDesignPattern? ParseChar(char c)
    {
        return c switch
        {
            '1' => new PizzaStore(),
            '2' => new FoodCooker(),
            _ => null
        };
    }


}
