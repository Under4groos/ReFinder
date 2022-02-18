using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UIReFinder.Controls
{
    public class MCLine : StackPanel
    {
        public string Content
        {
            get;set;
        }
        public MCLine()
        {
             this.Orientation = Orientation.Horizontal;
        }
        public void AddText(string str , Color color)
        {
            // = Color.FromRgb(255,255,255)
            LBorder lBorder = new LBorder();
            Content += lBorder.Content =  str;
            lBorder.FontBush = Brushes.White;
            lBorder.FontBush = new System.Windows.Media.SolidColorBrush(color);
            lBorder.HorizontalAlignment = HorizontalAlignment.Left;


            //if (str == string.Empty)
            //    return;

            Add(lBorder);
        }
        private void Add(LBorder uelem )
        {   

            this.Children.Add( uelem );
            
        }
        public bool Valid()
        {
            return Content.Length != 0;
        }
    }
}
