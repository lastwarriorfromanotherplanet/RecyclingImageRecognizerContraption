using RecyclingImageRecognizerContraption.Resources.DatabaseService;
namespace RecyclingImageRecognizerContraption;


public partial class App : Application
{
    public static LaPorteService? LaPorteService { get; private set; }
    
    public App(LaPorteService laPorteService)
    {
        InitializeComponent();

        LaPorteService = laPorteService;
    }
    

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage()) { Title = "RecyclingImageRecognizerContraption" };
    }
}
