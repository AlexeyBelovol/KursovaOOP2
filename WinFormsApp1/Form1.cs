using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string[] teams = textBoxTeams.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            if (teams.Length % 2 != 0)
            {
                MessageBox.Show("Ѕудь-ласка введ≥ть парну к≥льк≥сть команд");
                return;
            }

            string schedule = GenerateRoundRobinSchedule(teams);
            textBoxSchedule.Text = schedule;
        }
        private string GenerateRoundRobinSchedule(string[] teams)
        {
            int numTeams = teams.Length;
            int numRounds = numTeams - 1;
            int numMatchesPerRound = numTeams / 2;

            StringBuilder sb = new StringBuilder();

            for (int round = 0; round < numRounds; round++)
            {
                sb.AppendLine($"“ур {round + 1}");

                for (int match = 0; match < numMatchesPerRound; match++)
                {
                    int home = (round + match) % (numTeams - 1);
                    int away = (numTeams - 1 - match + round) % (numTeams - 1);

                    if (match == 0)
                    {
                        away = numTeams - 1;
                    }

                    sb.AppendLine($"{teams[home]} Ч {teams[away]}");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
