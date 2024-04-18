using Windows.Media.Capture.Core;

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
	Resultado.description="Sul";
	Resultado.rain= 48;
	Resultado.humidity= 14;
	Resultado.sunrise="6:00";
	Resultado.sunset="19:00";
	Resultado.wind_speedy="sla";
	Resultado.wind_direction= 30;
    Resultado.moon_phase="Cheia";
	Resultado.currently="sla";

  }

  void PreencherTela()
  {
	Labeltemp.Text = Resultado.temp.ToString();
	Labelrain.Text = Resultado.rain.ToString();
  }
	
}

