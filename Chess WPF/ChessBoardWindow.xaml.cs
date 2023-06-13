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
using System.Windows.Shapes;

namespace Chess_WPF
{
    /// <summary>
    /// Interaction logic for ChessBoardWindow.xaml
    /// </summary>
    public partial class ChessBoardWindow : Window
    {
        public ChessBoardWindow()
        {
            InitializeComponent();
            initializeBoard();
        }

        private void initializeBoard()
        {
            string names = "ABCDEFGH";
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Border cell = new Border();
                    cell.Background = GetCellBackgroundColor(row, col);
                    Grid.SetRow(cell, row);
                    Grid.SetColumn(cell, col);
                    cell.BorderBrush = Brushes.Black;
                    cell.BorderThickness = new Thickness(1);

                    if (row == 7 && col == 0)
                    {
                        StackPanel labelContainer = new StackPanel();

                        Label label1 = new Label();
                        label1.Content = 8 - row;
                        label1.HorizontalAlignment = HorizontalAlignment.Left;
                        label1.VerticalAlignment = VerticalAlignment.Top;
                        labelContainer.Children.Add(label1);

                        Label label2 = new Label();
                        label2.Content = names[col];
                        label2.HorizontalAlignment = HorizontalAlignment.Right;
                        label2.VerticalAlignment = VerticalAlignment.Bottom;
                        labelContainer.Children.Add(label2);

                        cell.Child = labelContainer;
                    }
                    else if(row == 7) 
                    {
                        Label label = new Label();
                        label.Content = names[col];
                        label.HorizontalAlignment = HorizontalAlignment.Right;
                        label.VerticalAlignment = VerticalAlignment.Bottom;
                        cell.Child = label;
                    }
                    else if (col == 0)
                    {
                        Label label = new Label();
                        label.Content = 8 - row;
                        label.HorizontalAlignment = HorizontalAlignment.Left;
                        label.VerticalAlignment = VerticalAlignment.Top;
                        cell.Child = label;
                    }
                    chessBoard.Children.Add(cell);
                }
            }
        }

        private Brush GetCellBackgroundColor(int row, int col)
        {
            if ((row + col) % 2 == 0)
                return Brushes.White;
            else
                return Brushes.RosyBrown;
        }
    }
}
