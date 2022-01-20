using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastFood.Controller
{
    class Pelanggan
    {
        //declare object utk view dan model
        private Model.PelangganModel pelangganModel; //model
        private DaftarPesan daftarPesan; //view
        //object tambah data siswa view
        private Pesan pesan;

        private UbahPesan ubahPesan;

        //instance
        public Pelanggan(DaftarPesan daftarPesan)
        {
            pelangganModel = new Model.PelangganModel();
            this.daftarPesan = daftarPesan;
        }

        public Pelanggan(Pesan tambahPesanan)
        {
            pelangganModel = new Model.PelangganModel();
            this.pesan = tambahPesanan;
        }

        public Pelanggan(UbahPesan ubahPesanan)
        {
            pelangganModel = new Model.PelangganModel();
            this.ubahPesan = ubahPesanan;
        }

        public void DataPelanggan()
        {
            string cari = "";
            DataSet data = pelangganModel.SelectPelanggan(cari);
            daftarPesan.dgPembeli.ItemsSource = data.Tables[0].DefaultView;
        }

        //insert data siswa
        public void TambahPelanggan()
        {
            //set data
            pelangganModel.nama = pesan.txtNama.Text;
            pelangganModel.total = int.Parse(pesan.txtTotal.Text);

            //proses insert
            bool result = pelangganModel.InsertPelanggan();
            //information
            if (result)
            {
                MessageBox.Show("Data pelanggan berhasil ditambahkan");
            }
            else
            {
                MessageBox.Show("Maaf, penambahan data pelanggan tidak dapat dilakukan, cek kembali dan pastikan data lengkap");
            }

        }

        //update data Pelanggan
        public void UbahPelanggan()
        {
            //set data
            pelangganModel.id_pelanggan = ubahPesan.txtId.Text;
            pelangganModel.nama = ubahPesan.txtNama.Text;
            pelangganModel.total = int.Parse(ubahPesan.txtTotal.Text);

            //proses update
            bool result = pelangganModel.UpdatePelanggan();
            //information
            if (result)
            {
                MessageBox.Show("Data pelanggan berhasil diubah");
            }
            else
            {
                MessageBox.Show("Maaf, perubahan data pelanggan tidak dapat dilakukan, cek kembali dan pastikan data lengkap");
            }

        }

        public void HapusPelanggan()
        {
            pelangganModel.id_pelanggan = DaftarPesan.id_pelanggan;
            //proses delete
            bool result = pelangganModel.DeletePelanggan();
            //information
            if (result)
            {
                MessageBox.Show("Data pelanggan berhasil dihapus");
            }
            else
            {
                MessageBox.Show("Maaf, hapus data pelanggan tidak dapat dilakukan");
            }
        }
    }
}
