namespace Clima;

public partial class MainPage : ContentPage

{
	results Resultado;

	public MainPage()
	{
		Resultado = new results();
		InitializeComponent();
		TestandoLayout();
		PreencherTela();
	}

  void TestandoLayout()
  {
	Resultado.temp=23;
	Resultado.city="Apucarana, PR";
	Resultado.description="Tempo Nublado";
	Resultado.rain= 0;
	Resultado.humidity= 90;
	Resultado.sunrise="6:20 am";
	Resultado.sunset="6:12 pm";
	Resultado.wind_speedy="4.99 km/h";
	Resultado.wind_direction= 40;
    Resultado.moon_phase="Cheia";
	Resultado.currently="Dia";
	Resultado.codition_code="28";
	Resultado.img_id="28";
	Resultado.cloudiness=89;
	Resultado.wind_cardinal="NE";

  }

  void PreencherTela()
  {
	Labeltemp.Text = Resultado.temp.ToString();
	Labelcity.Text = Resultado.city;
	//Labeldescription.Text = Resultado.description;
	Labelrain.Text = Resultado.rain.ToString();
	Labelhumidity.Text = Resultado.humidity.ToString();
	Labelsunrise.Text = Resultado.sunrise;
	Labelsunset.Text = Resultado.sunset;
	Labelwind_speedy.Text = Resultado.wind_speedy;
	Labelwind_direction.Text = Resultado.wind_direction.ToString();
	Labelmoon_phase.Text = Resultado.moon_phase;
	Labelcurrently.Text = Resultado.currently;
	//Labelcodition_code.Text = Resultado.codition_code;
	//Labelimg_id.Text = Resultado.img_id;
	//Labelcloudiness.Text = Resultado.cloudiness.ToString();
	//Labelwind_cardinal.Text = Resultado.wind_cardinal;

	if(Resultado.currently=="Dia")
	{
		if(Resultado.rain>=10)
		 ImgFundo.Source="diachuvoso.png";
		 else if (Resultado.cloudiness>=10)
		  ImgFundo.Source="dianublado.png";
		  else
		ImgFundo.Source="diaclaroo.png";

	}
  }


	
}

