using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CRC_GAWEK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bytes_LostFocus(object sender, RoutedEventArgs e)
        {
            if (bytes.Text.Length > 512)
            {
                bytes.Text = "";
                MessageBox.Show("Maksymalna dlugosc sekwencji to 256 B");
            }
        }

        public uint CRC(byte[] pMessage, long count)
        {
            uint reg16=0xFFFF;

            for (int a = 0; a < count; a++)
            {
                reg16 = 0xFFFF;
                int i;
                int iterator = 0;
                while (pMessage.Length != iterator)
                {
                    reg16 ^= pMessage[iterator++];
                    i = 8;
                    while (i-- > 0)
                    {
                        if ((reg16 & 0x0001) > 0)
                        {
                            reg16 >>= 1;
                            reg16 ^= 0xA001;
                        }
                        else
                        {
                            reg16 >>= 1;
                        }
                    }
                }
            }

            return reg16;
        }

        

        private void start_button_Click(object sender, RoutedEventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(repeat_count.Text, "[^0-9]"))
            {
                MessageBox.Show("Ilosc powtorzen musi byc liczba");
                return;
            }
            else if(!(Int64.Parse(repeat_count.Text)>0&& Int64.Parse(repeat_count.Text)<=Math.Pow(10,9)))
            {
                MessageBox.Show("Ilosc powtorzen musi byc z zakresu 1 - 10^9");
                return;
            }
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                uint result = CRC(StringToByteArray(bytes.Text.ToUpper()),Int64.Parse(repeat_count.Text));
                timer.Stop();
                time.Content = Math.Round(timer.Elapsed.TotalSeconds,5);
                crc_value.Text = "0x" + Convert.ToString(result, 16).ToUpper();
            }
            
            catch
            {
                MessageBox.Show("Podaj wlaściwą sekwencję w zapisie hex");
            }
        }

        public static byte[] StringToByteArray(string hex)
        {
            if(hex.Length%2==1)
                hex=hex.Insert(hex.Length - 1, "0");
            
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
