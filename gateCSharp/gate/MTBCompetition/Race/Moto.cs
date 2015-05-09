using System.Collections.Generic;
using MTBCompetition.Compititors;

namespace MTBCompetition.Race
{
    internal class Moto : IRace
    {
        public List<Competitor> CompititorsList { get; private set; }
        public int NrOfCompetitors { get; private set; }
    }
}