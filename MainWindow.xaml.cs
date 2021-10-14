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

            for(int i = 0; i < 4; i++)
            {
                if(i == 3)
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
                        text.Text = (i * 3) + j + 1 + "";
                    }
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            pantalla.Text += boton.Tag.ToString();
        }
    }
}
