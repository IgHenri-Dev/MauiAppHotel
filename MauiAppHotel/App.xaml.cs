using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Presidencial",
                ValorDiariaAdulto = 180.0,
                ValorDiariaCrianca = 90.0
            },
            new Quarto()
            {
                Descricao = "Suíte Master",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 60.0
            },
            new Quarto()
            {
                Descricao = "Suíte Casal",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Econômica",
                ValorDiariaAdulto = 45.0,
                ValorDiariaCrianca = 22.5
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
    }
}