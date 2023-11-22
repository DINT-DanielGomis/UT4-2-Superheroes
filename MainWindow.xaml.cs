using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UT4_2_Superheroes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    
    public partial class MainWindow : Window
    {
        private List<Superheroe> listaSuper;
        private int indiceActual;
        private int indiceFinal;
        public MainWindow()
        {
            InitializeComponent();

            

            listaSuper=Superheroe.GetSamples();

            panelPrincipal.DataContext = listaSuper;
            indiceActual = listaSuper;
            indiceFinal = listaSuper.Count;
            CambiarHeroeActual();



        }
        private void Flecha_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            indiceActual = (indiceActual - 1 + listaSuper.Count) % listaSuper.Count;
            CambiarHeroeActual();
        }
        private void rightImage_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            indiceActual = (indiceActual + 1) % listaSuper.Count;
            CambiarHeroeActual();
        }
        private void CambiarHeroeActual()
        {
            panelPrincipal.DataContext = listaSuper[indiceActual];



        }
    }

}
