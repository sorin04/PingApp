using PingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string baseIpText = textAdresse.Text;
            string numberOfPingsText = textNombrePings.Text;

            IPV4 baseIp;
            try
            {
                baseIp = new PingApp.Calculipv4(baseIpText);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Adresse incorrecte : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(numberOfPingsText, out int numberOfPings) || numberOfPings <= 0)
            {
                MessageBox.Show("Le nombre d'adresses à pinger est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listView1.Items.Clear();
            var tasks = new List<Task>();
            for (int i = 0; i < numberOfPings; i++)
            {
                try
                {
                    IPV4 ipToPing = baseIp.Increment(i);
                    tasks.Add(Task.Run(() => PingIP(ipToPing.Address)));
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Task.WhenAll(tasks).ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    infoLabel.Text = "Pings terminés.";
                }));
            });
        }

        private void PingIP(string ipAddress)
        {
            Ping pingSender = new Ping();

            try
            {
                PingReply reply = pingSender.Send(ipAddress);
                string status = reply.Status == IPStatus.Success ? "Succès" : $"Échec : {reply.Status}";
                string roundtripTime = reply.Status == IPStatus.Success ? reply.RoundtripTime.ToString() : "N/A";

                ListViewItem item = new ListViewItem(ipAddress);
                item.SubItems.Add(roundtripTime);
                item.SubItems.Add(status);
                Invoke(new Action(() => listView1.Items.Add(item)));
            }
            catch (Exception ex)
            {
                ListViewItem item = new ListViewItem(ipAddress);
                item.SubItems.Add("N/A");
                item.SubItems.Add($"Erreur : {ex.Message}");
                Invoke(new Action(() => listView1.Items.Add(item)));
            }
        }
    }
}
