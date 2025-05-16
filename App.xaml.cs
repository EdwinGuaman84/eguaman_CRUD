using eguaman_CRUD.Data;

namespace eguaman_CRUD
{
    public partial class App : Application
    {
        public static Data.PersonRepository personRepo { get; set; }
        public App(Data.PersonRepository personRepository)
        {
            InitializeComponent();
            personRepo = personRepository;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Views.vHome());
        }
    }
}