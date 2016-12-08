using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Employee2
    {
        public int ID;
        public string firstName;
        public string lastName;
        public int salary;
        public string[] firstNames = { "dudu", "gal", "guy", "ben", "miguel", "shir", "matan", "maor", "obidio", "vova", "maor", "ran", "barnyard", "bugs", "lola", "beaky", "calude", "clyde", "conrad", "cool", "elmer", "speedy", "goofy", "hector", "marvin", "penelope", "spike", "porky","jason", "kobe", "kevin", "tim", "shaq", "rasheed", "john", "karl", "allen", "eddie", "vince", "grant", "reggie", "allan" };
        public string[] lastNames = { "kidd", "garnett", "duncan", "oneal", "wallace", "michal jordan", "stockton", "malone", "iverson", "jones", "carter", "dawg", "bunny", "cat", "duck", "gonzales", "bulldog", "the martian", "pussycat", "taz devil", "gadir", "nawakama", "barda", "sahar" };

        private static Random random = new Random();

        public Employee2()
        {
            ID = random.Next(111111111, 999999999);
            firstName = firstNames[random.Next(0, firstNames.Length)];
            lastName = lastNames[random.Next(0, lastNames.Length)];
            salary = random.Next(0, 1000000);
        }
    }
}
