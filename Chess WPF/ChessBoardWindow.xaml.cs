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
            InitializeBoardGUI();
        }

        private void InitializeBoardGUI()
        {
            string names = "ABCDEFGH";
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Border cell = new()
                    {
                        Background = GetCellBackgroundColor(row, col)
                    };
                    Grid.SetRow(cell, row);
                    Grid.SetColumn(cell, col);
                    cell.BorderBrush = Brushes.Black;
                    cell.BorderThickness = new Thickness(1);

                    if (row == 7 && col == 0)
                    {
                        StackPanel labelContainer = new();

                        Label label1 = new()
                        {
                            Content = 8 - row,
                            HorizontalAlignment = HorizontalAlignment.Left,
                            VerticalAlignment = VerticalAlignment.Top
                        };
                        labelContainer.Children.Add(label1);

                        Label label2 = new()
                        {
                            Content = names[col],
                            HorizontalAlignment = HorizontalAlignment.Right,
                            VerticalAlignment = VerticalAlignment.Bottom
                        };
                        labelContainer.Children.Add(label2);

                        cell.Child = labelContainer;
                    }
                    else if(row == 7) 
                    {
                        Label label = new()
                        {
                            Content = names[col],
                            HorizontalAlignment = HorizontalAlignment.Right,
                            VerticalAlignment = VerticalAlignment.Bottom
                        };
                        cell.Child = label;
                    }
                    else if (col == 0)
                    {
                        Label label = new()
                        {
                            Content = 8 - row,
                            HorizontalAlignment = HorizontalAlignment.Left,
                            VerticalAlignment = VerticalAlignment.Top
                        };
                        cell.Child = label;
                    }
                    chessBoard.Children.Add(cell);
                }
            }
        }

        private static Brush GetCellBackgroundColor(int row, int col)
        {
            if ((row + col) % 2 == 0)
                return Brushes.White;
            else
                return Brushes.RosyBrown;
        }
    }
}
