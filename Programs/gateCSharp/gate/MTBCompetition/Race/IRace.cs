using System.Collections.Generic;
using MTBCompetition.Compititors;

namespace MTBCompetition.Race
{
    internal interface IRace
    {
        List<Competitor> CompititorsList { get; }
        int NrOfCompetitors { get; }
    }
}