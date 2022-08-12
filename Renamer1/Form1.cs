using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string PrefixValue;

        public string[] files { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
            RenameButton.Enabled = true;
        }

        private void RefreshData()
        {
            ReNumber();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value is null)
                    row.Cells[4].Value = FolderPath.Text + "\\" + row.Cells[1].Value + row.Cells[3].Value;
                else
                {
                    row.Cells[4].Value = FolderPath.Text + "\\Renamed\\" + (row.Cells[1].Value + (row.Cells[2].Value.ToString())) + row.Cells[3].Value;
                }
            }
            RenameButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            progressBar1.Value = 0;
            
            
            folderBrowserDialog1.ShowDialog();
            FolderPath.Text = "";
            if (folderBrowserDialog1.SelectedPath.Length > 0)
            {
                FolderPath.Text = folderBrowserDialog1.SelectedPath;
                files = System.IO.Directory.GetFiles(FolderPath.Text);
                string filename;
                string fileNumber;
                string extension;
                string caption = "";
                string fullname;
                string prefixName = Prefix.Text;
                string suffixName = Suffix.Text;
                string caption2="";
                

                for (int i = 0; i < files.Length; i++)
                {
                    filename = files[i];
                    extension = filename.Substring(filename.LastIndexOf('.'));
                    fileNumber = (i + 1).ToString("D3");
                    fullname = filename.Substring(filename.LastIndexOf('\\') + 1, filename.LastIndexOf('.') - filename.LastIndexOf('\\') - 1);
                    Regex regex = new Regex(@"(^\d+\b)");
                    caption=regex.Replace(fullname, "");
                    if (caption.Length <= 0)
                        caption2 = caption;
                    else
                        caption2 = prefixName + caption;
                    dataGridView1.Rows.Insert(i, files[i],  fileNumber, caption2, extension);
                }
                PrefixValue = prefixName;
                RefreshData();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (!Directory.Exists(FolderPath.Text + "\\Renamed\\"))
            {
                Directory.CreateDirectory(FolderPath.Text + "\\Renamed\\");
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (File.Exists(row.Cells[0].Value.ToString()))
                {
                    File.Copy(row.Cells[0].Value.ToString(), row.Cells[4].Value.ToString(), true);

                }
            }
            progressBar1.Value = 100;
            MessageBox.Show("Complete");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedValue = Suffix.Text;

            RefreshDefault(SelectedValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Recolour(Color.WhiteSmoke, Color.LightGray);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0) { 
              

            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            int index = currentRow.Index-1;
                if (currentRow.Index > 0)
                {
                    dataGridView1.Rows.RemoveAt(currentRow.Index);
                    
                    dataGridView1.Rows.Insert(index, currentRow);
                    RefreshData();
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[index].Selected = true;
                }
            }

        }

        private void ReNumber()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[1].Value = (row.Index + 1).ToString("D3");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Suffix_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SelectedValue = Suffix.Text;

            RefreshDefault(SelectedValue);
            RefreshData();
        }

        private void RefreshDefault(string SelectedValue)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[2].Value.ToString().Length <= 0)
                {

                    row.Cells[2].Value = (Prefix.Text + SelectedValue).TrimEnd();

                }
                foreach (String v in Suffix.Items)
                {
                    if (row.Cells[2].Value.Equals(PrefixValue + v))
                        row.Cells[2].Value = (Prefix.Text + SelectedValue).TrimEnd();
                }

            }
            PrefixValue = Prefix.Text;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {


                DataGridViewRow currentRow = dataGridView1.CurrentRow;
                int index = currentRow.Index + 1;
                if (currentRow.Index < dataGridView1.RowCount-1)
                {
                    dataGridView1.Rows.RemoveAt(currentRow.Index);

                    dataGridView1.Rows.Insert(index, currentRow);
                    
                    RefreshData();
                    dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[index].Selected = true;
                    
                }
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            grayToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            Recolour(Color.SkyBlue, Color.AliceBlue);

        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            grayToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;
            
            Recolour(Color.WhiteSmoke,Color.LightGray);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            grayToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            
            Recolour(Color.Honeydew,Color.LightGreen);
        }

        private void Recolour(Color C, Color C2)
        {
            panel1.BackColor = C;
            button2.BackColor = C;
            button1.BackColor = C;
            label1.BackColor = C;
            label2.BackColor = C;
            Suffix.BackColor = C;
            menuStrip1.BackColor = C;
            toolStripMenuItem1.BackColor = C;
            helpToolStripMenuItem.BackColor = C;
            colourToolStripMenuItem.BackColor = C;
            redToolStripMenuItem.BackColor = C;
            blueToolStripMenuItem.BackColor = C;
            greenToolStripMenuItem.BackColor = C;
            grayToolStripMenuItem.BackColor = C;
            Prefix.BackColor = C;
            OpenButton.BackColor = C;
            RenameButton.BackColor = C;
            this.BackColor = C;
            dataGridView1.BackgroundColor = C2;
            FolderPath.BackColor = C2;
            progressBar1.BackColor = C2;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            grayToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = true;
           
            Recolour(Color.LightCoral,Color.MistyRose);

        }
    }
}
