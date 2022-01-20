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
    public partial class DaftarPesan : UserControl
    {
        private Controller.Pelanggan pelanggan;

        //declare static variabel
        public static string id_pelanggan;
        public static string nama;
        public static string total;

        public DaftarPesan()
        {
            InitializeComponent();

            //instance
            pelanggan = new Controller.Pelanggan(this);

            //function utk menampilkan data di datagrid
            pelanggan.DataPelanggan();
        }

        public void SetStaticVar()
        {
            id_pelanggan = "";
            nama = "";
            total = "";
        }

        private void btnUbah_Click(object sender, RoutedEventArgs e)
        {
            object item = dgPembeli.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Pilih data pelanggan yang ingin diubah terlebih dahulu");
            }
            else
            {
                getData();
                UbahPesan ubahPesan = new UbahPesan();
                SPContent.Children.Clear();
                SPContent.Children.Add(ubahPesan);
            }
            SetStaticVar();
        }

        public void getData()
        {
            object item = dgPembeli.SelectedItem;
            id_pelanggan = (dgPembeli.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            nama = (dgPembeli.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            total = (dgPembeli.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void btnHapus_Click(object sender, RoutedEventArgs e)
        {
            object item = dgPembeli.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Pilih data pelanggan yang ingin dihapus terlebih dahulu");
            }
            else
            {
                getData();
                if (MessageBox.Show("Yakin ingin menghapus data?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    pelanggan.HapusPelanggan();
                }
            }
            SetStaticVar();
            pelanggan.DataPelanggan();
        }
    }
}
