namespace TGM_reader
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClcTireS = new System.Windows.Forms.Button();
            this.textBox_size3 = new System.Windows.Forms.TextBox();
            this.textBox_size2 = new System.Windows.Forms.TextBox();
            this.textBox_size1 = new System.Windows.Forms.TextBox();
            this.textBox_fn = new System.Windows.Forms.TextBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(621, 542);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(621, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 626);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(684, 233);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClcTireS);
            this.groupBox1.Controls.Add(this.textBox_size3);
            this.groupBox1.Controls.Add(this.textBox_size2);
            this.groupBox1.Controls.Add(this.textBox_size1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(547, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New tire size";
            this.groupBox1.Visible = false;
            // 
            // buttonClcTireS
            // 
            this.buttonClcTireS.Location = new System.Drawing.Point(18, 60);
            this.buttonClcTireS.Name = "buttonClcTireS";
            this.buttonClcTireS.Size = new System.Drawing.Size(75, 23);
            this.buttonClcTireS.TabIndex = 1;
            this.buttonClcTireS.Text = "Calculate";
            this.buttonClcTireS.UseVisualStyleBackColor = true;
            // 
            // textBox_size3
            // 
            this.textBox_size3.Location = new System.Drawing.Point(99, 19);
            this.textBox_size3.Name = "textBox_size3";
            this.textBox_size3.Size = new System.Drawing.Size(30, 20);
            this.textBox_size3.TabIndex = 0;
            // 
            // textBox_size2
            // 
            this.textBox_size2.Location = new System.Drawing.Point(63, 19);
            this.textBox_size2.Name = "textBox_size2";
            this.textBox_size2.Size = new System.Drawing.Size(30, 20);
            this.textBox_size2.TabIndex = 0;
            // 
            // textBox_size1
            // 
            this.textBox_size1.Location = new System.Drawing.Point(7, 20);
            this.textBox_size1.Name = "textBox_size1";
            this.textBox_size1.Size = new System.Drawing.Size(50, 20);
            this.textBox_size1.TabIndex = 0;
            // 
            // textBox_fn
            // 
            this.textBox_fn.Location = new System.Drawing.Point(12, 600);
            this.textBox_fn.Name = "textBox_fn";
            this.textBox_fn.ReadOnly = true;
            this.textBox_fn.Size = new System.Drawing.Size(684, 20);
            this.textBox_fn.TabIndex = 6;
            this.textBox_fn.TabStop = false;
            // 
            // button_generate
            // 
            this.button_generate.Enabled = false;
            this.button_generate.Location = new System.Drawing.Point(346, 553);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(75, 23);
            this.button_generate.TabIndex = 7;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_Generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 871);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.textBox_fn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "TGM Tool v0.1a ALPHA Version, use at your own risk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClcTireS;
        private System.Windows.Forms.TextBox textBox_size3;
        private System.Windows.Forms.TextBox textBox_size2;
        private System.Windows.Forms.TextBox textBox_size1;
        private System.Windows.Forms.TextBox textBox_fn;
        private System.Windows.Forms.Button button_generate;
    }
}

