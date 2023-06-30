namespace E4;

public partial class MainPage : ContentPage
{

 ///<Summary>
///<Createddate>27/6/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>27/6/2023</lastmodificationdate>
///<lastmodificationdescription>
///Se reciven valores luego se multiplican 
///</lastmodificationdescription>
//////<lastmodifierautor>Fernando</lastmodifierautor>
///</Summary>
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int nume1 = Convert.ToInt32(num1.Text);

		int r1 = nume1 * nume1;
        int r2 = nume1 * nume1 * nume1;

		la.Text = "El numero " + nume1 + " tiene de cuadrado " + r1 + " y el cubo " + r2;
    }
}

