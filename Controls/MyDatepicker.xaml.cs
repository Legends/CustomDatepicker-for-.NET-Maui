namespace CustomDatepicker.Controls;

public partial class MyDatepicker : ContentView
{
	public MyDatepicker()
	{
		InitializeComponent();
	}
	string text = "Datum ausw�hlen";
	public string Text { get { return text; } set { text = value; OnPropertyChanged(); } }
 
	private void OnDateSelected(object sender, DateChangedEventArgs e)
	{
		Text = e.NewDate.ToShortDateString();// e.NewDate.ToString("dd.MM.yyyy"); // your custom format or use IFormatProvider
	}
}