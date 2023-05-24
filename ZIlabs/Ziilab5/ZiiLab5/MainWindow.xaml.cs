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
using System.Numerics;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;

namespace ZiiLab5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                
        private BigInteger EulerFunction(BigInteger p, BigInteger q)
        {
            return ((p - 1) * (q - 1));
        }

        public static BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        static (BigInteger, BigInteger, BigInteger) gcdex(BigInteger a, BigInteger b)
        {
            if (a == 0)
                return (b, 0, 1);
            (BigInteger gcd, BigInteger x, BigInteger y) = gcdex(b % a, a);
            return (gcd, y - (b / a) * x, x);
        }

        static BigInteger invmod(BigInteger a, BigInteger m)
        {
            (BigInteger g, BigInteger x, BigInteger y) = gcdex(a, m);
            return g > 1 ? 0 : (x % m + m) % m;
        }

        private BigInteger FindE(BigInteger n)
        {
            BigInteger e = RandomBI.RandomBi(2, n);

            while (true)
            {
                if (Gcd(e, n) == 1)
                {
                    return e;
                }
                else
                {
                    e = RandomBI.RandomBi(2, n);
                }
            }
        }

        private BigInteger FindD(BigInteger e, BigInteger n)
        {
            BigInteger d = invmod(e, n);
            return d;
        }

        private List<string> RSA_Encode(string s, BigInteger e, BigInteger n)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                BigInteger index = s[i];

                BigInteger bi = BigInteger.ModPow(index, e, n);
                result.Add(bi.ToString());
                result.Add(" ");
            }
            return result;
        }

        private List<string> RSA_Decode(string input, BigInteger d, BigInteger n)
        {
            List<string> result = new List<string>();
            string[] values = input.ToString().Split(' ');
            foreach (string item in values)
            {
                BigInteger bi;
                if (BigInteger.TryParse(item, out bi))
                {
                    bi = BigInteger.ModPow(bi, d, n);
                    result.Add(((char)bi).ToString());
                }
            }
            return result;
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void SourceFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                SourceFileText.Text = ofd.FileName;
            }
        }

        private void SignFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                SignFileText.Text = ofd.FileName;
            }
        }

        private void SignBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((textP.Text.Length > 0) && (textQ.Text.Length > 0) && (SourceFileText.Text.Length > 0) && (SignFileText.Text.Length > 0))
            {
                BigInteger p = BigInteger.Parse(textP.Text);
                BigInteger q = BigInteger.Parse(textQ.Text);

                if (MillerRabinTest.MillerRabin(p, 50) || MillerRabinTest.MillerRabin(q, 50))
                {                  
                    BigInteger mod = BigInteger.Multiply(p, q);
                    BigInteger n = EulerFunction(p, q);
                    BigInteger _e = FindE(n);
                    BigInteger d = FindD(_e, n);

                    string hashfile = File.ReadAllText(SourceFileText.Text).GetHashCode().ToString();
                    List<String> result = RSA_Encode(hashfile, _e, mod);

                    using (TextWriter tw = new StreamWriter(SignFileText.Text))
                    {
                        foreach (String s in result)
                            tw.Write(s);
                    }

                    textD.Text = d.ToString();
                    textN.Text = mod.ToString();

                    Process.Start(SignFileText.Text);
                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q и пути к файлам!");
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((textD.Text.Length > 0) && (textN.Text.Length > 0) && (SourceFileText.Text.Length > 0) && (SignFileText.Text.Length > 0))
            {
                BigInteger d = BigInteger.Parse(textD.Text);
                BigInteger n = BigInteger.Parse(textN.Text);

                string message = "";
                string ss = "";

                using (StreamReader sr = new StreamReader(SignFileText.Text))
                {
                    message = sr.ReadToEnd();
                }

                List<string> result = RSA_Decode(message, d, n);
                foreach(String s in result)
                {
                    ss += s;
                }


                string hash = File.ReadAllText(SourceFileText.Text).GetHashCode().ToString();

                if (hash.Equals(ss))
                    MessageBox.Show("Файл подлинный. Подпись верна.");
                else
                    MessageBox.Show("Файл был изменен");
            }
            else
                MessageBox.Show("Введите секретный ключ и пути к файлам!");
        }
    }
}
