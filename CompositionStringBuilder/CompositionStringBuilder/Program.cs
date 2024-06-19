using CompositionStringBuilder.Entites;

namespace CompositionStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Comments c1 = new Comments("Have a nice Trip");
            Comments c2 = new Comments("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);

            p1.AddComments(c1);
            p1.AddComments(c2);

            Comments c3 = new Comments("Good Night");
            Comments c4 = new Comments("Olá mamaco");
            Post p2 = new Post(DateTime.Parse("25/12/2018 13:05:44"),
                "Good Night",
                " Olá Mamaco!",
                5);

            p2.AddComments(c3);
            p2.AddComments(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
