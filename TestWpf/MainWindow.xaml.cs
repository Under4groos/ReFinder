using LibReFinder;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace TestWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();

            gridd.MouseDown += (o, e) =>
            {
                update();
            };


            


        }
        void update()
        {
            gridd.Children.Clear();
            string str_ = "This function is very inefficient for large tables (O(n)) and should probably not be called in things that run each frame. Instead, consider a table structure such as example 2 below. Also see: Tables: Bad Habits";
            List<int> list = new List<int>()
            {
                0
            };

            string[] find_str_ = {  "t" };

            List<InString> inStrings = str_.FindIndex(find_str_);

            foreach (var item in inStrings)
            {
                list.Add(item.start);
                list.Add(item.end);



            }

            foreach (var item in str_.StringSplitMulti(list.ToArray()))
            {
                LBorder lBorder = new LBorder();
                lBorder.Content = item;
                lBorder.FontBush = Brushes.White;
                lBorder.HorizontalAlignment = HorizontalAlignment.Left;
                if (find_str_.HasValue(item))
                {
                    byte randpm_ = (byte)random.Next(100, 255);
                    lBorder.FontBush = new System.Windows.Media.SolidColorBrush(
                        Color.FromRgb(randpm_, randpm_, randpm_));
                }
                else
                {
                    lBorder.FontBush = new System.Windows.Media.SolidColorBrush(
                        Color.FromRgb((byte)255, 0, 0));
                }
 
                gridd.Children.Add(lBorder);
            }
        }
    }
}
