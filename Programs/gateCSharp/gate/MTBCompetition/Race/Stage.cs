using System.Collections.Generic;
using MTBCompetition.Compititors;

namespace MTBCompetition.Race
{
    internal class Stage : IRace
    {
        private readonly IRace _parent;

        public Stage(IRace parent, RaceName name, int nrOfCompetitors) : this(parent, name)
        {
            NrOfCompetitors = nrOfCompetitors;
        }

        public Stage(IRace parent, RaceName name)
        {
            _parent = parent;
            Name = name;
        }

        public RaceName Name { get; private set; }
        public List<IRace> HeatList { get; private set; }
        public int NrOfCompetitors { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }
    }
}