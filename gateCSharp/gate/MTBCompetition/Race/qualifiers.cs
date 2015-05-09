using System.Collections.Generic;
using MTBCompetition.Compititors;

namespace MTBCompetition.Race
{
    internal class Qualifiers : IRace
    {
        public Qualifiers(int nrOfCompetitors)
        {
            CompititorsList = new List<Competitor>();
            Stages = new List<Stage>();
            NrOfCompetitors = nrOfCompetitors;
            Stages.Add(new Stage(this, RaceName.Qualifier2));
            if (nrOfCompetitors > 32)
            {
                Stages.Add(new Stage(this, RaceName.Qualifier4));
                if (nrOfCompetitors > 64)
                {
                    Stages.Add(new Stage(this, RaceName.Qualifier8));
                    if (nrOfCompetitors > 128)
                    {
                        Stages.Add(new Stage(this, RaceName.Qualifier16));
                    }
                }
            }
        }

        public List<Stage> Stages { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }
        public int NrOfCompetitors { get; private set; }
    }
}