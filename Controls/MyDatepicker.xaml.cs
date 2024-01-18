namespace CustomDatepicker.Controls;

public partial class MyDatepicker : ContentView
{
	public MyDatepicker()
	{
		InitializeComponent();
	}
	string text = "Pick a date";
	public string Text { get { return text; } set { text = value; OnPropertyChanged(); } }
 
	private void OnDateSelected(object sender, DateChangedEventArgs e)
	{
		Text = e.NewDate.ToString("dd.MM.yyyy"); // your custom format or use IFormatProvider
	}
}