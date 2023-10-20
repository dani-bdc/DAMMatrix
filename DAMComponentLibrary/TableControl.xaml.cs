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
        
        private int _rows = 2; // Grid default rowsCount
        private int _cols = 2; // Grid default colsCount
        public TableControl()
        {
            InitializeComponent();
            InitTable();
        }

        #region Public Properties

        // Rows Property
        // Gets or sets grid of rows in grid
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

        // Cols property
        // Gets or sets number of cols in grid
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
        #endregion

        #region Public Methods

        public void SetContent(int row, int col, string text)
        {
            Label l = new Label();
            l.Content = text;

            // Put element in the correct position
            Grid.SetRow(l, row);
            Grid.SetColumn(l, col);

            // Put element inside the main grid
            mainGrid.Children.Add(l);
        }

        public string? GetContent(int row, int col)
        {
            string content = string.Empty;
            Exceptions.InvalidPositionException ipe;
            
            if ((row< 0) || (row >=Rows))
            {
                ipe = new Exceptions.InvalidPositionException("Incorrect row");
                ipe.MinRow = 0;
                ipe.MaxRow = this.Rows - 1; ;

                throw ipe;
            }

            var obj = this.mainGrid.Children.Cast<Label>().First(e => Grid.GetRow(e) == row && Grid.GetColumn(e) == col);

            if (obj.Content.ToString() != null)
                return obj.Content.ToString();
            else
                return content;
        }

        #endregion

        #region Private properties
        // Init and redraw de table/matrix
        private void InitTable()
        {
           
            // Clear any existing definition or children
            mainGrid.ColumnDefinitions.Clear();
            mainGrid.RowDefinitions.Clear();
            mainGrid.Children.Clear();

            // Define columns 
            for (int c = 0; c < Cols; c++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            // Define rows
            for (int r = 0; r < Rows; r++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }

            // Draw grid 
            for (int c = 0; c < Cols; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    
                }
            }
        
        }

        #endregion
    }
}
