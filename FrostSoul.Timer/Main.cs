using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;

public class Main : MacroDeckPlugin
{

    // Optional; If your plugin can be configured, set to "true". It'll make the "Configure" button appear in the package manager.
    public override bool CanConfigure => true;

    // Gets called when the plugin is loaded
    public override void Enable()
    {
    //    this.Actions = new List<PluginAction>{
    //  // add the instances of your actions here
    //  new SetTimer(),
    //  new StartTimer(),
    //  new ResetTimer(),
    //};
    }

    // Optional; Gets called when the user clicks on the "Configure" button in the package manager; If CanConfigure is not set to true, you don't need to add this
    public override void OpenConfigurator()
    {
        // Open your configuration form here
        //using (var configurator = new Configurator())
        //{
        //    configurator.ShowDialog();
        //}
    }

    //public partial class TimerConfigurator : ActionConfigControl
    //{
    //    // Add a variable for the instance of your action to get access to the Configuration etc.
    //    private PluginAction _macroDeckAction;

    //    public TimerConfigurator(PluginAction macroDeckAction, ActionConfigurator actionConfigurator)
    //    {
    //        this._macroDeckAction = macroDeckAction;
    //        InitializeComponent();
    //    }
    //}

    //System.Timers.Timer aTimer = new System.Timers.Timer();
    //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
    //aTimer.Interval = 5000; // ~ 5 seconds
    //aTimer.Enabled = true;
}


internal class ResetTimer : PluginAction
{
    public override string Name => throw new System.NotImplementedException();

    public override string Description => throw new System.NotImplementedException();

    public override void Trigger(string clientId, ActionButton actionButton)
    {
        throw new System.NotImplementedException();
    }
}

internal class StartTimer : PluginAction
{
    public override string Name => throw new System.NotImplementedException();

    public override string Description => throw new System.NotImplementedException();

    public override void Trigger(string clientId, ActionButton actionButton)
    {
        throw new System.NotImplementedException();
    }
}

internal class SetTimer : PluginAction
{
    public override string Name => throw new System.NotImplementedException();

    public override string Description => throw new System.NotImplementedException();

    public override void Trigger(string clientId, ActionButton actionButton)
    {
        throw new System.NotImplementedException();
    }
}

//private static void OnTimedEvent(object source, ElapsedEventArgs e)
//{
//    Console.WriteLine("Hello World!");
//}