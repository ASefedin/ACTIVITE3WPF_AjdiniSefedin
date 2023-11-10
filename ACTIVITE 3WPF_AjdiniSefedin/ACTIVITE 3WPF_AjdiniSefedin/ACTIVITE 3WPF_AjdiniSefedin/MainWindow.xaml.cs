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

namespace ACTIVITE_3WPF_AjdiniSefedin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            txtA.PreviewTextInput += new TextCompositionEventHandler(TextBlock_TextInput);
            txtB.PreviewTextInput += new TextCompositionEventHandler(TextBlock_TextInput);
            txtC.PreviewTextInput += new TextCompositionEventHandler(TextBlock_TextInput);
            btnCalculer.Click += new RoutedEventHandler(Button_Click);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            double c;
            double x1 = 0;
            double x2 = 0;
            string message;
            if (double.TryParse(txtA.Text, out a) && double.TryParse(txtB.Text, out b) && double.TryParse(txtC.Text, out c))
            {
                MethodesDuProjet MesOutils = new MethodesDuProjet();
                MesOutils.ResoudTrinome(a, b, c, out x1, out x2, out message);
                SecondePage SecondePageOutil = new SecondePage();
                SecondePageOutil.LblResultat.Text = message;
                SecondePageOutil.Show();
            }
        }
        private void TextBlock_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }
    }
}
