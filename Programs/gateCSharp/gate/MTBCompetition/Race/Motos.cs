using System;
using System.Collections.Generic;
using MTBCompetition.Compititors;

namespace MTBCompetition.Race
{
    internal class Motos : IRace
    {
        public Motos(int nrOfCompetitors)
        {
            NrOfCompetitors = nrOfCompetitors;
            MotoStages = new Stage[3];
            for (var i = 0; i < 3; i++)
            {
                MotoStages[i] = new Stage(this, (RaceName) Enum.Parse(typeof (RaceName), "Moto" + i), nrOfCompetitors);
            }
        }

        public Stage[] MotoStages { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }
        public int NrOfCompetitors { get; private set; }
    }
}