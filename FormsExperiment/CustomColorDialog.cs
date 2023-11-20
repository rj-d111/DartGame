using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExperiment
{
    public class CustomColorDialog : ColorDialog
    {
        private ColorDialog colorDialog;
        private List<Color> allowedColors;

        public CustomColorDialog(List<Color> allowedColors)
        {
            this.allowedColors = allowedColors;

            colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
        }

        public Color SelectedColor
        {
            get
            {
                return colorDialog.Color;
            }
        }

        public void OnLoad(EventArgs e)
        {
            // Filter the color dialog's custom colors to only show the allowed colors
            colorDialog.CustomColors = allowedColors.Select(x => x.ToArgb()).ToArray();
        }
    }
}
