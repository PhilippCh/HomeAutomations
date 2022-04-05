namespace HomeAutomations.Client.Services.TrayIcon;

public class TrayIconService
{
	private readonly NotifyIcon _icon;

	public TrayIconService()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);

		_icon = new NotifyIcon
		{
			Icon = new Icon("appIcon.ico"),
			Text = "HomeAutomations.Client",
			Visible = true,
			ContextMenuStrip = new ContextMenuStrip()
		};
	}
}
