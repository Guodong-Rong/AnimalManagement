namespace AnimalManagement;

public partial class UnitTester : ContentPage
{
	public UnitTester()
	{
		InitializeComponent();
	}
    
    private void btnRunTests_Clicked(object sender, EventArgs e)
    {
        UnitTest unitTest = new UnitTest();
        unitTest.testName();
        unitTest.testBreed();
        unitTest.testGender();
        unitTest.testDOB();

    }
}