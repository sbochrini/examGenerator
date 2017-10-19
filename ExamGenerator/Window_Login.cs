using System;
using System.Windows.Forms;
using ExamKernel;
using System.Data.SQLite;



namespace ExamGenerator
{
    public partial class Window_Login : Form
    {
        private Label login_lbl;
        private TextBox username_textbox;
        private Label username_lbl;
        private Label pwd_lbl;
        private TextBox pwd_textbox;
        private Button login_btn;
        private Label login_error_lbl;
       
        public SQLiteDatabase database;
        public string username = "";
        public Window_Login()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.login_lbl = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.pwd_textbox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_error_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.Location = new System.Drawing.Point(12, 19);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(286, 27);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Είσοδος στο Exam Generator";
            //this.login_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.username_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.username_textbox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textbox.Location = new System.Drawing.Point(172, 101);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(160, 27);
            this.username_textbox.TabIndex = 1;
            // 
            // username_lbl
            // 
            this.username_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(67, 101);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(79, 19);
            this.username_lbl.TabIndex = 2;
            this.username_lbl.Text = "Username";
            //this.username_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwd_lbl.AutoSize = true;
            this.pwd_lbl.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_lbl.Location = new System.Drawing.Point(69, 149);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(77, 19);
            this.pwd_lbl.TabIndex = 3;
            this.pwd_lbl.Text = "Password";
            // 
            // pwd_textbox
            // 
            this.pwd_textbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pwd_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.pwd_textbox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_textbox.Location = new System.Drawing.Point(172, 144);
            this.pwd_textbox.Name = "pwd_textbox";
            this.pwd_textbox.PasswordChar = '*';
            this.pwd_textbox.Size = new System.Drawing.Size(160, 27);
            this.pwd_textbox.TabIndex = 4;
            this.pwd_textbox.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(185, 206);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(124, 34);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Είσοδος";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_error_lbl
            // 
            this.login_error_lbl.AutoSize = true;
            this.login_error_lbl.ForeColor = System.Drawing.Color.Red;
            this.login_error_lbl.Location = new System.Drawing.Point(182, 174);
            this.login_error_lbl.Name = "login_error_lbl";
            this.login_error_lbl.Size = new System.Drawing.Size(89, 13);
            this.login_error_lbl.TabIndex = 6;
            this.login_error_lbl.Text = "Λάθος στοιχεία!";
            this.login_error_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_error_lbl.Visible = false;
            // 
            // Window_Login
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(362, 252);
            this.Controls.Add(this.login_error_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pwd_textbox);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.login_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window_Login";
            this.Text = "Exam Generator";
            this.Load += new System.EventHandler(this.Window_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private string striplogin(string h)
        {
            h = h.Replace("'", "");
            h = h.Replace("\"", "");
            h = h.Replace(";", "");
            return h;
        }

         
          private void Window_Login_Load(object sender, EventArgs e)
          {
            username_textbox.Focus();
        }    

        private void login_btn_Click(object sender, EventArgs e)
        {
           username = "";
            string u = database.ExecuteScalar("select user_id from tbl_user where username='" + striplogin(username_textbox.Text) + "' and password='" + striplogin(pwd_textbox.Text) + "';");
            if (u != "")
            {
                username = username_textbox.Text;
                this.Close();
            }
            else
                login_error_lbl.Visible = true;
        }
        
    }
}