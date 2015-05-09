using System;
using System.IO.Ports;
using System.Runtime.InteropServices;
using IrrKlang;

namespace gate
{
    internal class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool Beep(uint dwFreq, uint dwDuration);

        private static void Main(string[] args)
        {
            var comPort = new SerialPort("COM3", 9600);
            if (comPort.IsOpen) comPort.Close();
            try
            {
                comPort.Open();
            }
            catch
            {
                Console.Out.WriteLine("No conection with gate");
            }

            // start the sound engine with default parameters
            var engine = new ISoundEngine();

            while (true)
            {
                comPort.ReadTimeout = 10;
                try
                {
                    var msg = comPort.ReadLine();
                    if (msg.StartsWith("OK RIDERS RANDOM START"))
                        engine.Play2D("Sounds/or.wav");

                    else if (msg.StartsWith("RIDERS READY - WATCH THE GATE"))
                        engine.Play2D("Sounds/rr.wav");
                    else if (msg.StartsWith("LIGHTS"))
                        engine.StopAllSounds();

                    Console.Out.WriteLine(msg);
                }
                catch
                {
                }
            }
        }

        // some simple function for reading keys from the console
        [DllImport("msvcrt")]
        private static extern int _getch();
    }
}