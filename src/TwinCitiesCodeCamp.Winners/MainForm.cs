using Spackle;

namespace TwinCitiesCodeCamp.Winners
{
    public partial class MainForm
        : Form
    {
#pragma warning disable CA2213 // Disposable fields should be disposed
        private readonly SecureRandom random = new();
#pragma warning restore CA2213 // Disposable fields should be disposed

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.random.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.LoadAttendees();
        }

        private void LoadAttendees()
        {
            var registrations = File.ReadAllLines("Registrations.txt");

            foreach (var registration in registrations)
            {
                this.attendeeList.Items.Add(registration);
            }
        }

        private void OnPickWinnerClick(object sender, EventArgs e)
        {
            if (this.attendeeList.Items.Count > 0)
            {
                var nextWinnerIndex = random.Next(0, this.attendeeList.Items.Count);
                this.currentWinner.Text = (string)this.attendeeList.Items[nextWinnerIndex];
                this.attendeeList.Items.RemoveAt(nextWinnerIndex);
            }
        }
    }
}