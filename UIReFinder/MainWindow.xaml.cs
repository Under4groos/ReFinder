using LibReFinder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using UIReFinder.Controls;

namespace UIReFinder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> files = new List<string>();
        string path_folder_ = "";
        string pattern = "";
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (o, e) =>
            {
                new WinDragMove(this, this);
                new WinResize(this).RightDown(resizeborder);
                new WBControl(this, bclose, ACTIONS.CLOSE);
                new WBControl(this, bmax, ACTIONS.SIZE_max);
                new WBControl(this, bmin, ACTIONS.SIZE_min);
                //new WindowBlureffect(this, WindowBlureffect.AccentState.ACCENT_ENABLE_BLURBEHIND);
                TitleWindow.Content = this.Title;
            };
        }
        void find_dif(string folder)
        {
            if (!Directory.Exists(folder))
                return;

            try
            {
                Regex.IsMatch("", pattern);
            }
            catch (Exception)
            {

                return;
            }

            foreach (string item in Directory.GetFiles(folder))
            {
                if (Regex.IsMatch(item, pattern))
                {
                    files.Add(item);
                }
            }
            foreach (string Directorie in Directory.GetDirectories(folder))
            {
                //files.Add(Directorie);
                find_dif(Directorie);
            }
        }
        private void button_find(object sender, MouseButtonEventArgs e)
        {
            listbox_items.Items.Clear();
            files.Clear();

            path_folder_ = path.Text;
            pattern = regex.Text;

            find_dif(path_folder_);


            List<int> list;


            //Console.WriteLine(files.Count);
            foreach (string file_path in files)
            {
                MCLine mCLine = new MCLine();
                list = new List<int>()
                {
                    0
                };
                if (Directory.Exists(file_path))
                {
                    mCLine.AddText("[Dir]: ", Color.FromRgb(3, 252, 132));
                }
                else
                {
                    mCLine.AddText("[File]: ", Color.FromRgb(144, 3, 252));

                }
                string[] array_ = RegEx.GetValuesToArray(file_path, pattern).ToArray();

                Console.WriteLine(string.Join("-" , array_));

                List<InString> inStrings = file_path.FindIndex(array_.ToArray());

                foreach (var item in inStrings)
                {
                    list.Add(item.start);
                    list.Add(item.end);
                }
                list.Add(file_path.Length);

                Console.WriteLine(string.Join("-", file_path));
                foreach (string item in file_path.StringSplitMulti(list.ToArray()))
                {

                    

                    if (array_.ToArray().HasValue(item))
                    {
                        mCLine.AddText(item, Color.FromRgb(255, 0, 0));
                    }
                    else
                    {
                        mCLine.AddText(item, Color.FromRgb(255, 255, 255));
                    }

                    
                }
                //if(mCLine.Valid())
                    listbox_items.Items.Add(mCLine);

            }







            //foreach (string item in list)
            //{
            //    MCLine mCLine = new MCLine();


            //    mCLine.AddText(item, Color.FromRgb(255, 255, 255));

            //    listbox_items.Items.Add(mCLine);
            //}


            //foreach (string item in list)
            //{
            //    System.Windows.Controls.Label label = new System.Windows.Controls.Label()
            //    {
            //        Content = item,
            //        Foreground = Brushes.White,

            //    };
            //    listbox_items.Items.Add(label);
            //}
        }
    }
}
