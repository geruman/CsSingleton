using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSingleton singleton = GameSingleton.GetInstance();
            singleton.Lives = 4;
            singleton.Score = 356;
            singleton = null;
            singleton = GameSingleton.GetInstance();
            Console.WriteLine("Score: " + singleton.Score);
            Console.WriteLine("Lives: " + singleton.Lives);
            Console.ReadKey();
        }
    }
}
