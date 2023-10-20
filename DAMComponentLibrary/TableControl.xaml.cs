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

namespace DAMComponentLibrary
{
    /// <summary>
    /// Interaction logic for TableControl.xaml
    /// </summary>
    public partial class TableControl : UserControl
    {
        
        private int _rows = 2;
        private int _cols = 2;
        public TableControl()
        {
            InitializeComponent();
            InitTable();
        }

        private void InitTable()
        {
            mainGrid.ColumnDefinitions.Clear();
            mainGrid.RowDefinitions.Clear();
            mainGrid.Children.Clear();

            for (int c = 0; c < Cols; c++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int r = 0; r < Rows; r++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int c = 0; c < Cols; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    Label l = new Label();                   
                    l.Content = "Lbl(" + r + "," + c + ")";
                    
                    Grid.SetRow(l, r);
                    Grid.SetColumn(l, c);

                    mainGrid.Children.Add(l);
                }
            }
        
        }

        public int Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                _rows = value;
                InitTable();
            }
        } 

        public int Cols
        {
            get
            {
                return _cols;
            }
            set
            {
                _cols = value;
                InitTable();
            }
        }
    }
}
