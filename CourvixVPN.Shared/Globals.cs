using CourvixVPN.API.Models;
using SimpleInjector;

namespace CourvixVPN.Shared;

public static class Globals
{
    public static List<Server>? Servers = new();
    public static readonly Container Container = new();
}