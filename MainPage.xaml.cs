using Microsoft.Maui.Maps;

namespace PAMII_Maps
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            //Inicialização do Mapa

            var location = new Location(-23.519239365505662, -46.59681073469161);
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
            
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
    }

}
