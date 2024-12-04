using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace PingApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Adresse IP", 150);
            listView1.Columns.Add("Temps de réponse (ms)", 200);
            listView1.Columns.Add("Statut", 150);
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "";

            var toTest = textAdresse.Text;
            if (!TestIp(toTest))
            {
                MessageBox.Show("Adresse Incorrecte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PingIP(toTest);
        }

        private bool TestIp(string toTest)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            bool isValid = Regex.IsMatch(toTest, pattern);
            return isValid;
        }

        private void PingIP(String toTest)
        {
            Ping pingSender = new Ping();

            try
            {
                PingReply reply = pingSender.Send(toTest);
                string status = reply.Status == IPStatus.Success ? "Succès" : $"Échec : {reply.Status}";
                string roundtripTime = reply.Status == IPStatus.Success ? reply.RoundtripTime.ToString() : "N/A";

                ListViewItem item = new ListViewItem(toTest);
                item.SubItems.Add(roundtripTime);
                item.SubItems.Add(status);
                listView1.Items.Add(item);

                infoLabel.Text = reply.Status == IPStatus.Success
                        ? $"Temps de réponse : {reply.RoundtripTime} ms"
                        : $"Ping échoué : {reply.Status}";
            }
            catch (Exception ex)
            {
                infoLabel.Text = $"Erreur : {ex.Message}";

                ListViewItem item = new ListViewItem(toTest);
                item.SubItems.Add("N/A");
                item.SubItems.Add($"Erreur : {ex.Message}");
                listView1.Items.Add(item);
            }
        }
    }
}
