using Uno.UI.Runtime.Skia;

namespace DDD2022OctCat;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			Console.CursorVisible = false;

			var host = new FrameBufferHost(() => new App(), args);
			host.Run();
		}
		finally
		{
			Console.CursorVisible = true;
		}
	}
}
