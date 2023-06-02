using System.Diagnostics;

namespace projekt_na_ppW
{
    public partial class Form1 : Form
    {
        private string saver { get; set; }//tylko pomocnicze przy nowej wartoœci currentFolder
        public string currentFolder // œcie¿ka do folderu w któryum aktualnie jesteœmy
        {
            get { return saver; }
            set
            {
                saver = value;
                acctListView(this); // kiedy nastepuje zmiana œcie¿ki do pliku aktualizujemy nasz¹ liste dostêpnych plików
            }
        }
        public Form1()
        {
            InitializeComponent();
            foreach(var drive in DriveInfo.GetDrives())
            {
                treeView1.Nodes.Add(drive.Name, drive.Name);
            }
        }

        private void acctListView(object sender)
        {
            listView1.Items.Clear();
            try
            {
                var txtFiles = Directory.EnumerateFiles(currentFolder, "*"); // otwieramy nasz¹ œci¿kê i pobieramy z niej wszystkie pliki (bez folderów)
                foreach (var f in txtFiles)
                {
                    listView1.Items.Add( f.Substring(f.LastIndexOf('\\') + 1), f); // dodajemy do listy elementy w postaci text = krótka œcie¿ka imagineKey = pe³na œcie¿ka
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = "";
            TreeNode actNode = e.Node;  // dostajemy jako e dok³adny node który by³ kliknity
            currentFolder = actNode.Name;
            try
            {
                var txtFiles = Directory.GetDirectories(currentFolder);
                foreach (var f in txtFiles)
                {

                    actNode.Nodes.Add(f, f.Substring(f.LastIndexOf('\\') + 1)); ///  dodajemy do drzewa elementy tak ¿e text = krótka œcie¿ka Name = pe³na œcie¿ka
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string path = listView1.Items[listView1.SelectedItems[0].Index].ImageKey; //wyci¹gamy z listy pe³n¹ œcie¿kê
                string att = path.Substring(path.LastIndexOf('.') + 1);
                if (att == "txt" || att == "cpp" || att == "csv" || att == "c" || att == "py" || att == "cs") // jakieœ bazowe rozszerzenia plików textowych nie wiem jak to zrobiæ ¿eby samo czyta³o i sprawdza³o czy dany kod jest mo¿liwy do edycji textowej
                {
                    formularzZapisu window = new formularzZapisu(path);
                    window.Show();
                    return;

                }
                using (Process proc = new Process()) //egzekucja œcie¿ki
                {
                    proc.StartInfo.FileName = (listView1.Items[listView1.SelectedItems[0].Index].ImageKey);
                    proc.StartInfo.UseShellExecute = true;
                    proc.StartInfo.RedirectStandardOutput = false;
                    proc.Start();
                }
            }
            catch { }
        }
    }
}