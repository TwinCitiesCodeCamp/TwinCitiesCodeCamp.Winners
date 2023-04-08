using Spackle;

namespace TwinCitiesCodeCamp.Winners;

public partial class MainForm
	: Form
{
   private readonly SecureRandom random = new();

   public MainForm() => 
		this.InitializeComponent();

	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components is not null)
		{
			this.components.Dispose();
			this.random.Dispose();
		}

		base.Dispose(disposing);
	}

	protected override void OnLoad(EventArgs e)
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
			var nextWinnerIndex = this.random.Next(0, this.attendeeList.Items.Count);
			this.currentWinner.Text = (string)this.attendeeList.Items[nextWinnerIndex];
			this.attendeeList.Items.RemoveAt(nextWinnerIndex);
		}
	}
}