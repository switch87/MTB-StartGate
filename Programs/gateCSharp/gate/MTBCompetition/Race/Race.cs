using System.Collections.Generic;
using MTBCompetition.Compititors;

namespace MTBCompetition.Race
{
    internal class Race : IRace
    {
        public Race(List<Competitor> competitors)
        {
            CompititorsList = competitors;
            RaceStage = null;
        }

        public int? RaceStage { get; set; }
        public IRace[] Races { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }
        public int NrOfCompetitors { get; private set; }

        public void AddCompititor(Competitor competitor)
        {
            if (RaceStage==null) CompititorsList.Add(competitor);
        }

        public void Start()
        {
            if (RaceStarted) return;
            NrOfCompetitors = CompititorsList.Count;
            if (NrOfCompetitors < 9)
            {
                Races = new IRace[2];
                Races[1] = new Stage(this, RaceName.Final, 2);
            }
            else
            {
                Races = new IRace[3];
                Races[1] = new Qualifiers(NrOfCompetitors);
                Races[2] = new Stage(this, RaceName.Final, 2);
            }

            Races[0] = new Motos(NrOfCompetitors);
            RaceStage = 0;
        }

        public IRace CurentStage()
        {
            return RaceStage == null ? null : Races[(int) RaceStage];
        }
    }
}