using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_lab2
{
    public partial class Form1 : Form
    {
        public string data;
        public string enc_data;
        public string dec_data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_key_btn_Click(object sender, EventArgs e)
        {
            Generator g = new Generator(Generator.Type.Key);
            Encrypting.KEY = g.Generate_key();
            Key_tb.Text = Encrypting.KEY;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\!_USERS\Maria\desktop\!иб2\IB_lab2\IB_lab2\bin\Debug\KEY.txt"))
            {
                file.WriteLine(Encrypting.KEY);
                file.Close();
            }

        }

        private void Generate_s_btn_Click(object sender, EventArgs e)
        {
            Generator g = new Generator(Generator.Type.S);
            Encrypting.Syncro_package = g.Generate_key();
            S_tb.Text = Encrypting.Syncro_package;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\!_USERS\Maria\desktop\!иб2\IB_lab2\IB_lab2\bin\Debug\S.txt"))
            {
                file.WriteLine(Encrypting.Syncro_package);
                file.Close();
            }
        }

        private void Load_file_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                data = System.IO.File.ReadAllText(filename);
                //File_path.Text = filename;
                tb_filename.Text = filename;
            }
        }

        private void Encrypt_btn_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                enc_data = Encrypting.encode(data, Encrypting.KEY);
                string filename = saveFileDialog1.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
                {
                    file.WriteLine(enc_data);
                    file.Close();
                }
            }
            MessageBox.Show("Файл зашифрован!");
        }

        private void Decrypt_btn_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dec_data = Encrypting.decode(enc_data, Encrypting.KEY);
                string filename = saveFileDialog1.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
                {
                    file.WriteLine(dec_data);
                    file.Close();
                }
            }
            MessageBox.Show("Файл расшифрован!");
        }

        private void About_btn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Васильева М.С." + Environment.NewLine + "Алгоритм шифрования ГОСТ 28147");
        }
    }
}
