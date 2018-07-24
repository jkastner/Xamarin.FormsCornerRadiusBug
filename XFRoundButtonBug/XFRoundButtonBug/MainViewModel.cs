using System;
using System.Collections.Generic;
using System.Text;

namespace XFRoundButtonBug
{

    using Xamarin.Forms;
    class MainViewModel : BindableObject
    {
        private int theButtonCornerRadius = 25;
        public int TheButtonCornerRadius
        {
            get => this.theButtonCornerRadius;
            set
            {
                if (this.theButtonCornerRadius != value)
                {
                    this.theButtonCornerRadius = value;
                    this.OnPropertyChanged();
                }
            }
        }


    }
}
