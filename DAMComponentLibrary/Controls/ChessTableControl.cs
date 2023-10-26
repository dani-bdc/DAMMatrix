using DAMComponentLibrary.Components;
using DAMComponentLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DAMComponentLibrary.Controls
{
    /// <summary>
    /// Realice los pasos 1a o 1b y luego 2 para usar este control personalizado en un archivo XAML.
    ///
    /// Paso 1a) Usar este control personalizado en un archivo XAML existente en el proyecto actual.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:DAMComponentLibrary.Controls"
    ///
    ///
    /// Paso 1b) Usar este control personalizado en un archivo XAML existente en otro proyecto.
    /// Agregue este atributo XmlNamespace al elemento raíz del archivo de marcado en el que 
    /// se va a utilizar:
    ///
    ///     xmlns:MyNamespace="clr-namespace:DAMComponentLibrary.Controls;assembly=DAMComponentLibrary.Controls"
    ///
    /// Tendrá también que agregar una referencia de proyecto desde el proyecto en el que reside el archivo XAML
    /// hasta este proyecto y recompilar para evitar errores de compilación:
    ///
    ///     Haga clic con el botón secundario del mouse en el proyecto de destino en el Explorador de soluciones y seleccione
    ///     "Agregar referencia"->"Proyectos"->[Busque y seleccione este proyecto]
    ///
    ///
    /// Paso 2)
    /// Prosiga y utilice el control en el archivo XAML.
    ///
    ///     <MyNamespace:ChessTableControl/>
    ///
    /// </summary>
    public class ChessTableControl : TableControl
    {
        /*static ChessTableControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChessTableControl), new FrameworkPropertyMetadata(typeof(ChessTableControl)));
            
        }*/

        public ChessTableControl()
        {
       
            base.Rows = 8; // Use base.Rows because cannot override rows in this control
            base.Cols = 8; // Use base.Cols because cannot override cols in this control

            MatrixCellProperties whiteProps, blackProps;
            Border whiteBorder, blackBorder;

            whiteProps = new MatrixCellProperties();
            whiteBorder = new Border();

            blackProps = new MatrixCellProperties();
            blackBorder = new Border();

            whiteBorder.Background = Brushes.White;
            whiteProps.Border = whiteBorder;
            blackBorder.Background = Brushes.Black;
            blackProps.Border = blackBorder;

            for (var r = 0; r < 8; r++)
            {
                for (var c = 0; c < 8; c++)
                {
                    if ((r + c) % 2 == 1)
                    {
                        this.SetCellProperties(r, c, blackProps);
                    } else
                    {
                        this.SetCellProperties(r, c, whiteProps);
                    }
                }
            }

        }


        public override int Rows
        {
            get => base.Rows; 
            
            set
            {
                throw new PropertyChangeException("Cannot change Rows in control");
            }
        }

        public override int Cols
        {
            get => base.Cols;

            set
            {
                throw new PropertyChangeException("Cannot change Cols in control");
            }
        }
    }
}
