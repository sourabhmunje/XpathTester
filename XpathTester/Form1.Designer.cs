namespace XpathTester
{
    partial class baseForm
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
            this.browseBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.XmlText = new System.Windows.Forms.RichTextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonback = new System.Windows.Forms.Button();
            this.expandAllBtn = new System.Windows.Forms.Button();
            this.pathXml = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseBtn
            // 
            this.browseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.browseBtn.Location = new System.Drawing.Point(13, 13);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(97, 37);
            this.browseBtn.TabIndex = 0;
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(735, 515);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(611, 260);
            this.ResultBox.TabIndex = 1;
            this.ResultBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // QueryBox
            // 
            this.QueryBox.Location = new System.Drawing.Point(138, 440);
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(1007, 22);
            this.QueryBox.TabIndex = 4;
            this.QueryBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 515);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 260);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // XmlText
            // 
            this.XmlText.Location = new System.Drawing.Point(28, 56);
            this.XmlText.Name = "XmlText";
            this.XmlText.ReadOnly = true;
            this.XmlText.Size = new System.Drawing.Size(825, 330);
            this.XmlText.TabIndex = 6;
            this.XmlText.Text = "";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(889, 56);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(457, 330);
            this.treeView.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(1174, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 37);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(378, 515);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(280, 260);
            this.listBox2.TabIndex = 10;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // buttonback
            // 
            this.buttonback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonback.Location = new System.Drawing.Point(1153, 12);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(193, 23);
            this.buttonback.TabIndex = 11;
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // expandAllBtn
            // 
            this.expandAllBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.expandAllBtn.Location = new System.Drawing.Point(889, 401);
            this.expandAllBtn.Name = "expandAllBtn";
            this.expandAllBtn.Size = new System.Drawing.Size(126, 33);
            this.expandAllBtn.TabIndex = 12;
            this.expandAllBtn.UseVisualStyleBackColor = true;
            this.expandAllBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pathXml
            // 
            this.pathXml.AutoSize = true;
            this.pathXml.BackColor = System.Drawing.Color.Transparent;
            this.pathXml.Location = new System.Drawing.Point(135, 18);
            this.pathXml.Name = "pathXml";
            this.pathXml.Size = new System.Drawing.Size(79, 17);
            this.pathXml.TabIndex = 14;
            this.pathXml.Text = "Path of File";
            this.pathXml.Click += new System.EventHandler(this.pathXml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Click on Parent nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(385, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Click on Child nodes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(742, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Result of Query";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(901, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tree View";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Type Query Here :";
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XpathTester.Resource1.Background_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 795);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathXml);
            this.Controls.Add(this.expandAllBtn);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.XmlText);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.browseBtn);
            this.KeyPreview = true;
            this.Name = "baseForm";
            this.Text = "Xpath Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox XmlText;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button expandAllBtn;
        private System.Windows.Forms.Label pathXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

