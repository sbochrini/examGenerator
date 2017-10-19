using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamKernel;

namespace ExamGenerator
{
    public partial class Frm_Main : Form
    {
        SQLiteDatabase db = new SQLiteDatabase();
        public Frm_Main()
        {
            var LoginWindow = new Window_Login();
            LoginWindow.database = db;
            LoginWindow.ShowDialog();
            InitializeComponent();
            main_form_tabs.DrawItem += new DrawItemEventHandler(main_form_tabs_DrawItem);
            if (LoginWindow.username == "") Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void import_tab_Click(object sender, EventArgs e)
        {

        }

        private void sampling_tab_Click(object sender, EventArgs e)
        {

        }

        private void main_form_tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = main_form_tabs.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = main_form_tabs.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void import_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Επιλογή αρχείου xlsx";
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Excel documents|*.xls;*.xlsx";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                ExcelData exceldata = new ExcelData(dlg.FileName);
            }
        }
    }
}
