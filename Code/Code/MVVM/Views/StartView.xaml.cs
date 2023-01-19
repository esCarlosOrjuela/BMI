namespace Code.MVVM.Views;

public partial class StartView : ContentPage
{
    public StartView()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Utilities.NavUtilities.Examine(Navigation);
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Views.BMIView());
    }
}
