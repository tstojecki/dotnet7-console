public class Program
{

    public static async Task Main()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\data");
        foreach (var file in Directory.EnumerateFiles(path))
        {
            Console.WriteLine(file);
            Console.WriteLine(new FileInfo(file).FullName);
        }
    }
}