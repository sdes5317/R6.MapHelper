using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VoiceMananger;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundCheck sound=new SoundCheck();
            sound.CanStartMsg = x => Console.WriteLine(x);
            sound.StartListen();
            
            Console.WriteLine(sound.WhatYouSay);

            Console.Read();
        }
    }
}
