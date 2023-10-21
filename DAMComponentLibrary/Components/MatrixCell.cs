using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DAMComponentLibrary.Components
{
    public class MatrixCell : Grid
    {
        private Label lbl;

        public MatrixCell()
        {
            this.Background = Brushes.Blue;
            Border b = new Border();
            b.BorderThickness = new Thickness(1, 1, 1, 1);
            b.Background = Brushes.Beige;
            lbl = new Label();

            b.Child = lbl;

            this.Children.Add(b);
        }

        public string? Text
        {
            get
            {
                if (lbl.Content != null)
                    return lbl.Content.ToString();
                else
                    return String.Empty;
            }

            set
            {
                lbl.Content = value;
            }
        }
    }
}
