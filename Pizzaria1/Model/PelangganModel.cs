using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace FastFood.Model
{
    internal class PelangganModel
    {
        //create object ModelTemplate
        ModelTemplate template;

        //declare var sesuai dgn field di tabel pelanggan
        public string nama { get; set; }
        public int total { get; set; }
        public String id_pelanggan { get; set; }


        //instance
        public PelangganModel()
        {
            template = new ModelTemplate();
        }

        //select & search data pelanggan
        public DataSet SelectPelanggan(string cari)
        {
            DataSet dsPelanggan = new DataSet();
            if (cari == "")
            {
                dsPelanggan = template.Select("pelanggan", null);
            }
            else
            {
                string kondisi = "nama LIKE '%" + cari + "'%'";
                dsPelanggan = template.Select("pelanggan", kondisi);
            }
            return dsPelanggan;
        }

        //insert data pelanggan
        public bool InsertPelanggan()
        {
            string data = "'" + nama + "','" + total + "'";
            return template.Insert("pelanggan", data);
        }

        //update data pelanggan
        public bool UpdatePelanggan()
        {
            string tabel = "pelanggan";
            string data = "nama = '" + nama + "', total='" + total + "'";
            string kondisi = "id_pelanggan='" + id_pelanggan + "'";
            return template.Update(tabel, data, kondisi);
        }

        //delete data pelanggan
        public bool DeletePelanggan()
        {
            string tabel = "pelanggan";
            string kondisi = "id_pelanggan='" + id_pelanggan + "'";
            return template.Delete(tabel, kondisi);
        }
    }
}
