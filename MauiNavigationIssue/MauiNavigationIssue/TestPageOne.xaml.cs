namespace MauiNavigationIssue;

public partial class TestPageOne : ContentPage, IQueryAttributable
{
	public TestPageOne() 
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
		var p = query;
    }

    protected override void OnAppearing()
    {
        // pass query params into the view model
        base.OnAppearing();
    }
}