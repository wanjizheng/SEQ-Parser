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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog_Key = new System.Windows.Forms.OpenFileDialog();
            this.button_Key = new System.Windows.Forms.Button();
            this.button_Data = new System.Windows.Forms.Button();
            this.openFileDialog_Data = new System.Windows.Forms.OpenFileDialog();
            this.button_Export = new System.Windows.Forms.Button();
            this.richTextBox_Undefined = new System.Windows.Forms.RichTextBox();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Analysis = new System.Windows.Forms.TabPage();
            this.tabPage_Combination = new System.Windows.Forms.TabPage();
            this.button_Add = new System.Windows.Forms.Button();
            this.listBox_FileList = new System.Windows.Forms.ListBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Combine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_RawData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Combined = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar_Main = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel_ProgressBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_ProgressBar = new System.Windows.Forms.Timer(this.components);
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Analysis.SuspendLayout();
            this.tabPage_Combination.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_Key
            // 
            this.openFileDialog_Key.FileName = "CODE Key";
            this.openFileDialog_Key.Title = "Select a Key file";
            // 
            // button_Key
            // 
            this.button_Key.Location = new System.Drawing.Point(207, 104);
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
            this.button_Data.Location = new System.Drawing.Point(207, 157);
            this.button_Data.Name = "button_Data";
            this.button_Data.Size = new System.Drawing.Size(75, 23);
            this.button_Data.TabIndex = 1;
            this.button_Data.Text = "Import Data";
            this.button_Data.UseVisualStyleBackColor = true;
            this.button_Data.Click += new System.EventHandler(this.button_Data_Click);
            // 
            // openFileDialog_Data
            // 
            this.openFileDialog_Data.Title = "Select a data file";
            // 
            // button_Export
            // 
            this.button_Export.Enabled = false;
            this.button_Export.Location = new System.Drawing.Point(207, 282);
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
            this.richTextBox_Undefined.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_Undefined.Name = "richTextBox_Undefined";
            this.richTextBox_Undefined.Size = new System.Drawing.Size(161, 387);
            this.richTextBox_Undefined.TabIndex = 4;
            this.richTextBox_Undefined.Text = "";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Analysis);
            this.tabControl_Main.Controls.Add(this.tabPage_Combination);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(351, 419);
            this.tabControl_Main.TabIndex = 5;
            // 
            // tabPage_Analysis
            // 
            this.tabPage_Analysis.Controls.Add(this.richTextBox_Undefined);
            this.tabPage_Analysis.Controls.Add(this.button_Export);
            this.tabPage_Analysis.Controls.Add(this.button_Key);
            this.tabPage_Analysis.Controls.Add(this.button_Data);
            this.tabPage_Analysis.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Analysis.Name = "tabPage_Analysis";
            this.tabPage_Analysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Analysis.Size = new System.Drawing.Size(343, 393);
            this.tabPage_Analysis.TabIndex = 0;
            this.tabPage_Analysis.Text = "Data Analysis";
            this.tabPage_Analysis.UseVisualStyleBackColor = true;
            // 
            // tabPage_Combination
            // 
            this.tabPage_Combination.Controls.Add(this.label_Combined);
            this.tabPage_Combination.Controls.Add(this.label2);
            this.tabPage_Combination.Controls.Add(this.label_RawData);
            this.tabPage_Combination.Controls.Add(this.label1);
            this.tabPage_Combination.Controls.Add(this.button_Combine);
            this.tabPage_Combination.Controls.Add(this.button_Remove);
            this.tabPage_Combination.Controls.Add(this.listBox_FileList);
            this.tabPage_Combination.Controls.Add(this.button_Add);
            this.tabPage_Combination.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Combination.Name = "tabPage_Combination";
            this.tabPage_Combination.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Combination.Size = new System.Drawing.Size(343, 393);
            this.tabPage_Combination.TabIndex = 1;
            this.tabPage_Combination.Text = "Data Combination";
            this.tabPage_Combination.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(39, 130);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add File";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listBox_FileList
            // 
            this.listBox_FileList.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_FileList.FormattingEnabled = true;
            this.listBox_FileList.Location = new System.Drawing.Point(3, 3);
            this.listBox_FileList.Name = "listBox_FileList";
            this.listBox_FileList.Size = new System.Drawing.Size(337, 121);
            this.listBox_FileList.TabIndex = 1;
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(215, 130);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 2;
            this.button_Remove.Text = "Remove File";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Combine
            // 
            this.button_Combine.Location = new System.Drawing.Point(124, 277);
            this.button_Combine.Name = "button_Combine";
            this.button_Combine.Size = new System.Drawing.Size(75, 23);
            this.button_Combine.TabIndex = 3;
            this.button_Combine.Text = "Combine";
            this.button_Combine.UseVisualStyleBackColor = true;
            this.button_Combine.Click += new System.EventHandler(this.button_Combine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raw data:";
            // 
            // label_RawData
            // 
            this.label_RawData.AutoSize = true;
            this.label_RawData.ForeColor = System.Drawing.Color.Red;
            this.label_RawData.Location = new System.Drawing.Point(98, 204);
            this.label_RawData.Name = "label_RawData";
            this.label_RawData.Size = new System.Drawing.Size(0, 13);
            this.label_RawData.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Combined:";
            // 
            // label_Combined
            // 
            this.label_Combined.AutoSize = true;
            this.label_Combined.ForeColor = System.Drawing.Color.Blue;
            this.label_Combined.Location = new System.Drawing.Point(260, 204);
            this.label_Combined.Name = "label_Combined";
            this.label_Combined.Size = new System.Drawing.Size(0, 13);
            this.label_Combined.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar_Main,
            this.toolStripStatusLabel_ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(351, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar_Main
            // 
            this.toolStripProgressBar_Main.Name = "toolStripProgressBar_Main";
            this.toolStripProgressBar_Main.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel_ProgressBar
            // 
            this.toolStripStatusLabel_ProgressBar.Name = "toolStripStatusLabel_ProgressBar";
            this.toolStripStatusLabel_ProgressBar.Size = new System.Drawing.Size(0, 17);
            // 
            // timer_ProgressBar
            // 
            this.timer_ProgressBar.Interval = 1000;
            this.timer_ProgressBar.Tick += new System.EventHandler(this.timer_ProgressBar_Tick);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 419);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEQ Parser";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Analysis.ResumeLayout(false);
            this.tabPage_Combination.ResumeLayout(false);
            this.tabPage_Combination.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_Key;
        public System.Windows.Forms.Button button_Key;
        public System.Windows.Forms.Button button_Data;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Data;
        private System.Windows.Forms.Button button_Export;
        public System.Windows.Forms.RichTextBox richTextBox_Undefined;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Analysis;
        private System.Windows.Forms.TabPage tabPage_Combination;
        private System.Windows.Forms.Button button_Add;
        public System.Windows.Forms.ListBox listBox_FileList;
        private System.Windows.Forms.Button button_Remove;
        public System.Windows.Forms.Button button_Combine;
        public System.Windows.Forms.Label label_Combined;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label_RawData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_Main;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ProgressBar;
        public System.Windows.Forms.Timer timer_ProgressBar;
    }
}

