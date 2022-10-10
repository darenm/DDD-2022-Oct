
namespace DDD2022OctCat.Presentation;

public partial class MainViewModel
{
	public string? Title { get; }

	public MainViewModel(
		INavigator navigator,
		IRouteNotifier routeNotifier,
		IOptions<AppConfig> appInfo)
	{ 
	
		_navigator = navigator;
		_routeNotifier = routeNotifier;
		_routeNotifier.RouteChanged += _routeNotifier_RouteChanged;
        Title = $"Main - {appInfo?.Value?.Title}";

        _ = Start();

    }

	private void _routeNotifier_RouteChanged(object? sender, RouteChangedEventArgs e)
	{
		var a = e.Region;
	}

	public async Task Start()
    {
		if (await _navigator.CanNavigate(new Route("Second")))
		{
            var response = await _navigator.NavigateViewModelAsync<SecondViewModel>(this, "./MainFrame/");
            if (response != null)
            {
                var b = response.Success;
            }
        }
    }

    private INavigator _navigator;
	private IRouteNotifier _routeNotifier;
}
