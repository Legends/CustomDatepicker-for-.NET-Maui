using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Handlers;
using System.Globalization;

namespace CustomDatepicker
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = CultureInfo.GetCultureInfo("de-DE");

			// default datepicker ignorant of date format and first day of week
			var userLanguages = global::Windows.System.UserProfile.GlobalizationPreferences.Languages;
			var dateFormat = new Windows.Globalization.DateTimeFormatting.DateTimeFormatter("shortdate", userLanguages);
			DatePickerHandler.Mapper.AppendToMapping("FixDateFormat", (handler, view) =>
			{
				handler.PlatformView.FirstDayOfWeek = (Windows.Globalization.DayOfWeek)(int)
					CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
				handler.PlatformView.DateFormat = dateFormat.Patterns.FirstOrDefault() ?? "shortdate";
			});

			MainPage = new AppShell();
		}
	}
}
