using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_1
{
     class Program
     {
          static void Main(string[] args)
          {
               Club club1 = Club.Initialize("FC Barcelona");
               Console.WriteLine(club1.GetHashCode());
               club1.Show();

               Club club2 = Club.Initialize("Real Madrid");
               Console.WriteLine(club1.GetHashCode());
               club2.Show();

               Console.WriteLine();
               Console.WriteLine();
               Console.WriteLine();
               Console.WriteLine();

               Player player = new Player("Lionel", "Messi", "Argentina", 32, 168, 67);
               player.Show();


               Console.ReadKey();
          }
     }
}
