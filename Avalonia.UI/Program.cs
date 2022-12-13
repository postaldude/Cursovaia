using Avalonia;
using Avalonia.ReactiveUI;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalonia.UI
{
    /*
    class WantedPersons
    {
        public string title { get; set; }
        public char dates_of_birth_used { get; set; }
        public string nationality { get; set; }
        public string race_raw { get; set; }
        public string race { get; set; }
        public string hair_raw { get; set; }
        public string place_of_birth { get; set; }
        public string person_classification { get; set; }
        public string description { get; set; }
        public int height_max { get; set; }
        public int height_min { get; set; }

        

        public override string ToString()
        {
            return $"{title}: {dates_of_birth_used}: {nationality} nationality: {race_raw}:" +
                   $" {race}: {hair_raw}: {place_of_birth}: {person_classification}: {description}:" +
                   $"{height_max}: {height_min}";
        }
        */
        
    
    class Program
    {
        
        [STAThread]
        public static void  Main(string[] args)
        {
            /*
            using var client = new HttpClient();

            client.BaseAddress = new Uri("https://www.fbi.gov/wanted");
            client.DefaultRequestHeaders.Add("MostWanted Persons", "");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var url = "repos/symfony/symfony/persons";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            List<WantedPersons> persons = JsonConvert.DeserializeObject<List<WantedPersons>>(resp);
*/
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();

       

       
        

    }
}

