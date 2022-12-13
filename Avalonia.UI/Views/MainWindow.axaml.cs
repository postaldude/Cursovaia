using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.UI.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Newtonsoft.Json;
using Avalonia.UI.Models;
using System.Net;
using System.Net.Http;

namespace Avalonia.UI.Views
{
    
    public partial class MainWindow : Window //ReactiveWindow<MainWindowViewModel>
    {
       
        public MainWindow()
        {
            InitializeComponent();
            
            string link = "https://api.fbi.gov/wanted/v1/list";
            Api(link);

            //Окно не открывается
           // this.WhenActivated(d => d(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
        }
        /*private async Task DoShowDialogAsync(InteractionContext<Crime, Statistic?> interaction)
        {
            var dialog = new Crime();
            dialog.DataContext = interaction.Input;

            var result = await dialog.ShowDialog<Statistic?>(this);
            interaction.SetOutput(result);
        }*/
        
        public void Api(string way)
        {
            DataInput.Items = null;
            InformationCriminal.Clear();

           
                using (var client = new HttpClient())
                {
                    var newway = new Uri(way);

                    var itog = client.GetAsync(newway).Result;

                    var newformat = itog.Content.ReadAsStringAsync().Result;
                    Deserealization? deserealization = JsonConvert.DeserializeObject<Deserealization>(newformat);

                    var realization = deserealization.deserealize;
                    foreach (var result in realization)
                    {
                        OrdinaryUrls.Add(new OrdinaryUrl(result.OrdinaryUrl.type, result.OrdinaryUrl.url,
                            result.OrdinaryUrl.suggested_link_text));
                        InformationCriminal.Add(new InformationCriminals(result.Newid, result.Title, result.Office,
                            result.Detail,
                            result.Pol, result.National, result.Age, result.Height, result.Race, result.Hair,
                            result.Language, result.Urlpdf, result.OrdinaryUrl));
                    }

                    DataInput.Items = InformationCriminal;
                }
            
        }
       
       
        private void MostWanted(object? sender, RoutedEventArgs e)
        {
            string link = "https://api.fbi.gov/wanted/v1/list";
            
            Api(link);
        }
        
        
        public List<InformationCriminals> InformationCriminal = new List<InformationCriminals>(8);
        public List<OrdinaryUrl> OrdinaryUrls = new List<OrdinaryUrl>();
        
       
    }
    
}