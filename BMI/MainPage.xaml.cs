namespace BMI;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    
    
    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        double weight = Convert.ToInt32(weight_int.Text);
        double height = Convert.ToInt32(height_int.Text);
        double bmi = (weight / (height * height)) * 703;
        BMI.Text = $"Your BMI is {bmi}. ";
    }
}