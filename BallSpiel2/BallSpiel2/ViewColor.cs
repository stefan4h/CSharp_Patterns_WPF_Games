using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BallSpiel2
{
    class ViewColor
    {
        Form selectedForm;
        SolidColorBrush actColor;

        public SolidColorBrush ActColor
        {
            get
            {
                return actColor;
            }

            set
            {
                actColor = value;
            }
        }

        public ViewColor(Form selectedForm, SolidColorBrush actColor)
        {
            this.selectedForm = selectedForm;
            this.ActColor = actColor;
        }
        public bool Selected(Form objects)
        {
            if(selectedForm!=null)
            if (Object.ReferenceEquals(selectedForm.GetType(), objects.GetType()))
                return true;
            return false;
        }
        public SolidColorBrush SetColor(Form objects)
        {
                if (Object.ReferenceEquals(selectedForm.GetType(), objects.GetType()))
                    return actColor;
            return objects.Color;
        }
    }
}
