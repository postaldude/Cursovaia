namespace Avalonia.UI.Models;

public class OrdinaryUrl
{
    public string? type { get; set; }
    public string? url { get; set; }
    public string? suggested_link_text { get; set; }
    
    public OrdinaryUrl(string? type, string? url, string? suggested_link_text)
    {
        this.type = type;
        this.url = url;
        this.suggested_link_text = suggested_link_text;
    }
    
}