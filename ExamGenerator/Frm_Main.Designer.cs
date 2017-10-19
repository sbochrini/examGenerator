namespace ExamGenerator
{
    using ExamKernel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class Frm_Main 
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
            this.main_form_tabs = new System.Windows.Forms.TabControl();
            this.import_tab = new System.Windows.Forms.TabPage();
            this.import_file_btn = new System.Windows.Forms.Button();
            this.sampling_tab = new System.Windows.Forms.TabPage();
            this.report_tab = new System.Windows.Forms.TabPage();
            this.import_file_lbl = new System.Windows.Forms.Label();
            this.main_form_tabs.SuspendLayout();
            this.import_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_form_tabs
            // 
            this.main_form_tabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.main_form_tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.main_form_tabs.Controls.Add(this.import_tab);
            this.main_form_tabs.Controls.Add(this.sampling_tab);
            this.main_form_tabs.Controls.Add(this.report_tab);
            this.main_form_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_form_tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.main_form_tabs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_form_tabs.ItemSize = new System.Drawing.Size(40, 130);
            this.main_form_tabs.Location = new System.Drawing.Point(0, 0);
            this.main_form_tabs.Multiline = true;
            this.main_form_tabs.Name = "main_form_tabs";
            this.main_form_tabs.SelectedIndex = 0;
            this.main_form_tabs.Size = new System.Drawing.Size(679, 525);
            this.main_form_tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.main_form_tabs.TabIndex = 0;
            this.main_form_tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.main_form_tabs_DrawItem);
            // 
            // import_tab
            // 
            this.import_tab.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.import_tab.Controls.Add(this.import_file_lbl);
            this.import_tab.Controls.Add(this.import_file_btn);
            this.import_tab.Location = new System.Drawing.Point(130, 4);
            this.import_tab.Name = "import_tab";
            this.import_tab.Padding = new System.Windows.Forms.Padding(3);
            this.import_tab.Size = new System.Drawing.Size(545, 517);
            this.import_tab.TabIndex = 0;
            this.import_tab.Text = "Δεδομένα Εισόδου";
            this.import_tab.UseVisualStyleBackColor = true;
            // 
            // import_file_btn
            // 
            this.import_file_btn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.import_file_btn.Location = new System.Drawing.Point(178, 29);
            this.import_file_btn.Name = "import_file_btn";
            this.import_file_btn.Size = new System.Drawing.Size(75, 23);
            this.import_file_btn.TabIndex = 0;
            this.import_file_btn.Text = "Browse";
            this.import_file_btn.UseVisualStyleBackColor = false;
            this.import_file_btn.Click += new System.EventHandler(this.import_file_btn_Click);
            // 
            // sampling_tab
            // 
            this.sampling_tab.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.sampling_tab.Location = new System.Drawing.Point(130, 4);
            this.sampling_tab.Name = "sampling_tab";
            this.sampling_tab.Padding = new System.Windows.Forms.Padding(3);
            this.sampling_tab.Size = new System.Drawing.Size(545, 517);
            this.sampling_tab.TabIndex = 1;
            this.sampling_tab.Text = "Δειγματοληψία";
            this.sampling_tab.UseVisualStyleBackColor = true;
            this.sampling_tab.Click += new System.EventHandler(this.sampling_tab_Click);
            // 
            // report_tab
            // 
            this.report_tab.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.report_tab.Location = new System.Drawing.Point(130, 4);
            this.report_tab.Name = "report_tab";
            this.report_tab.Padding = new System.Windows.Forms.Padding(3);
            this.report_tab.Size = new System.Drawing.Size(545, 517);
            this.report_tab.TabIndex = 2;
            this.report_tab.Text = "Αναφορές";
            this.report_tab.UseVisualStyleBackColor = true;
            // 
            // import_file_lbl
            // 
            this.import_file_lbl.AutoSize = true;
            this.import_file_lbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_file_lbl.Location = new System.Drawing.Point(16, 29);
            this.import_file_lbl.Name = "import_file_lbl";
            this.import_file_lbl.Size = new System.Drawing.Size(143, 17);
            this.import_file_lbl.TabIndex = 1;
            this.import_file_lbl.Text = "Εισαγωγή Ερωτήσεων:";
            // 
            // Frm_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(679, 525);
            this.Controls.Add(this.main_form_tabs);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Generator ";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.main_form_tabs.ResumeLayout(false);
            this.import_tab.ResumeLayout(false);
            this.import_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl main_form_tabs;
        private System.Windows.Forms.TabPage import_tab;
        private System.Windows.Forms.TabPage sampling_tab;     
        private System.Windows.Forms.TabPage report_tab;
        private Button import_file_btn;
        private Label import_file_lbl;
    }
}