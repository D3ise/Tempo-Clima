namespace Clima;

public class Results
{
    public int temp {get;set;}
    public string description {get;set;}
    public string city {get;set;}
    public double rain {get;set;}
    public int humidity {get;set;}

    public string sunrise {get;set;}

    public string sunset {get;set;}

    public string wind_speedy {get;set;}

    public int wind_direction {get;set;}

    public string moon_phase {get;set;}

    public string currently {get;set;}

    public string codition_code {get;set;}

    public string img_id {get;set;}

    public double cloudiness {get;set;}
    
    public string wind_cardinal {get;set;}

    public List<Forecast> forecast {get;set;}


}