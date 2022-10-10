
namespace DDD2022OctCat.Presentation;

public class ShellViewModel
{
    private INavigator Navigator { get; }

    private IRouteNotifier _routeNotifier;

    public ShellViewModel(
                IRouteNotifier routeNotifier,
        INavigator navigator)
    {

        Navigator = navigator;

        _routeNotifier = routeNotifier;
        _routeNotifier.RouteChanged += _routeNotifier_RouteChanged;

        _ = Start();
    }

    private void _routeNotifier_RouteChanged(object? sender, RouteChangedEventArgs e)
    {
        var a = e.Region;
    }

    public async Task Start()
    {
        await Navigator.NavigateViewModelAsync<MainViewModel>(this);
    }
}
