#region Menü_Başlangıcı
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Şehir Ekleme");
Console.WriteLine("4-Şehir Silme");
Console.WriteLine("5-Şehir Güncelleme");
Console.WriteLine("6-Id'ye Göre Şehir Getirme");
Console.WriteLine();

#endregion

string number;


Console.WriteLine("Tercihiniz: ");
number = Console.ReadLine();

if(number == "1")
{
    string url = "https://localhost:7063/api/Weather";
    using(HttpClient client = new HttpClient())
    {
        HttpResponseMessage response=await client.GetAsync(url);
        string responseBody=await response.Content.ReadAsStringAsync();
        JArray jArray= JArray.Parse(responseBody);
        foreach(var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            Console.WriteLine($"Şehir: {cityName}");
        }
    }
}
if(number == "2")
{
    string url = "https://localhost:7063/api/Weather";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temperature"].ToString();
            string country = item["country"].ToString();

            Console.WriteLine(cityName + "-" + country + "-->" +temp + "Derece");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
if(number == "3")
{
    Console.WriteLine("### Yeni Şehir Ekleme");
    Console.WriteLine();
    string cityNme, country, detail;
    decimal temperature;

    Console.WriteLine("Şehir Adı: ");
    cityNme=Console.ReadLine();

    Console.WriteLine("Ülke Adı: ");
    country=Console.ReadLine();

    Console.WriteLine("Hava Durumu Detayı: ");
    detail=Console.ReadLine();

    Console.WriteLine("Sıcaktlık: ");
    temperature=decimal.Parse(Console.ReadLine());

    string url = "https://localhost:7063/api/Weather";
    var newWeatherCity = new
    {
        CityName = cityNme,
        Country = country,
        Detail = detail,
        Temperature = temperature,
    };

    using(HttpClient client = new HttpClient())
    {
        string json=JsonConvert.SerializeObject(newWeatherCity);
        StringContent content = new StringContent(json,Encoding.UTF8,"application/json");
        HttpResponseMessage responseMessage =await client.PostAsync(url,content);
        responseMessage.EnsureSuccessStatusCode();
    }
  
}
if(number == "4")
{
    string url = "https://localhost:7063/api/Weather?id=";
    Console.WriteLine("Silmek istediğiniz Id Değerini: ");
    int id=int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage responseMessage=await client.DeleteAsync(url+id);
        responseMessage.EnsureSuccessStatusCode();
    }

}
if(number == "5")
{
    string url = "https://localhost:7063/api/Weather";
    Console.WriteLine("### Veri Güncelleme");
    Console.WriteLine();
    string cityNme, country, detail;
    decimal temperature;
    int cityId;

    Console.WriteLine("Şehir Adı: ");
    cityNme = Console.ReadLine();

    Console.WriteLine("Ülke Adı: ");
    country = Console.ReadLine();

    Console.WriteLine("Hava Durumu Detayı: ");
    detail = Console.ReadLine();

    Console.WriteLine("Sıcaktlık: ");
    temperature = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Şehir Id: ");
    cityId = int.Parse(Console.ReadLine());

    var updatedWeather = new
    {
        cityId = cityId,
        cityName = cityNme,
        detail = detail,
        temp = temperature,
        country = country,
    };


    using (HttpClient client = new HttpClient()) 
    {
        string json = JsonConvert.SerializeObject(updatedWeather);
        StringContent stringContent = new StringContent(json,Encoding.UTF8,"application/json");
        HttpResponseMessage response = await client.PutAsync(url, stringContent);
        response.EnsureSuccessStatusCode() ;
    }
}
if(number == "6")
{
    string url = "https://localhost:7063/api/GetByIdWeather?id=";
    Console.WriteLine("Bilgilerini Getirmek İStediğiniz Id Değerini Giriniz: ");
    int id=int.Parse(Console.ReadLine());

    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url+id);
        response.EnsureSuccessStatusCode() ;
        string responseBody=await response.Content.ReadAsStringAsync();
        JObject weatherCityObject=JObject.Parse(responseBody);

        string cityName = weatherCityObject["cityName"].ToString();
        string detail = weatherCityObject["detail"].ToString();
        string country = weatherCityObject["country"].ToString();
        decimal temperature =decimal.Parse( weatherCityObject["temperature"].ToString());

        Console.WriteLine("Girmiş Olduğunuz Id Değerine ait bilgiler");
        Console.WriteLine();
        Console.WriteLine("Şehir: " + cityName + "Ülke: " + country + "Detay: " + detail + "Sıcaklık: " + temperature);
    };
}

Console.Read();