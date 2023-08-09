namespace MauiNavigationIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnNavigateBtnClicked(object sender, EventArgs e)
	{
        /*
		 
			TestPageOne.ApplyQueryAttributes() will be called before TestPageOne.OnAppearing()

			when you use the navigation below.
		 
		 */
        //await Shell.Current.GoToAsync("TestPageOne", new Dictionary<string, object>
        //{
        //    ["parameter"] = "From main page"
        //});

        /*
		 
			TestPageOne.OnAppearing() will be called before TestPageOne.ApplyQueryAttributes()

			when you use the navigation below.
		 
		 */
        await Shell.Current.GoToAsync("//TestPageOne", new Dictionary<string, object>
		{
			["parameter"] = "From main page"
		});
	}
}

