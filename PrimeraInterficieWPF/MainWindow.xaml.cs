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

namespace PrimeraInterficieWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            this.Content = grid;

            Button btn = new Button();

            btn.Click += Btn_Click;
            //grid.Children.Add(btn);

            WrapPanel wrapPanel = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "hola ";
            txt1.Background = Brushes.Green;

            wrapPanel.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "adeu ";
            txt2.Background = Brushes.Cyan;
            wrapPanel.Children.Add(txt2);

            TextBlock txt3  = new TextBlock();
            txt3.Text = "buenas ";
            txt3.Background = Brushes.Red;
            wrapPanel.Children.Add(txt3);
            btn.Height = 250;
            btn.Width = 150;
            btn.Content = wrapPanel;


            grid.Children.Add(btn);
            



          


        }
          private void Btn_Click (object sender, RoutedEventArgs e)
        {
            if(this.Background == Brushes.Red)
            {
                this.Background= Brushes.White;
            }
            else {this.Background = Brushes.Red; }       

        }

    }
}
