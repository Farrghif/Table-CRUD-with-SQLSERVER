using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CrudBasic8
{
    public partial class Form1 : Form
    {
        db_siswaEntities db = new db_siswaEntities();
        Siswa table = null;
        public Form1()
        {
            InitializeComponent();
            generateSiswa();
        }

        private void generateSiswa()
        {
            siswaBindingSource.ResumeBinding();
            siswaBindingSource.ResetBindings(false);
            siswaBindingSource.DataSource = db.Siswa.ToList();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            addBTN.Enabled = false;
            editBTN.Enabled = false;
            deleteBTN.Enabled = false;

            saveBTN.Enabled = true;
            cancelBTN.Enabled = true;

            siswaBindingSource.SuspendBinding();
            table = null;
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            addBTN.Enabled = false;
            editBTN.Enabled = false;
            deleteBTN.Enabled = false;

            saveBTN.Enabled = true;
            cancelBTN.Enabled = true;
            table = (Siswa)siswaBindingSource.Current;
            siswaBindingSource.SuspendBinding();

            namaTextBox.Text = table.nama;
            kelasTextBox.Text = table.kelas;
            jenis_kelaminTextBox.Text = table.jenis_kelamin;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            table = (Siswa)siswaBindingSource.Current;
            db.Siswa.Remove(table);
            db.SaveChanges();
            generateSiswa();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (table == null)
            {
                Siswa s = new Siswa()
                {
                    nama = namaTextBox.Text,
                    kelas = kelasTextBox.Text,
                    jenis_kelamin = jenis_kelaminTextBox.Text
                };
                db.Siswa.Add(s);

            }
            else
            {

                Siswa s = db.Siswa.Find(table.id);
                s.nama = namaTextBox.Text;
                s.kelas = kelasTextBox.Text;
                s.jenis_kelamin = jenis_kelaminTextBox.Text;
            }
            db.SaveChanges();
            generateSiswa();

            addBTN.Enabled = true;
            editBTN.Enabled = true;
            deleteBTN.Enabled = true;

            saveBTN.Enabled = false;
            cancelBTN.Enabled = false;
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            siswaBindingSource.ResumeBinding();

            addBTN.Enabled = true;
            editBTN.Enabled = true;
            deleteBTN.Enabled = true;

            saveBTN.Enabled = false;
            cancelBTN.Enabled = false;
        }

        private DataTable readCSV(String filepath)
        {
            DataTable dt = new DataTable();
            File.ReadLines(filepath)
                .Take(1)
                .SelectMany(x => x.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => dt.Columns.Add(x.Trim()));

            File.ReadLines(filepath)
                .Skip(1)
                .Select(x => x.Split(new[] { ";" }, StringSplitOptions.None))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));

            return dt;


        }

        private void importBTN_Click(object sender, EventArgs e)
        {
            siswaBindingSource.SuspendBinding();
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dResult = ofd.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                DataTable dt = new DataTable();
                dt = readCSV(ofd.FileName);

                foreach (DataRow row in dt.Rows)
                {
                    Siswa s = new Siswa();
                    s.nama = row["nama"].ToString();
                    s.kelas = row["kelas"].ToString();
                    s.jenis_kelamin = row["jenis kelamin"].ToString();
                    db.Siswa.Add(s);
                }
                db.SaveChanges();
                generateSiswa();
            }
            else
            {
                siswaBindingSource.ResumeBinding();
            }
        }
    }
}
