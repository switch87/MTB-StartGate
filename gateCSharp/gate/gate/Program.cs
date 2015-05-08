using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;
using System.IO.Ports;

namespace gate
{
    class Program
    {
        
		//[STAThread]
		static void Main(string[] args)
		{
            SerialPort comPort = new SerialPort("COM3",9600); 
            if (comPort.IsOpen == true) comPort.Close();
            try
            {
                comPort.Open();
            }
            catch { Console.Out.WriteLine("No conection with gate"); }

            // start the sound engine with default parameters
			ISoundEngine engine = new ISoundEngine();

            while (true)
            {
                comPort.ReadTimeout = 2000;
                try
                {
                    string msg = comPort.ReadLine();
                    if ( msg.StartsWith( "OK RIDERS RANDOM START" ) )
                        engine.Play2D( "../../or.wav" );

                    else if ( msg.StartsWith( "RIDERS READY - WATCH THE GATE" ) )
                        engine.Play2D( "../../rr.wav" );
                    else if ( msg.StartsWith( "LIGHTS" ) ) engine.StopAllSounds();
                    Console.Out.WriteLine(msg);
                } catch{}
            }


		}
		
		// some simple function for reading keys from the console
		[System.Runtime.InteropServices.DllImport("msvcrt")]
		static extern int _getch();
	}
    
}
