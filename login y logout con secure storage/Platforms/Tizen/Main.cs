using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace login_y_logout_con_secure_storage;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
