using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using System.Text;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;



namespace Avalonia.UI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Color => "#263740";
        public string Color2 => "#386370";
        public string Title => "Где Посылка";
        
        
        //Окно не открывается
        /*public MainWindowViewModel()
        {
            ShowDialog = new Interaction<Crime, Statistic?>();

            WantedCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var store = new Crime();

                var result = await ShowDialog.Handle(store);
            });
        }*/

        /*public ICommand WantedCommand { get; }

        public Interaction<Crime, Statistic?> ShowDialog { get; }*/
    }
    
    
}