using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Task_based_on_all_OOPS
{
    internal interface Playable
    {
        public void Play();
    }

    public class Football : Playable
    { 
        public void Play()
        {
            Console.WriteLine(" Play football");
        }
    }

    public class Cricket : Playable
    { 
        public  void Play()
        {
            Console.WriteLine("Play Cricket");
        }
    }

}
