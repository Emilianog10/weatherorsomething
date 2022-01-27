using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using static System.Text.Json.JsonElement;
using System.Linq;

public class WeatherAPI
{

    private readonly Dictionary<string, string> headers;
    // private readonly string CURRENT_URI = "https://weatherapi-com.p.rapidapi.com/current.json";
    private readonly string FORECAST_URI = "https://weatherapi-com.p.rapidapi.com/forecast.json";


    public WeatherAPI()
    {
        headers = new Dictionary<string, string>();
        headers["x-rapidapi-host"] = "weatherapi-com.p.rapidapi.com";
        headers["x-rapidapi-key"] = "62edfa1f41msha9e7c8696476fc3p1d3806jsna8e876d7f719";
    }

    public Weather GetWeather(string zipcode)
    {
        string data = this.Get($"{FORECAST_URI}?q={zipcode}&days=3");
        JsonDocument doc = JsonDocument.Parse(data);
        JsonElement root = doc.RootElement;
        Weather result = new Weather();
        result.LocationData = ToDictionary(root.GetProperty("location"));
        result.CurrentData = ToDictionary(root.GetProperty("current"));
        result.ForecastData = new List<Dictionary<string, string>>();

        // Console.WriteLine(root.ToString());
        
        foreach (JsonElement day in root.GetProperty("forecast").GetProperty("forecastday").EnumerateArray())
        {
            // Console.WriteLine("day!");
            Dictionary<string, string> dayDict = ToDictionary(day.GetProperty("day"));
            dayDict["date"] = day.GetProperty("date").ToString();
            result.ForecastData.Add(dayDict);
        }
        return result;
    }

    private Dictionary<string, string> ToDictionary(JsonElement elem)
    {
        Dictionary<string, string> data = new Dictionary<string, string>();
        foreach (JsonProperty prop in elem.EnumerateObject())
        {

            data[prop.Name] = prop.Value.ToString();
        }
        return data;
    }


    private string Get(string uri)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        foreach (string key in this.headers.Keys)
        {
            request.Headers.Add(key, this.headers[key]);
        }


        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
    }

}