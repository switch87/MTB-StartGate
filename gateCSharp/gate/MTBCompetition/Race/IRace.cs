using System.Collections.Generic;
using MTBCompetition.Race.Compititor;

namespace MTBCompetition.Race
{
    internal interface IRace
    {
        List<Competitor> CompititorsList { get; }
    }
}