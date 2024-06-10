using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class RoundRobinScheduler
    {
        public List<Team> Teams { get; private set; }

        public RoundRobinScheduler(List<Team> teams)
        {
            Teams = teams;
        }

        public string GenerateSchedule()
        {
            int numTeams = Teams.Count;
            int numRounds = numTeams - 1;
            int numMatchesPerRound = numTeams / 2;

            StringBuilder sb = new StringBuilder();

            for (int round = 0; round < numRounds; round++)
            {
                sb.AppendLine($"Round {round + 1}");

                for (int match = 0; match < numMatchesPerRound; match++)
                {
                    int home = (round + match) % (numTeams - 1);
                    int away = (numTeams - 1 - match + round) % (numTeams - 1);

                    if (match == 0)
                    {
                        away = numTeams - 1;
                    }

                    sb.AppendLine($"{Teams[home]} — {Teams[away]}");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
