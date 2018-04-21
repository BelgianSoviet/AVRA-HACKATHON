using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GetAPI : MonoBehaviour
{
    //public Text LocationText;
    public Text WeatherText;

    void Start ()
    {
        StartCoroutine(GetText());
    }
    
    IEnumerator GetText()
    {
        string IsDay;
        UnityWebRequest IpAddress = UnityWebRequest.Get("https://api.ipify.org?format=json");
        yield return IpAddress.SendWebRequest();

        if (IpAddress.isNetworkError || IpAddress.isHttpError)
        {
            Debug.Log(IpAddress.error);
        }
        else
        {
            var JsonIpAddress = JsonConvert.DeserializeObject<IpAddress>(IpAddress.downloadHandler.text);
            Debug.Log(JsonIpAddress.ip);
            //
            UnityWebRequest IpInfos = UnityWebRequest.Get("https://ipfind.co/?ip=" + JsonIpAddress.ip);
            yield return IpInfos.SendWebRequest();
            if (IpInfos.isNetworkError || IpInfos.isHttpError)
            {
                Debug.Log(IpInfos.error);
            }
            else
            {
                var JsonIpData = JsonConvert.DeserializeObject<IpInfo>(IpInfos.downloadHandler.text);
                //LocationText.text = JsonIpData.city + " , " + JsonIpData.country_code;
                Debug.Log(JsonIpData.city);
                //
                UnityWebRequest WeatherInfos = UnityWebRequest.Get("http://api.apixu.com/v1/current.json?key=f8cc92ff6e3a43068e515151182104&q=" + JsonIpData.city + "," + JsonIpData.country);
                yield return WeatherInfos.SendWebRequest();
                if(WeatherInfos.isNetworkError || WeatherInfos.isHttpError)
                {
                    Debug.Log(WeatherInfos.error);
                }
                else
                {
                    var JsonWeatherData = JsonConvert.DeserializeObject<Weather>(WeatherInfos.downloadHandler.text);
                    if (JsonWeatherData.current.is_day == 1) IsDay = "Jour";
                    else IsDay = "Nuit";
                    WeatherText.text = JsonWeatherData.current.temp_c + "°C  " + IsDay;
                    Debug.Log(JsonWeatherData.current.temp_c.ToString());
                }
            }
        }
    }
}

public class IpAddress
{
    public string ip;
}

public class IpInfo
{
    public string ip_address { get; set; }
    public string country { get; set; }
    public string country_code { get; set; }
    public string continent { get; set; }
    public string continent_code { get; set; }
    public string city { get; set; }
    public string county { get; set; }
    public string region { get; set; }
    public string region_code { get; set; }
    public string timezone { get; set; }
    public object owner { get; set; }
    public double longitude { get; set; }
    public double latitude { get; set; }
    public string currency { get; set; }
    public List<string> languages { get; set; }
    public string warning { get; set; }
}

public class Location
{
    public string name;
    public string region;
    public string country;
    public double lat;
    public double lon;
    public string tz_id;
    public int localtime_epoch;
    public string localtime;
}

public class Condition
{
    public string text;
    public string icon;
    public int code;
}

public class Current
{
    public int last_updated_epoch;
    public string last_updated;
    public double temp_c;
    public double temp_f;
    public int is_day;
    public Condition condition;
    public double wind_mph;
    public double wind_kph;
    public int wind_degree;
    public string wind_dir;
    public double pressure_mb;
    public double pressure_in;
    public double precip_mm;
    public double precip_in;
    public int humidity;
    public int cloud;
    public double feelslike_c;
    public double feelslike_f;
    public double vis_km;
    public double vis_miles;
}

public class Weather
{
    public Location location;
    public Current current;
}
