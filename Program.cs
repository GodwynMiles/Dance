namespace Dance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancePoints dancer1 = new DancePoints(name1, points1);
            DancePoints dancer2 = new DancePoints(name2, points2);

            DancePoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }
}
