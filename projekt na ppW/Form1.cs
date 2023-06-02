using System.Diagnostics;

namespace projekt_na_ppW
{
    public partial class Form1 : Form
    {
        public string currentFolder { get; set; }
        public List<string> truePaths { get; set; }
        public Form1()
        {
            InitializeComponent();
            currentFolder = "C:\\";
            truePaths = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            truePaths.Clear();
            currentFolder = textBox1.Text.Trim();
            button5.Text = currentFolder;
            try
            {
                var txtFiles = Directory.EnumerateFiles(currentFolder, "*");
                foreach (var f in txtFiles)
                {
                    listView1.Items.Add(f.Substring(f.LastIndexOf('\\') + 1));
                    truePaths.Add(f);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            using (Process proc = new Process()) {
                proc.StartInfo.FileName = (truePaths[listView1.SelectedItems[0].Index]);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = false;
                proc.Start();
            } 
        }
    }
}