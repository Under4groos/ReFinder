 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace UIReFinder.Controls
{
    public class CTextBox : TextBox
    {
        
        public Action<string> TTextChanged;
  
        public CTextBox()
        {
            this.BorderBrush = null;
            this.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Left;
            this.VerticalContentAlignment = System.Windows.VerticalAlignment.Center;
            this.Foreground = Brushes.White;
            this.Background = null;
            this.FontSize = 15;
            
            this.Margin = new System.Windows.Thickness(0);
            this.TextChanged += (o, e) =>
            {
                if(TTextChanged != null)
                    TTextChanged(this.Text);
            };
            this.MouseLeave += (o, e) =>
            {
                //Keyboard.ClearFocus();
            };
        }
    }
}
