using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Helpers
{
    public static class InputHelper
    {
        public static int ReadKey(int limit)
        {
            ConsoleKeyInfo UserInput = Console.ReadKey();

            if (char.IsDigit(UserInput.KeyChar))
            {
                var value = int.Parse(UserInput.KeyChar.ToString());

                if(value< 1 || value > limit)
                {
                    Console.WriteLine("INVALID DIGIT");
                    return ReadKey(limit);
                }

                return value;
            }
            else
            {
                Console.WriteLine("INVALID DIGIT");
                return ReadKey(limit);
            }
        }
    }
}
