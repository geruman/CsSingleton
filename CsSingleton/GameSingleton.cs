using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsSingleton
{
    public class GameSingleton
    {
        private static GameSingleton instance;
        public int Score { get; set; }
        public int Lives { get; set; }
        public static GameSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new GameSingleton();
            }
            return instance;
        }


    }
}
