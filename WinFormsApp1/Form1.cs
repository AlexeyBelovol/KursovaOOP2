using System.Text;
using Xceed.Words.NET;

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
            List<Team> teams = textBoxTeams.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                                                 .Select(name => new Team(name)).ToList();
            if (teams.Count % 2 != 0)
            {
                MessageBox.Show("Please enter an even number of teams.");
                return;
            }

            var scheduler = new RoundRobinScheduler(teams);
            string schedule = scheduler.GenerateSchedule();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Document|*.docx",
                Title = "«бережена таблиц€"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (DocX document = DocX.Create(saveFileDialog.FileName))
                {
                    document.InsertParagraph(textBoxSchedule.Text);
                    document.Save();
                }
            }
        }
    }
}
