using System.Text.Json;

namespace Clima;

public partial class MainPage : ContentPage

{
	const string Url="https://api.hgbrasil.com/weather?woeid=455927&key=9948a9aa";
	Resposta resposta;

	public MainPage()
	{
		InitializeComponent();

		AtualizaTempo();
	}

  void TestandoLayout()
  {
	resposta.results.temp=23;
	resposta.results.city="Apucarana, PR";
	resposta.results.description="Tempo Nublado";
	resposta.results.rain= 10;
	resposta.results.humidity= 90;
	resposta.results.sunrise="6:20 am";
	resposta.results.sunset="6:12 pm";
	resposta.results.wind_speedy="4.99 km/h";
	resposta.results.wind_direction= 40;
    resposta.results.moon_phase="Cheia";
	resposta.results.currently="Noite";
	resposta.results.codition_code="28";
	resposta.results.img_id="28";
	resposta.results.cloudiness=89;
	resposta.results.wind_cardinal="NE";

  }

  void PreencherTela()
  {
	Labeltemp.Text = resposta.results.temp.ToString();
	Labelcity.Text = resposta.results.city;
	//Labeldescription.Text = resposta.results.description;
	Labelrain.Text = resposta.results.rain.ToString();
	Labelhumidity.Text = resposta.results.humidity.ToString();
	Labelsunrise.Text = resposta.results.sunrise;
	Labelsunset.Text = resposta.results.sunset;
	Labelwind_speedy.Text = resposta.results.wind_speedy;
	Labelwind_direction.Text = resposta.results.wind_direction.ToString();
	if (resposta.results.moon_phase=="full")
		Labelmoon_phase.Text = "Cheia";
	else if (resposta.results.moon_phase=="new")
		Labelmoon_phase.Text = "Nova";
	//Labelcurrently.Text = resposta.results.currently;
	//Labelcodition_code.Text = resposta.results.codition_code;
	//Labelimg_id.Text = resposta.results.img_id;
	//Labelcloudiness.Text = resposta.results.cloudiness.ToString();
	//Labelwind_cardinal.Text = resposta.results.wind_cardinal;

	if(resposta.results.currently=="dia")
	{
		if(resposta.results.rain>=10)
		 ImgFundo.Source="diachuvoso.png";
		 else if (resposta.results.cloudiness>=10)
		  ImgFundo.Source="dianublado.png";
		  else
		ImgFundo.Source="diaclaro.png";

	}
	else
	{
		if(resposta.results.rain>=10)
		 ImgFundo.Source="noitechuvosa.png";
		 else if (resposta.results.cloudiness>=10)
		  ImgFundo.Source="noitenublada.png";
		  else
		ImgFundo.Source="noiteclara.png";

	}
  }


	async void AtualizaTempo()
	{
		try
		{
			var httpClient=new HttpClient();
			var response = await httpClient.GetAsync(Url);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				resposta = JsonSerializer.Deserialize<Resposta>(content);
			}

			PreencherTela();
		}
		catch(Exception e)
		{
			//erro
		}
	}
}

