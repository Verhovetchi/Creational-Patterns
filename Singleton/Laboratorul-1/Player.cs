using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorul_1
{
     class Player
     {
          public string name, surname, country;
          public int age, weight, height;
          public Club club = Club.Initialize("Club");


          public Player(){}
          public Player(string name, string surname)
          {
               this.name = name;
               this.surname = surname;
          }

          public Player(string name, string surname, string country, int age, int weight, int height):this(name, surname)
          {
               this.country = country;
               this.age = age;
               this.weight = weight;
               this.height = height;
          }

          public void Show()
          {
               club.Show();
               Console.WriteLine($"Name\t -> \t{name}");
               Console.WriteLine($"Surname\t -> \t{surname}");
               Console.WriteLine($"Country\t -> \t{country}");
               Console.WriteLine($"Age\t -> \t{age}");
               Console.WriteLine($"Weight\t -> \t{weight} cm");
               Console.WriteLine($"Height\t -> \t{height} kg");
          } 
     }
}
