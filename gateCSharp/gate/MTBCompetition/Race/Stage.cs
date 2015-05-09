using System.Collections.Generic;
using MTBCompetition.Race.Compititor;

namespace MTBCompetition.Race
{
    internal class Stage : IRace
    {
        public Stage(RaceName name)
        {
            Name = name;
        }

        public RaceName Name { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }
    }
}