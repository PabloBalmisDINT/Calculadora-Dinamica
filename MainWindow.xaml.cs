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

namespace Calculadora_Dinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 2; i <= 5; i++)
            {
                // Si i es igual a 5 significa que esta en la ultima fila, la del 0
                if(i == 5)
                {
                    Button boton = new Button();
                    FondoGrid.Children.Add(boton);
                    Grid.SetColumn(boton, 0);
                    Grid.SetRow(boton, i);
                    Viewbox viewbox = new Viewbox();
                    boton.Content = viewbox;
                    TextBlock text = new TextBlock();
                    viewbox.Child = text;
                    text.Text = "0";
                    Grid.SetColumnSpan(boton, 3);
                    boton.Tag = "0";
                    boton.Click += Boton_Click;
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Button boton = new Button();
                        FondoGrid.Children.Add(boton);
                        Grid.SetColumn(boton, j);
                        Grid.SetRow(boton, i);
                        Viewbox viewbox = new Viewbox();
                        boton.Content = viewbox;
                        TextBlock text = new TextBlock();
                        viewbox.Child = text;
                        /*Para sacar el numero uso i -2 porque empieza el contador en dos,
                         * lo multiplico por 3 ya que j ha hecho 3 iterecaiones 
                         * y como empizar en 0 le sumo 1 para que de el numero*/
                        text.Text = ((i-2) * 3) + j + 1 + "";
                        boton.Tag = ((i - 2) * 3) + j + 1 + "";
                        boton.Click += Boton_Click;
                    }
                }
                
            }
        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            pantalla.Text += boton.Tag.ToString();
        }
    }
}
