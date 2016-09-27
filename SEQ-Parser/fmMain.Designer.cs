namespace SEQ_Parser
{
    partial class fmMain
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
            this.openFileDialog_Key = new System.Windows.Forms.OpenFileDialog();
            this.button_Key = new System.Windows.Forms.Button();
            this.button_Data = new System.Windows.Forms.Button();
            this.openFileDialog_Data = new System.Windows.Forms.OpenFileDialog();
            this.button_Export = new System.Windows.Forms.Button();
            this.richTextBox_Undefined = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog_Key
            // 
            this.openFileDialog_Key.FileName = "CODE Key";
            this.openFileDialog_Key.Title = "Select a Key file";
            // 
            // button_Key
            // 
            this.button_Key.Location = new System.Drawing.Point(132, 29);
            this.button_Key.Name = "button_Key";
            this.button_Key.Size = new System.Drawing.Size(75, 23);
            this.button_Key.TabIndex = 0;
            this.button_Key.Text = "Import Key";
            this.button_Key.UseVisualStyleBackColor = true;
            this.button_Key.Click += new System.EventHandler(this.button_Key_Click);
            // 
            // button_Data
            // 
            this.button_Data.Enabled = false;
            this.button_Data.Location = new System.Drawing.Point(132, 73);
            this.button_Data.Name = "button_Data";
            this.button_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Data.TabIndex = 1;
            this.button_Data.Text = "Import Data";
            this.button_Data.UseVisualStyleBackColor = true;
            this.button_Data.Click += new System.EventHandler(this.button_Data_Click);
            // 
            // openFileDialog_Data
            // 
            this.openFileDialog_Data.FileName = "ALL_SEQ_FINAL_AND DATE";
            this.openFileDialog_Data.Title = "Select a data file";
            // 
            // button_Export
            // 
            this.button_Export.Enabled = false;
            this.button_Export.Location = new System.Drawing.Point(132, 145);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(75, 23);
            this.button_Export.TabIndex = 2;
            this.button_Export.Text = "Export Data";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // richTextBox_Undefined
            // 
            this.richTextBox_Undefined.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox_Undefined.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Undefined.Name = "richTextBox_Undefined";
            this.richTextBox_Undefined.Size = new System.Drawing.Size(100, 180);
            this.richTextBox_Undefined.TabIndex = 4;
            this.richTextBox_Undefined.Text = "";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 180);
            this.Controls.Add(this.richTextBox_Undefined);
            this.Controls.Add(this.button_Export);
            this.Controls.Add(this.button_Data);
            this.Controls.Add(this.button_Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEQ Parser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_Key;
        public System.Windows.Forms.Button button_Key;
        public System.Windows.Forms.Button button_Data;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Data;
        private System.Windows.Forms.Button button_Export;
        public System.Windows.Forms.RichTextBox richTextBox_Undefined;
    }
}

