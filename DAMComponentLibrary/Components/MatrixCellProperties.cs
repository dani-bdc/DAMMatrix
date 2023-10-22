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
    public class MatrixCellProperties
    {
        private Border border;

        public MatrixCellProperties()
        {
            border = new Border();
            border.BorderThickness = new Thickness(1, 1, 1, 1);
            border.Background = Brushes.Gray;
        }

        public Brush Background { get; set; } = Brushes.Black;
        public Border Border { 
            
            get
            {
                return border;
            }
            set
            {
                border = value;

            }
        } 
    }
}
