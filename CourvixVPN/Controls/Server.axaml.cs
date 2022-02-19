using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CourvixVPN.Controls;

public partial class Server : UserControl
{
    public Server(string name, string provider, string protection)
    {
        InitializeComponent();

        this.FindControl<TextBlock>("NameText").Text = name;
        this.FindControl<TextBlock>("ProviderText").Text = provider;
        this.FindControl<TextBlock>("ProtectionText").Text = protection;
    }

    public Server()
    {
        
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}