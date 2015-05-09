using System;
using System.Collections.Generic;
using MTBCompetition.Race.Compititor;

namespace MTBCompetition.Race
{
    internal class Motos : IRace
    {
        public Motos()
        {
            MotoStages = new Stage[3];
            for (int i = 0; i < 3; i++)
            {
                MotoStages[i]=new Stage((RaceName)Enum.Parse(typeof(RaceName),"Moto"+i));
            }
        }

        public Stage[] MotoStages { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }
    }
}