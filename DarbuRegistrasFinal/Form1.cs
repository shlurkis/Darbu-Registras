using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DarbuRegistrasFinal
{
    public partial class Form1 : Form
    {
        private string filePath = "data.txt";
        private List<string> sortedLinesData;
        private List<string> editedLinesData = new List<string>();
        private List<string> darbasItems = new List<string>();
        private List<string> sventeItems = new List<string>();
        private List<string> kitaItems = new List<string>();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.MouseUp += listBox1_MouseUp;
            button8.Enabled = false;
            button8.Visible = false;

            if (listBox1.Items.Count == 0)
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }

            this.Size = new System.Drawing.Size(420, 505);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prideti prideti = new prideti();
            prideti.ShowDialog();
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex != -1 && selectedIndex < sortedLinesData.Count)
            {
                string selectedLine = sortedLinesData[selectedIndex];
                string[] parts = selectedLine.Split(new string[] { "||" }, StringSplitOptions.None);
                string type = parts.Length > 3 ? parts[3].ToLower() : "";

                string[] lines = File.ReadAllLines(filePath);
                if (selectedIndex < lines.Length)
                {
                    List<string> updatedLines = lines.ToList();
                    updatedLines.RemoveAt(selectedIndex);
                    File.WriteAllLines(filePath, updatedLines);
                }

                if (!string.IsNullOrEmpty(type))
                {
                    string typeFileName = $"{type}_data.txt";
                    if (File.Exists(typeFileName))
                    {
                        var typeLines = File.ReadAllLines(typeFileName).ToList();
                        if (selectedIndex < typeLines.Count)
                        {
                            typeLines.RemoveAt(selectedIndex);
                            File.WriteAllLines(typeFileName, typeLines);
                        }
                    }
                }

                LoadData();
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex != -1 && selectedIndex < sortedLinesData.Count)
            {
                string selectedLine = sortedLinesData[selectedIndex];

                string[] parts = selectedLine.Split(new string[] { "||" }, StringSplitOptions.None);

                System.Diagnostics.Debug.WriteLine($"Selected Index: {selectedIndex}");
                System.Diagnostics.Debug.WriteLine($"Selected Line: {selectedLine}");
                System.Diagnostics.Debug.WriteLine($"Parts: {string.Join(", ", parts)}");

                textBox4.Text = parts.Length > 0 ? parts[0] : "";
                textBox1.Text = parts.Length > 0 ? parts[1] : "";
                textBox2.Text = parts.Length > 1 ? parts[2] : "";
                comboBox1.SelectedItem = parts.Length > 2 ? parts[3] : "";

                this.Size = new System.Drawing.Size(743, 505);
            }
        }

        private void LoadData()
        {
            editedLinesData.Clear();
            darbasItems.Clear();
            sventeItems.Clear();
            kitaItems.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                var lineDatePairs = lines.Select(line =>
                {
                    string[] parts = line.Split(new string[] { "||" }, StringSplitOptions.None);
                    return new
                    {
                        Part0 = parts.Length > 0 ? parts[0] : "",
                        Date = DateTime.TryParse(parts.Length > 2 ? parts[2] : "", out DateTime date) ? date : DateTime.MinValue,
                        Line = line
                    };
                }).ToList();

                var sortedLines = lineDatePairs.OrderBy(pair => pair.Date).ToList();

                sortedLinesData = sortedLines.Select(pair => pair.Line).ToList();

                foreach (var sortedLine in sortedLinesData)
                {
                    string[] parts = sortedLine.Split(new string[] { "||" }, StringSplitOptions.None);

                    if (parts.Length > 3)
                    {
                        string itemType = parts[3].Trim();
                        editedLinesData.Add(sortedLine);

                        switch (itemType)
                        {
                            case "Darbas":
                                darbasItems.Add(sortedLine);
                                break;
                            case "Šventė":
                                sventeItems.Add(sortedLine);
                                break;
                            case "Kita":
                                kitaItems.Add(sortedLine);
                                break;
                        }
                    }
                }
            }
            DisplayItems(editedLinesData);

            button5.Enabled = listBox1.Items.Count > 0;

            if (editedLinesData.Count > 0)
            {
                string[] parts = editedLinesData[0].Split(new string[] { "||" }, StringSplitOptions.None);
                textBox4.Text = parts.Length > 0 ? parts[0] : "";
                textBox1.Text = parts.Length > 0 ? parts[1] : "";
                textBox2.Text = parts.Length > 1 ? parts[2] : "";
                comboBox1.SelectedItem = parts.Length > 2 ? parts[3] : "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
            button5.Enabled = true;
            button7.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayItems(darbasItems);
            button5.Enabled = false;
            button7.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayItems(sventeItems);
            button5.Enabled = false;
            button7.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayItems(kitaItems);
            button5.Enabled = false;
            button7.Enabled = false;
        }

        private void kontaktaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dėl problemų ir kt. kreiptis: arminasrupsys03@gmail.com", "Kontaktai", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void instrukcijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mygtukai(Visi, Darbai, Šventės, Kiti), saraše rodys pagal tam tikrą tipą sukurtus įrašus." +
                "Pasirinkus įrašą, programa prasiplės ir rodys įrašo informaciją(Datą, tipą ir aprašymą)." +
                "Mygtukas 'pridėti' išmes naują langą, kuriame sukuriame naują objektą." +
                "Mygtukas 'ištrinti' ištrins pasirinktą objektą.", "Instrukcija", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex != -1)
            {
                string selectedLine = sortedLinesData[selectedIndex];
                editedLinesData.Add(selectedLine);

                button7.Enabled = false;

                button8.Visible = true;
                button8.Enabled = true;

                comboBox1.Enabled = true;
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex != -1)
            {
                string newLine = $"{textBox4.Text.Trim()}||{textBox1.Text.Trim()}||{textBox2.Text.Trim()}||{comboBox1.SelectedItem?.ToString().Trim() ?? ""}";

                string oldLine = sortedLinesData[selectedIndex];

                sortedLinesData[selectedIndex] = newLine;

                SortListByDate();

                File.WriteAllLines(filePath, sortedLinesData);

                listBox1.Items.Clear();
                foreach (var sortedLine in sortedLinesData)
                {
                    string[] parts = sortedLine.Split(new string[] { "||" }, StringSplitOptions.None);
                    listBox1.Items.Add(parts[0]);
                }

                listBox1.SelectedIndex = selectedIndex;

                string[] oldParts = oldLine.Split(new string[] { "||" }, StringSplitOptions.None);
                string oldType = oldParts.Length > 3 ? oldParts[3].Trim() : "";

                if (!string.IsNullOrEmpty(oldType))
                {
                    string oldTypeFileName = $"{oldType}_data.txt";
                    if (File.Exists(oldTypeFileName))
                    {
                        var oldTypeLines = File.ReadAllLines(oldTypeFileName).ToList();
                        if (selectedIndex < oldTypeLines.Count)
                        {
                            oldTypeLines.RemoveAt(selectedIndex);
                            File.WriteAllLines(oldTypeFileName, oldTypeLines);
                        }
                    }
                }

                string newType = comboBox1.SelectedItem?.ToString().Trim() ?? "";
                if (!string.IsNullOrEmpty(newType))
                {
                    string newTypeFileName = $"{newType}_data.txt";
                    File.AppendAllLines(newTypeFileName, new[] { newLine });
                }

                button7.Enabled = true;

                button8.Enabled = false;
                button8.Visible = false;

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                comboBox1.Enabled = false;
                textBox4.ReadOnly = true;
            }
        }

        private void SortListByDate()
        {
            var lineDatePairs = sortedLinesData.Select(line =>
            {
                string[] parts = line.Split(new string[] { "||" }, StringSplitOptions.None);
                return new
                {
                    Line = line,
                    Date = DateTime.TryParse(parts.Length > 2 ? parts[2] : "", out DateTime date) ? date : DateTime.MinValue
                };
            }).ToList();

            sortedLinesData = lineDatePairs.OrderBy(pair => pair.Date).Select(pair => pair.Line).ToList();
        }

        private void DisplayItems(List<string> items)
        {
            listBox1.Items.Clear();

            sortedLinesData = items.ToList();  // Update sortedLinesData

            foreach (var sortedLine in items)
            {
                string[] parts = sortedLine.Split(new string[] { "||" }, StringSplitOptions.None);
                listBox1.Items.Add(parts[0]);
            }

            button5.Enabled = listBox1.Items.Count > 0;

            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                listBox1.SelectedIndex = selectedIndex;

                selectedIndex = listBox1.SelectedIndex;

                string[] parts = items[selectedIndex].Split(new string[] { "||" }, StringSplitOptions.None);
                textBox4.Text = parts.Length > 0 ? parts[0] : "";
                textBox1.Text = parts.Length > 0 ? parts[1] : "";
                textBox2.Text = parts.Length > 1 ? parts[2] : "";
                comboBox1.SelectedItem = parts.Length > 2 ? parts[3] : "";
            }
            else if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
                selectedIndex = 0;

                string[] parts = items[selectedIndex].Split(new string[] { "||" }, StringSplitOptions.None);
                textBox4.Text = parts.Length > 0 ? parts[0] : "";
                textBox1.Text = parts.Length > 0 ? parts[1] : "";
                textBox2.Text = parts.Length > 1 ? parts[2] : "";
                comboBox1.SelectedItem = parts.Length > 2 ? parts[3] : "";
            }
        }
    }
}
