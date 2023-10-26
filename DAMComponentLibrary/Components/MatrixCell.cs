using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;

namespace DAMComponentLibrary.Components
{
    public class MatrixCell : Grid
    {
        private Label lbl;
        private Border border;
        private MatrixCellProperties props;

        public MatrixCell()
        {
            props = new MatrixCellProperties();
            this.border = new Border();
            this.lbl = new Label();

            this.RepaintObject();
            
        }

        public MatrixCellProperties Properties
        {
            get
            {
                return this.props;
            }
            set
            {
                this.props = value;
                this.RepaintObject();
            }
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

        protected void RepaintObject()
        {
            this.Background = props.Background;
            var str = XamlWriter.Save(props.Border);
            this.border = (Border)XamlReader.Load(XmlReader.Create(new StringReader(str)));

            if (this.lbl.Parent == null)
            {
                this.border.Child = lbl;
            } else
            {
                ((Decorator)this.lbl.Parent).Child = null;
                this.border.Child = lbl;
            }

            this.Children.Add(this.border);
        }
    }
}
