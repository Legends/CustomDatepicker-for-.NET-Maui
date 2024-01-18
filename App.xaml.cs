using Microsoft.Maui.Handlers;

namespace CustomDatepicker
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
 
            // default datepicker ignorant of date format and first day of week
            var userLanguages = global::Windows.System.UserProfile.GlobalizationPreferences.Languages;
            var dateFormat = new global::Windows.Globalization.DateTimeFormatting.DateTimeFormatter("shortdate", userLanguages);
            DatePickerHandler.Mapper.AppendToMapping("FixDateFormat", (handler, view) =>
            {
                handler.PlatformView.FirstDayOfWeek = (global::Windows.Globalization.DayOfWeek)(int)
                    System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
                handler.PlatformView.DateFormat = dateFormat.Patterns.FirstOrDefault() ?? "shortdate";
            }); 

			MainPage = new AppShell();
		}
	}
}
