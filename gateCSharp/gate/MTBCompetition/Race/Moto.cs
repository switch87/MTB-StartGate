using System.Collections.Generic;
using MTBCompetition.Race.Compititor;

namespace MTBCompetition.Race
{
    internal class Moto : IRace
    {
        public List<Competitor> CompititorsList { get; private set; }
    }
}