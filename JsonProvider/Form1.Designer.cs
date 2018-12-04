namespace JsonProvider
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Rtext = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbData1 = new System.Windows.Forms.TextBox();
            this.tbCName1 = new System.Windows.Forms.TextBox();
            this.AddJson = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextJson = new System.Windows.Forms.TextBox();
            this.ClearRText = new System.Windows.Forms.Button();
            this.Randm1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column Name";
            // 
            // Create
            // 
            this.Create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Create.Location = new System.Drawing.Point(533, 281);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(354, 23);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(23, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Rtext
            // 
            this.Rtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtext.Location = new System.Drawing.Point(15, 310);
            this.Rtext.Name = "Rtext";
            this.Rtext.Size = new System.Drawing.Size(593, 104);
            this.Rtext.TabIndex = 8;
            this.Rtext.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "string",
            "int"});
            this.comboBox1.Location = new System.Drawing.Point(227, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // tbData1
            // 
            this.tbData1.Location = new System.Drawing.Point(121, 25);
            this.tbData1.Name = "tbData1";
            this.tbData1.Size = new System.Drawing.Size(100, 20);
            this.tbData1.TabIndex = 4;
            // 
            // tbCName1
            // 
            this.tbCName1.Location = new System.Drawing.Point(15, 25);
            this.tbCName1.Multiline = true;
            this.tbCName1.Name = "tbCName1";
            this.tbCName1.Size = new System.Drawing.Size(100, 20);
            this.tbCName1.TabIndex = 1;
            // 
            // AddJson
            // 
            this.AddJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddJson.Location = new System.Drawing.Point(533, 252);
            this.AddJson.Name = "AddJson";
            this.AddJson.Size = new System.Drawing.Size(75, 23);
            this.AddJson.TabIndex = 10;
            this.AddJson.Text = "Add JSON";
            this.AddJson.UseVisualStyleBackColor = true;
            this.AddJson.Click += new System.EventHandler(this.AddJson_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "JSON Name:";
            // 
            // TextJson
            // 
            this.TextJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextJson.Location = new System.Drawing.Point(477, 26);
            this.TextJson.Name = "TextJson";
            this.TextJson.Size = new System.Drawing.Size(121, 20);
            this.TextJson.TabIndex = 12;
            this.TextJson.Text = "TextJSON";
            // 
            // ClearRText
            // 
            this.ClearRText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearRText.Location = new System.Drawing.Point(533, 223);
            this.ClearRText.Name = "ClearRText";
            this.ClearRText.Size = new System.Drawing.Size(75, 23);
            this.ClearRText.TabIndex = 13;
            this.ClearRText.Text = "Clear ";
            this.ClearRText.UseVisualStyleBackColor = true;
            this.ClearRText.Click += new System.EventHandler(this.ClearRText_Click);
            // 
            // Randm1
            // 
            this.Randm1.AutoSize = true;
            this.Randm1.Location = new System.Drawing.Point(420, 28);
            this.Randm1.Name = "Randm1";
            this.Randm1.Size = new System.Drawing.Size(15, 14);
            this.Randm1.TabIndex = 14;
            this.Randm1.UseVisualStyleBackColor = true;
            this.Randm1.CheckedChanged += new System.EventHandler(this.Randm1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Random";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Randm1);
            this.Controls.Add(this.ClearRText);
            this.Controls.Add(this.TextJson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddJson);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Rtext);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbData1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.tbCName1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(636, 465);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RichTextBox Rtext;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbData1;
        private System.Windows.Forms.TextBox tbCName1;
        private System.Windows.Forms.Button AddJson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextJson;
        private System.Windows.Forms.Button ClearRText;
        private System.Windows.Forms.CheckBox Randm1;
        private System.Windows.Forms.Label label4;
    }
}

