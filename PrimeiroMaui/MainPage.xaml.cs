

namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {
        double n = -1;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double na = Convert.ToDouble(txt_na.Text);
            double nb = Convert.ToDouble(txt_nb.Text);
            double nc = Convert.ToDouble(txt_nc.Text);

            //double delta = (nb * nb) - (4 * na * nc);
            

            double resbdoisdel = nb * nb;
            double resmultidel = 4 * na * nc;
            double resdelta = resbdoisdel - resmultidel;

            if (resdelta < 0)
            {
                string msg1 = $"Sem resultados reais";
                DisplayAlert("Maui", msg1, "Fechar");


            }
            else
            {
                //string msg1 = $"Destla é {delta}";

                //DisplayAlert("Maui", msg1, "Fechar");


                double paradivisao = 2 * na;
                double bnegat = nb * n;

                double resraiz = Math.Sqrt(resdelta);

                //double x1 = -((nb) + resraiz) / (2 * na);
                //double x2 = -((nb) - resraiz) / (2 * na);

                double resfimum = (resraiz + bnegat) / paradivisao;
                double resfimdois = (resraiz - bnegat) / paradivisao;

                string msg = $"Delta = {resdelta}  x' = {resfimum} e x'' = {resfimdois}";

                //string msg = "O resultado é: " + resfimum + " e " + resfimdois;

                DisplayAlert("Maui", msg, "Fechar");
            }


        }
    }

}
