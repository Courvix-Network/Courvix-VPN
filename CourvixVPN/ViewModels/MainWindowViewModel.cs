using System.Collections.Generic;
using CourvixVPN.API.Models;
using CourvixVPN.Shared;
using ReactiveUI;

namespace CourvixVPN.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Server> _servers = Globals.Servers ?? new List<Server>();
        public List<Server> Servers
        {
            get => _servers;
            set => this.RaiseAndSetIfChanged(ref _servers, value);
        }
    }
}