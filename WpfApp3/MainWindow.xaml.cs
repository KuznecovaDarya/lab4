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

namespace WpfApp3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fio = FIO.Text;
            string data = Data.Text;
            string tel = Tel.Text;
            string mail = Mail.Text;

            string[] slova = fio.Split(' ');
            if (slova.Length == 2 || slova.Length == 3)
            {
                for (int i = 0; i < slova.Length; i++)
                {
                    string bukva = Convert.ToString(slova[i][0]);
                    if (bukva == bukva.ToUpper())
                    {
                        FIO.Clear();
                        FIO_Copy.Text = fio;
                    }
                    else
                    {
                        MessageBox.Show("Некорректно введено ФИО!");
                        FIO.Clear();
                        FIO_Copy.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Некорректно введено ФИО!");
                FIO.Clear();
                FIO_Copy.Clear();
            }


            int kol = 0;
            string cifri = "0123456789";
            if ("+".CompareTo(Convert.ToString(tel[0])) == 0)
            {
                for (int i = 1; i < tel.Length; i++)
                {
                    for (int j = 0; j < cifri.Length; j++)
                    {
                        if (tel[i] == cifri[j])
                        {
                            kol++;
                        }
                    }
                }
                if (kol == 11)
                {
                    Tel.Clear();
                    Tel_Copy.Text = tel;
                }
                else
                {
                    MessageBox.Show("Некорректно введен номер телефона!");
                    Tel.Clear();
                    Tel_Copy.Clear();
                }
            }
            else
            {
                for (int i = 0; i < tel.Length; i++)
                {
                    for (int j = 0; j < cifri.Length; j++)
                    {
                        if (tel[i] == cifri[j])
                        {
                            kol++;
                        }
                    }
                }
                if (kol == 11)
                {
                    Tel.Clear();
                    Tel_Copy.Text = tel;
                }
                else
                {
                    MessageBox.Show("Некорректно введен номер телефона!");
                    Tel.Clear();
                    Tel_Copy.Clear();
                }
            }


            int oshib = 0;
            string[] chisla = data.Split('.');
            for (int g = 0; g < chisla.Length; g++)
            {
                for (int i = 0; i < chisla[g].Length; i++)
                {
                    if (Convert.ToChar(chisla[g][i]) < 48 || 57 < Convert.ToChar(chisla[g][i]))
                    {
                        oshib++;
                    }
                }
            }
            if (oshib == 0)
            {
                if (Convert.ToInt32(chisla[0]) < 1 || Convert.ToInt32(chisla[0]) > 31)
                {
                    MessageBox.Show("Некорректно введена дата рождения");
                    Data.Clear();
                    Data_Copy.Clear();
                }
                else if (Convert.ToInt32(chisla[1]) < 1 || Convert.ToInt32(chisla[1]) > 12)
                {
                    MessageBox.Show("Некорректно введена дата рождения");
                    Data.Clear();
                    Data_Copy.Clear();
                }
                else if (Convert.ToInt32(chisla[2]) < 1 || Convert.ToInt32(chisla[2]) > 2021)
                {
                    MessageBox.Show("Некорректно введена дата рождения");
                    Data.Clear();
                    Data_Copy.Clear();
                }
                else
                {
                    Data.Clear();
                    Data_Copy.Text = data;
                }
            }
            else
            {
                MessageBox.Show("Некорректно введена дата рождения");
                Data.Clear();
                Data_Copy.Clear();
            }



            string[] chast = mail.Split('@');
            string[] toch = chast[chast.Length - 1].Split('.');
            if (chast.Length != 2)
            {
                MessageBox.Show("Некорректно введен e-mail!");
                Mail.Clear();
                Mail_Copy.Clear();
            }
            else if (chast[0].Length < 1 || chast[1].Length < 1)
            {
                MessageBox.Show("Некорректно введен e-mail!");
                Mail.Clear();
                Mail_Copy.Clear();
            }
            else if (toch.Length != 2)
            {
                MessageBox.Show("Некорректно введен e-mail!");
                Mail.Clear();
                Mail_Copy.Clear();
            }
            else if (toch[0].Length < 1 || toch[1].Length < 1)
            {
                MessageBox.Show("Некорректно введен e-mail!");
                Mail.Clear();
                Mail_Copy.Clear();
            }
            else
            {
                for (int g = 0; g < chast.Length; g++)
                {
                    for (int i = 0; i < chast[g].Length; i++)
                    {
                        if (((Convert.ToChar(chast[g][i]) < 97 || 122 < Convert.ToChar(chast[g][i])) && (Convert.ToChar(chast[g][i]) < 48 || 57 < Convert.ToChar(chast[g][i]))) && chast[g][i] + "" != ".")
                        {
                            MessageBox.Show("Некорректно введен e-mail!");
                            Mail.Clear();
                            Mail_Copy.Clear();
                            break;
                        }
                        else if (i == 0 && chast[g][i] + "" == ".")
                        {
                            MessageBox.Show("Некорректно введен e-mail!");
                            Mail.Clear();
                            Mail_Copy.Clear();
                            break;
                        }
                        else if (i == chast[g].Length - 1 && chast[g][i] + "" == ".")
                        {
                            MessageBox.Show("Некорректно введен e-mail!");
                            Mail.Clear();
                            Mail_Copy.Clear();
                            break;
                        }
                        else
                        {
                            Mail.Clear();
                            Mail_Copy.Text = mail;
                        }

                    }
                }
            }
        }
    }
}
