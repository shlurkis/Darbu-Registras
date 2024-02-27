using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DarbuRegistrasFinal
{
    public partial class prideti : Form
    {
        string filepath = "data.txt";

        public prideti()
        {
            InitializeComponent();
        }

        private void prideti_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> data = GetData();
            SaveData(data);
            this.Close();
        }

        private List<string> GetData()
        {
            List<string> data = new List<string>();
            data.Add(textBox1.Text);
            data.Add(textBox2.Text);
            data.Add(dateTimePicker1.Text);
            if (radioButton1.Checked)
            {
                data.Add("Darbas");
            }
            else if (radioButton2.Checked)
            {
                data.Add("Šventė");
            }
            else
            {
                data.Add("Kita");
            }
            return data;
        }

        private void SaveData(List<string> items)
        {
            // Append data to data.txt
            using (StreamWriter writer = new StreamWriter("data.txt", true))
            {
                writer.WriteLine(string.Join("||", items));
            }

            // Depending on the type, append data to the corresponding file
            string type = items.Count > 3 ? items[3] : "";
            if (!string.IsNullOrEmpty(type))
            {
                string fileName = $"{type.ToLower()}_data.txt";
                using (StreamWriter typeWriter = new StreamWriter(fileName, true))
                {
                    typeWriter.WriteLine(string.Join("||", items));
                }
            }
        }
    }
}