using System.Collections;
using Newtonsoft.Json;
using System.Drawing;

namespace Avalonia.UI.Models;

public class InformationCriminals
{


    [JsonProperty("publication")] public string? Newid { get; set; }
    [JsonProperty("@id")] public string? Title { get; set; }
    [JsonProperty("title")] public string? Office { get; set; }
    [JsonProperty("field_offices")] public string? Detail { get; set; }
    [JsonProperty("details")] public string? Pol { get; set; }
    [JsonProperty("sex")] public string? National { get; set; }
    [JsonProperty("nationality")] public int? Age { get; set; }
    [JsonProperty("age_max")] public int? Height { get; set; }
    [JsonProperty("height_max")] public string? Race { get; set; }
    [JsonProperty("race_raw")] public string? Hair { get; set; }
    [JsonProperty("hair_raw")] public string? Language { get; set; }
    [JsonProperty("languages")] public string? Urlpdf { get; set; }

    [JsonProperty("files")]
    public OrdinaryUrl? OrdinaryUrl { get; set; }
        



    public InformationCriminals(string? underNewid, string? underTitle, string? underOffice, string?
            underDetails, string? underPol, string? underNational, int? underAge, int? underHeight, string? underRace,
        string? underHair, string? underLanguage, string? underPdf, OrdinaryUrl underOrdinary)
    {
        this.Newid = underNewid;
        this.Title = underTitle;
        this.Office = underOffice;
        this.Detail = underDetails;
        this.Pol = underPol;
        this.National = underNational;
        this.Age = underAge;
        this.Height = underHeight;
        this.Race = underRace;
        this.Hair = underHair;
        this.Language = underLanguage;
        this.Urlpdf = underPdf;
        this.OrdinaryUrl = underOrdinary;




    }
}

    
    

    
        

    
    
    
    
    