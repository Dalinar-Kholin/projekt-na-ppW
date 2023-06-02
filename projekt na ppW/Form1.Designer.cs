namespace projekt_na_ppW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            listView1 = new ListView();
            addElem = new Button();
            delElem = new Button();
            edytuj = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Anchor = AnchorStyles.Top;
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(146, 539);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.TwoClick;
            listView1.Alignment = ListViewAlignment.Left;
            listView1.Anchor = AnchorStyles.Top;
            listView1.ImeMode = ImeMode.On;
            listView1.LabelEdit = true;
            listView1.Location = new Point(164, 12);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(317, 539);
            listView1.Sorting = SortOrder.Ascending;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // addElem
            // 
            addElem.Anchor = AnchorStyles.Top;
            addElem.Location = new Point(487, 12);
            addElem.Name = "addElem";
            addElem.Size = new Size(419, 103);
            addElem.TabIndex = 2;
            addElem.Text = "dodoaj element";
            addElem.UseVisualStyleBackColor = true;
            addElem.Click += button1_Click;
            // 
            // delElem
            // 
            delElem.Anchor = AnchorStyles.Top;
            delElem.Location = new Point(487, 121);
            delElem.Name = "delElem";
            delElem.Size = new Size(419, 103);
            delElem.TabIndex = 4;
            delElem.Text = "usuń Element";
            delElem.UseVisualStyleBackColor = true;
            // 
            // edytuj
            // 
            edytuj.Anchor = AnchorStyles.Top;
            edytuj.Location = new Point(487, 230);
            edytuj.Name = "edytuj";
            edytuj.Size = new Size(419, 103);
            edytuj.TabIndex = 5;
            edytuj.Text = "editr-open";
            edytuj.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.Location = new Point(487, 448);
            button5.Name = "button5";
            button5.Size = new Size(419, 103);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 565);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(894, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(487, 339);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(419, 103);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 600);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(edytuj);
            Controls.Add(delElem);
            Controls.Add(addElem);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private Button addElem;
        private Button delElem;
        private Button edytuj;
        private Button button5;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
    }
}