using System;
using System.Collections.Generic;
using System.Linq;
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

namespace zil1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in MainWin.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        string Encrypt(string text, Dictionary<char, Queue<int>> dict)
        {
            var sb = new StringBuilder();
            foreach (var s in text)
            {
                if (dict.ContainsKey(s))
                {
                    var number = dict[s].Dequeue();
                    dict[s].Enqueue(number);
                    sb.Append(string.Format("{0:D3}", number));
                }
                else
                    sb.Append(s);
            }
            return sb.ToString();
        }

        string Decrypt(string text, Dictionary<char, Queue<int>> dict)
        {
            int number = 0;
            var sb = new StringBuilder();
            int i = 0;
                while (i < text.Length)
                {
                    if (char.IsDigit(text[i]))
                    {
                        if (char.IsDigit(text[i + 1]))
                        {
                            if (char.IsDigit(text[i + 2]))
                            {
                                if (text.Length - i < 3)
                                {

                                    break;
                                }
                                number = int.Parse(text.Substring(i, 3));
                                i += 3;
                                foreach (var kvp in dict)
                                {
                                    if (kvp.Value.Contains(number))
                                    {
                                        sb.Append(kvp.Key);
                                        kvp.Value.Dequeue();
                                        kvp.Value.Enqueue(number);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        sb.Append(text[i]);
                        i++;
                    }
                }        
            return sb.ToString();
        }


        private Dictionary<char, Queue<int>> GenerateDictionary(char[] symbols)
        {
            var dict = new Dictionary<char, Queue<int>>();
            for (int i = 1; i <= 999; i++)
            {
                var symb = symbols[i % symbols.Length];
                if (!dict.ContainsKey(symb)) dict.Add(symb, new Queue<int>());
                dict[symb].Enqueue(i);
            }
            return dict;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            char[] symbols = "абвгдеёжзийклмнопрстуфхцчшщьыъэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ!,.?:1234567890".ToCharArray();
            var dict = GenerateDictionary(symbols);
             
            if (str == "ЗАШИФРОВАТЬ")
            {
                output.Text = Encrypt(input.Text, dict);
            }
            else if (str == "ДЕШИФРОВАТЬ")
            {
                decrypttext.Text = Decrypt(output.Text, dict);
            }
        }

    }
}
