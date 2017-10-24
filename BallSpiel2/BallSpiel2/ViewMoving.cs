using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallSpiel2
{
    class ViewMoving
    {
        string contentButton;
        Form selectedForm;

        public string ContentButton
        {
            get
            {
                return contentButton;
            }

            set
            {
                contentButton = value;
            }
        }

        internal Form SelectedForm
        {
            get
            {
                return selectedForm;
            }

            set
            {
                selectedForm = value;
            }
        }

        public ViewMoving(string contBtn, Form seleFor)
        {
            contentButton = ChangeContent(contBtn);
            SelectedForm = seleFor;
            SelectedForm.BoolMoving = ChangeMoving(seleFor);
        }
        public ViewMoving(Form seleFor)
        {
            SelectedForm = seleFor;
            contentButton = GetContent(SelectedForm);
        }
        private string GetContent(Form seleFor)
        {
            if (SelectedForm.BoolMoving)
                return "Stop";
            return "Start";
        }
        private string ChangeContent(string firstCont)
        {
            if (firstCont == "Start")
                return "Stop";
            return "Start";
        }
        private bool ChangeMoving(Form seleFor)
        {
            if (seleFor.BoolMoving)
                return false;
            return true;
        }
        public bool MoveObject(Form objects)
        {
            if (!Object.ReferenceEquals(SelectedForm.GetType(), objects.GetType()))
                return false;
            if (!objects.BoolMoving)
                return false;
         return true;
        }
        public bool GetBoolObjectMoving(Form objects)
        {
            if (Object.ReferenceEquals(SelectedForm.GetType(), objects.GetType()))
                if (objects.BoolMoving)
                    return true;
                else
                    return false;
            return objects.BoolMoving;
        }
        public bool Selected(Form objects)
        {
            if (Object.ReferenceEquals(SelectedForm.GetType(), objects.GetType()))
                return true;
            return false;
        }
        
    }
    
}
