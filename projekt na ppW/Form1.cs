using System.Diagnostics;
using System.IO;

namespace projekt_na_ppW
{



    public partial class Form1 : Form
    {
        private string saver { get; set; }
        public string currentFolder
        {
            get { return saver; }
            set

            {
                richTextBox1.Text = value;
                saver = value;
                acctListView(this);
            }
        }
        public List<string> truePathsOfFile { get; set; } = new List<string>();
        public List<string> truePathsOfDir { get; set; } = new List<string>();
        public Form1()
        {
            InitializeComponent();
            currentFolder = "C:\\";
            var pog = Directory.GetDirectories(currentFolder);
            treeView1.Nodes.Add("dysk lokalny c ");
            TreeNode node = treeView1.Nodes[0];
            foreach (string path in pog)
            {
                node.Nodes.Add(path,path.Substring(path.LastIndexOf('\\') + 1));
                truePathsOfDir.Add(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void acctListView(object sender)
        {
            listView1.Items.Clear();
            truePathsOfFile.Clear();
            try
            {
                var txtFiles = Directory.EnumerateFiles(currentFolder, "*");
                foreach (var f in txtFiles)
                {
                    listView1.Items.Add(f.Substring(f.LastIndexOf('\\') + 1));
                    truePathsOfFile.Add(f);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            truePathsOfFile.Clear();
            truePathsOfDir.Clear();
            string path = "";
            TreeNode actNode = e.Node;
            currentFolder= actNode.Name;
            try
            {
                var txtFiles = Directory.GetDirectories(currentFolder);
                foreach (var f in txtFiles)
                {

                    actNode.Nodes.Add(f,f.Substring(f.LastIndexOf('\\') + 1));
                    truePathsOfDir.Add(f);
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string path = truePathsOfFile[listView1.SelectedItems[0].Index];
            string att = path.Substring(path.LastIndexOf('.') + 1);
            if (att == "txt" || att == "cpp" || att == "csv" || att == "c" || att == "py" || att == "cs") // jakieœ bazowe rozszerzenia plików textowych nie wiem jak to zrobiæ ¿eby samo czyta³o i sprawdza³o czy dany kod jest mo¿liwy do edycji textowej
            {
                formularzZapisu window = new formularzZapisu(path);
                window.Show();
                return;
                
            }
            using (Process proc = new Process())
            {
                proc.StartInfo.FileName = (truePathsOfFile[listView1.SelectedItems[0].Index]);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = false;
                proc.Start();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}