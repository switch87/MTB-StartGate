using System.Collections.Generic;
using MTBCompetition.Race.Compititor;

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
        public bool RaceStarted { get; private set; }
        public List<Competitor> CompititorsList { get; private set; }

        public void AddCompititor(Competitor competitor)
        {
            if (!RaceStarted) CompititorsList.Add(competitor);
        }

        public void Start()
        {
            if (RaceStarted) return;
            if (CompititorsList.Count < 9)
            {
                Races = new IRace[2];
                Races[1] = new Stage(RaceName.Final);
            }
            else
            {
                Races = new IRace[3];
                Races[1] = new Qualifiers();
                Races[2] = new Stage(RaceName.Final);
            }

            Races[0] = new Motos();
            RaceStage = 0;
        }

        public IRace CurentStage()
        {
            return RaceStage == null ? null : Races[(int) RaceStage];
        }
    }
}