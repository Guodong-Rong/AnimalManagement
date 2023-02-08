namespace AnimalManagement;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    Dog dog1;
    private void btnCreate_Clicked(object sender, EventArgs e)
    {
        dog1 = new Dog();
        dog1.setName(entName.Text);
        dog1.setBreed(entBreed.Text);
        if (radMale.IsChecked)
        {
            dog1.setGender("Male");
        }
        else
        {
            dog1.setGender("Female");
        }
        dog1.setDOB(datDOB.Date.ToString("dd/MMM/yyyy"));
        DisplayAlert("Class Created", "Dog1 class has been created", "OK");
    }

    private void btnGet_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Dog1 object instance", "dog1.name = " + dog1.getName() + Environment.NewLine + "dog1.breed = " + dog1.getBreed() + Environment.NewLine + "dog1.gender = " + dog1.getGender() + Environment.NewLine + "dog1.DOB = " + dog1.getDOB(), "OK");
    }

}

