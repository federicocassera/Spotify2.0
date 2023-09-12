using Spotify.Exercise;
using System;

namespace Spotify.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DataStore.GetInstance();
            UserInterface.SourceSelectionInterface();

            UserInterface.Router("h");
            Console.ReadLine();
        }
    }
    
}
