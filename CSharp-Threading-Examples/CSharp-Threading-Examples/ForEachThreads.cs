using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp_Threading_Examples
{
    public class ForEachThreads
    {
        public async void RunForEachThreads()
        {
            List<string> names = new List<string> { "Fred", "Jeff", "Steve", "Bob" };

            var randomDelayGenerator = new Random();

            Console.WriteLine("Looping with a Foreach loop");
            //Loop to say hello to each name in the list
            foreach(var name in names)
            {
                Thread.Sleep(randomDelayGenerator.Next(100, 5000));

                Console.WriteLine($"Hello {name}");
            }

            Console.WriteLine("\r\n\r\nLooping using Parallel.ForEach");
            //Doing the same but using a thread for each repeat rather then running them in order
            Parallel.ForEach(names, (name) => {
                Thread.Sleep(randomDelayGenerator.Next(100, 5000));

                Console.WriteLine($"Hello {name}");
            });
        }
    }
}
