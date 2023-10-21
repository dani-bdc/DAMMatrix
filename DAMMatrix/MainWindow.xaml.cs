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

namespace DAMMatrix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.mainTable.SetContent(0, 0, "Col 0-0");
            this.mainTable.SetContent(0, 1, "Col 0-1");
            this.mainTable.SetContent(1, 0, "Col 1-0");
        }

        private void btPosition_Click(object sender, RoutedEventArgs e)
        {
            int row = Convert.ToInt32(this.txtRow.Text);
            int col = Convert.ToInt32(this.txtCol.Text);

            try
            {
                this.lbResult.Content = this.mainTable.GetContent(row, col);
            } catch (DAMComponentLibrary.Exceptions.InvalidPositionException ipe)
            {
                MessageBox.Show("Min = " + ipe.MinRow);
                MessageBox.Show(ipe.Message);
            }
        }

        private void mainTable_SelectItemClick(object sender, DAMComponentLibrary.Events.SelectUIElementEventArgs e)
        {
            MessageBox.Show("Main table click at position(" + e.Row + "," + e.Col + ")");
        }
    }
}
