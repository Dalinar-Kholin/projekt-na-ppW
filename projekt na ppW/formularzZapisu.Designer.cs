namespace projekt_na_ppW
{
    partial class formularzZapisu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            save = new Button();
            reject = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(760, 338);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // save
            // 
            save.Location = new Point(12, 356);
            save.Name = "save";
            save.Size = new Size(341, 93);
            save.TabIndex = 1;
            save.Text = "zachowaj zmiany ";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // reject
            // 
            reject.Location = new Point(431, 356);
            reject.Name = "reject";
            reject.Size = new Size(341, 93);
            reject.TabIndex = 2;
            reject.Text = "odrzuć zmiany";
            reject.UseVisualStyleBackColor = true;
            reject.Click += reject_Click;
            // 
            // formularzZapisu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(784, 461);
            Controls.Add(reject);
            Controls.Add(save);
            Controls.Add(richTextBox1);
            Name = "formularzZapisu";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button save;
        private Button reject;
    }
}