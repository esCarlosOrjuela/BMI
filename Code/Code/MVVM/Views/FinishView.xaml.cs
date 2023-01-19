namespace Code.MVVM.Views;

public partial class FinishView : ContentPage
{
    public FinishView()
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
        Navigation.PopToRootAsync();
    }
}
