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

namespace FastFood
{
    public partial class UbahPesan : UserControl
    {
        //declare object class controller
        Controller.Pelanggan pelanggan;

        public UbahPesan()
        {
            InitializeComponent();

            //instance
            pelanggan = new Controller.Pelanggan(this);

            //show data pesanan
            //show data
            txtId.Text = DaftarPesan.id_pelanggan;
            txtNama.Text = DaftarPesan.nama;
            txtTotal.Text = DaftarPesan.total;

        }

        decimal calzone;
        decimal chicago;
        decimal greek;
        decimal total;


        int a = 0;
        private void btnCalzone2_Click(object sender, RoutedEventArgs e)
        {
            a++;
            txtCalzone.Text = a.ToString();
        }

        private void btnCalzone1_Click(object sender, RoutedEventArgs e)
        {
            a--;
            if (a <= 0)
            {
                a = 0;
            }
            txtCalzone.Text = a.ToString();
        }

        int b = 0;
        private void btnChicago2_Click(object sender, RoutedEventArgs e)
        {
            b++;
            txtChicago.Text = b.ToString();
        }

        private void btnChicago1_Click(object sender, RoutedEventArgs e)
        {
            b--;
            if (b <= 0)
            {
                b = 0;
            }
            txtChicago.Text = b.ToString();
        }

        int c = 0;
        private void btnGreek2_Click(object sender, RoutedEventArgs e)
        {
            c++;
            txtGreek.Text = c.ToString();
        }

        private void btnGreek1_Click(object sender, RoutedEventArgs e)
        {
            c--;
            if (c <= 0)
            {
                c = 0;
            }
            txtGreek.Text = c.ToString();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            calzone = a * 35000;
            chicago = b * 38000;
            greek = c * 34000;

            total = calzone + chicago + greek;
            txtTotal.Text = total.ToString();


            //insert data ke dbase
            pelanggan.UbahPelanggan();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            txtCalzone.Text = a.ToString();
            b = 0;
            txtChicago.Text = b.ToString();
            c = 0;
            txtGreek.Text = c.ToString();

            total = 0;
            txtTotal.Text = total.ToString();

            txtNama.Text = " ";
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nama\t\t: " + txtNama.Text + "\n" +
                            "Calzone\t\t: Rp." + calzone + "\n" + 
                            "Chicago Style\t: Rp." + chicago + "\n" +
                            "Greek Pizza\t: Rp." + greek + "\n" +
                            "Total\t\t: Rp." + total + "\n" + "\n" +
                            "Thank you, Your order has been successful!!!" , "Receipt" );
        }
    }
}