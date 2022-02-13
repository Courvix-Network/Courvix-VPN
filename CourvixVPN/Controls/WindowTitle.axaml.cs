using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace CourvixVPN.Controls;

public partial class WindowsTitleBar : UserControl
{
    private readonly Path _maximizeIcon;
    private readonly ToolTip _maximizeToolTip;

    private readonly DockPanel _titleBar;
    private readonly DockPanel _titleBarBackground;
    private readonly TextBlock _systemChromeTitle;
    private readonly NativeMenuBar _seamlessMenuBar;
    private readonly NativeMenuBar _defaultMenuBar;

    private static readonly StyledProperty<bool> IsSeamlessProperty =
        AvaloniaProperty.Register<WindowsTitleBar, bool>(nameof(IsSeamless));

    public bool IsSeamless
    {
        get => GetValue(IsSeamlessProperty);
        set
        {
            SetValue(IsSeamlessProperty, value);
            if (_titleBarBackground == null || _systemChromeTitle == null || _seamlessMenuBar == null ||
                _defaultMenuBar == null) return;
            
            _titleBarBackground.IsVisible = !IsSeamless;
            _systemChromeTitle.IsVisible = !IsSeamless;
            _seamlessMenuBar.IsVisible = IsSeamless;
            _defaultMenuBar.IsVisible = !IsSeamless;

            if (IsSeamless == false)
                _titleBar.Resources["SystemControlForegroundBaseHighBrush"] =
                    new SolidColorBrush {Color = new Color(255, 0, 0, 0)};
        }
    }

    public WindowsTitleBar()
    {
        InitializeComponent();

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) == false)
        {
            IsVisible = false;
        }
        else
        {
            var minimizeButton = this.FindControl<Button>("MinimizeButton");
            var maximizeButton = this.FindControl<Button>("MaximizeButton");
            _maximizeIcon = this.FindControl<Path>("MaximizeIcon");
            _maximizeToolTip = this.FindControl<ToolTip>("MaximizeToolTip");
            var closeButton = this.FindControl<Button>("CloseButton");
            var windowIcon = this.FindControl<TextBlock>("WindowIcon");

            minimizeButton.Click += MinimizeWindow;
            maximizeButton.Click += MaximizeWindow;
            closeButton.Click += CloseWindow;
            windowIcon.DoubleTapped += CloseWindow;

            _titleBar = this.FindControl<DockPanel>("TitleBar");
            _titleBarBackground = this.FindControl<DockPanel>("TitleBarBackground");
            _systemChromeTitle = this.FindControl<TextBlock>("SystemChromeTitle");
            _seamlessMenuBar = this.FindControl<NativeMenuBar>("SeamlessMenuBar");
            _defaultMenuBar = this.FindControl<NativeMenuBar>("DefaultMenuBar");

            SubscribeToWindowState();
        }
    }

    private void CloseWindow(object sender, RoutedEventArgs e)
    {
        var hostWindow = (Window) VisualRoot;
        hostWindow?.Close();
    }

    private void MaximizeWindow(object sender, RoutedEventArgs e)
    {
        var hostWindow = (Window) VisualRoot;

        hostWindow.WindowState = hostWindow.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
    }

    private void MinimizeWindow(object sender, RoutedEventArgs e)
    {
        var hostWindow = (Window) VisualRoot;
        hostWindow.WindowState = WindowState.Minimized;
    }

    private async void SubscribeToWindowState()
    {
        var hostWindow = (Window) VisualRoot;

        while (hostWindow == null)
        {
            hostWindow = (Window) VisualRoot;
            await Task.Delay(50);
        }

        hostWindow.GetObservable(Window.WindowStateProperty).Subscribe(s =>
        {
            if (s != WindowState.Maximized)
            {
                _maximizeIcon.Data =
                    Geometry.Parse("M2048 2048v-2048h-2048v2048h2048zM1843 1843h-1638v-1638h1638v1638z");
                hostWindow.Padding = new Thickness(0, 0, 0, 0);
                _maximizeToolTip.Content = "Maximize";
            }

            if (s != WindowState.Maximized) return;
            
            _maximizeIcon.Data =
                Geometry.Parse(
                    "M2048 1638h-410v410h-1638v-1638h410v-410h1638v1638zm-614-1024h-1229v1229h1229v-1229zm409-409h-1229v205h1024v1024h205v-1229z");
            hostWindow.Padding = new Thickness(7, 7, 7, 7);
            _maximizeToolTip.Content = "Restore Down";

            // This should be a more universal approach in both cases, but I found it to be less reliable, when for example double-clicking the title bar.
            /*hostWindow.Padding = new Thickness(
                        hostWindow.OffScreenMargin.Left,
                        hostWindow.OffScreenMargin.Top,
                        hostWindow.OffScreenMargin.Right,
                        hostWindow.OffScreenMargin.Bottom);*/
        });
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}