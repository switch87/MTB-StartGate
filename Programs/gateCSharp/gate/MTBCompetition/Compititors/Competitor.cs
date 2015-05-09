using System;

namespace MTBCompetition.Compititors
{
    internal class Competitor
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public int TotalScore { get; private set; }
    }
}