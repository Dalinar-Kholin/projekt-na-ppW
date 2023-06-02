using System.Diagnostics;

namespace projekt_na_ppW
{
    public partial class Form1 : Form
    {
        private string saver { get; set; }//tylko pomocnicze przy nowej warto�ci currentFolder
        public string currentFolder // �cie�ka do folderu w kt�ryum aktualnie jeste�my
        {
            get { return saver; }
            set
            {
                saver = value;
                acctListView(this); // kiedy nastepuje zmiana �cie�ki do pliku aktualizujemy nasz� liste dost�pnych plik�w
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
                var txtFiles = Directory.EnumerateFiles(currentFolder, "*"); // otwieramy nasz� �ci�k� i pobieramy z niej wszystkie pliki (bez folder�w)
                foreach (var f in txtFiles)
                {
                    listView1.Items.Add( f.Substring(f.LastIndexOf('\\') + 1), f); // dodajemy do listy elementy w postaci text = kr�tka �cie�ka imagineKey = pe�na �cie�ka
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = "";
            TreeNode actNode = e.Node;  // dostajemy jako e dok�adny node kt�ry by� kliknity
            currentFolder = actNode.Name;
            try
            {
                var txtFiles = Directory.GetDirectories(currentFolder);
                foreach (var f in txtFiles)
                {

                    actNode.Nodes.Add(f, f.Substring(f.LastIndexOf('\\') + 1)); ///  dodajemy do drzewa elementy tak �e text = kr�tka �cie�ka Name = pe�na �cie�ka
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
                string path = listView1.Items[listView1.SelectedItems[0].Index].ImageKey; //wyci�gamy z listy pe�n� �cie�k�
                string att = path.Substring(path.LastIndexOf('.') + 1);
                if (att == "txt" || att == "cpp" || att == "csv" || att == "c" || att == "py" || att == "cs") // jakie� bazowe rozszerzenia plik�w textowych nie wiem jak to zrobi� �eby samo czyta�o i sprawdza�o czy dany kod jest mo�liwy do edycji textowej
                {
                    formularzZapisu window = new formularzZapisu(path);
                    window.Show();
                    return;

                }
                using (Process proc = new Process()) //egzekucja �cie�ki
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