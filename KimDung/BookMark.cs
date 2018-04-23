using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KimDung
{
    public partial class BookMark : Form
    {
        private int Chapter;
        private string Content;
        private int IdBook;

        public BookMark()
        {
            InitializeComponent();
        }

        public BookMark(int chapter, string content, int idBook)
        {
            this.Chapter = chapter;
            this.IdBook = idBook;
            this.Content = content;

            InitializeComponent();
        }

        private void BookMark_Load(object sender, EventArgs e)
        {
            rtbContent.Text = Content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BT9KKC7;Initial Catalog=TruyenKimDung;Integrated Security=True");
            conn.Open();

            string sql = "INSERT INTO [BOOKMARK](chapter, content, id_book)" + 
                "VALUES(" + this.Chapter + ", N'" + this.Content + "'," + this.IdBook + ")";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                int a = cmd.ExecuteNonQuery();

                if(a > 0)
                {
                    Notification notification = new Notification("Đánh dấu thành công", "Đã cập nhật vào danh sách");
                    notification.FormBorderStyle = FormBorderStyle.FixedDialog;
                    notification.MaximizeBox = false;
                    notification.MinimizeBox = false;
                    notification.StartPosition = FormStartPosition.CenterScreen;
                    notification.ShowDialog();

                    btnBookMark.Enabled = false;
                }
                else
                {
                    Notification notification = new Notification("Đánh dấu thất bại", "Vui lòng thử lại");
                    notification.FormBorderStyle = FormBorderStyle.FixedDialog;
                    notification.MaximizeBox = false;
                    notification.MinimizeBox = false;
                    notification.StartPosition = FormStartPosition.CenterScreen;
                    notification.ShowDialog();
                }
            }catch (Exception)
            {
                Notification notification = new Notification("Đánh dấu thất bại", "Vui lòng thử lại");
                notification.FormBorderStyle = FormBorderStyle.FixedDialog;
                notification.MaximizeBox = false;
                notification.MinimizeBox = false;
                notification.StartPosition = FormStartPosition.CenterScreen;
                notification.ShowDialog();
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
