using Code.MVVM.ViewModels;

namespace Code.MVVM.Views;

public partial class BMIView : ContentPage
{
    public BMIView()
    {
        InitializeComponent();
        BindingContext = new BMIViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Utilities.NavUtilities.Examine(Navigation);
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        if (sender is Button)
        {
            var selectedButton = (Button)sender;

            if (selectedButton.Text.Equals("Go Back"))
                Navigation.PopAsync();
            else if (selectedButton.Text.Equals("Next"))
                Navigation.PushAsync(new FinishView());
        }

    }
}
