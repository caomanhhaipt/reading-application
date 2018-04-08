using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimDung
{
    public partial class Form1 : Form
    {
        Label lb12;
        Label lb22;
        Label lb32;
        Label lb42;
        Label lb52;
        Label lb62;
        Label lb72;
        Label lb82;
        Label lb92;
        Label lb102;
        Label lb112;
        Label lb122;
        Label lb132;
        Label lb142;
        Label lb152;
        public Form1()
        {
            InitializeComponent();
            pnl1.Margin = new Padding(10, 10, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotFound notFound = new NotFound();
            notFound.FormBorderStyle = FormBorderStyle.FixedDialog;
            notFound.MaximizeBox = false;
            notFound.MinimizeBox = false;
            notFound.StartPosition = FormStartPosition.CenterScreen;
            notFound.ShowDialog();

            Label lb1 = new Label();
            lb1.Text = "";

            lb1.Image = Properties.Resources._843;
            lb1.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb1.Margin = new Padding(10, 10, 0, 5);

            lb12 = new Label();
            lb12.Font = new Font("Arial", 13);
            lb12.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb12.Size = new Size(600, Properties.Resources._843.Height);
            lb12.Margin = new Padding(10, 25, 0, 5);

            Label lb2 = new Label();
            lb2.Text = "";

            lb2.Image = Properties.Resources._843;
            lb2.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb2.Margin = new Padding(10, 10, 0, 5);

            lb22 = new Label();
            lb22.Font = new Font("Arial", 13);
            lb22.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb22.Size = new Size(600, Properties.Resources._843.Height);
            lb22.Margin = new Padding(10, 25, 0, 5);

            Label lb3 = new Label();
            lb3.Text = "";

            lb3.Image = Properties.Resources._843;
            lb3.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb3.Margin = new Padding(10, 10, 0, 5);

            lb32 = new Label();
            lb32.Font = new Font("Arial", 13);
            lb32.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb32.Size = new Size(600, Properties.Resources._843.Height);
            lb32.Margin = new Padding(10, 25, 0, 5);

            Label lb4 = new Label();
            lb4.Text = "";

            lb4.Image = Properties.Resources._843;
            lb4.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb4.Margin = new Padding(10, 10, 0, 5);

            lb42 = new Label();
            lb42.Font = new Font("Arial", 13);
            lb42.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb42.Size = new Size(600, Properties.Resources._843.Height);
            lb42.Margin = new Padding(10, 25, 0, 5);

            Label lb5 = new Label();
            lb5.Text = "";

            lb5.Image = Properties.Resources._843;
            lb5.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb5.Margin = new Padding(10, 10, 0, 5);

            lb52 = new Label();
            lb52.Font = new Font("Arial", 13);
            lb52.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb52.Size = new Size(600, Properties.Resources._843.Height);
            lb52.Margin = new Padding(10, 25, 0, 5);
            Label lb6 = new Label();
            lb6.Text = "";

            lb6.Image = Properties.Resources._843;
            lb6.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb6.Margin = new Padding(10, 10, 0, 5);

            lb62 = new Label();
            lb62.Font = new Font("Arial", 13);
            lb62.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb62.Size = new Size(600, Properties.Resources._843.Height);
            lb62.Margin = new Padding(10, 25, 0, 5);

            Label lb7 = new Label();
            lb7.Text = "";

            lb7.Image = Properties.Resources._843;
            lb7.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb7.Margin = new Padding(10, 10, 0, 5);

            lb72 = new Label();
            lb72.Font = new Font("Arial", 13);
            lb72.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb72.Size = new Size(600, Properties.Resources._843.Height);
            lb72.Margin = new Padding(10, 25, 0, 5);

            Label lb8 = new Label();
            lb8.Text = "";

            lb8.Image = Properties.Resources._843;
            lb8.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb8.Margin = new Padding(10, 10, 0, 5);

            lb82 = new Label();
            lb82.Font = new Font("Arial", 13);
            lb82.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb82.Size = new Size(600, Properties.Resources._843.Height);
            lb82.Margin = new Padding(10, 25, 0, 5);

            Label lb9 = new Label();
            lb9.Text = "";

            lb9.Image = Properties.Resources._843;
            lb9.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb9.Margin = new Padding(10, 10, 0, 5);

            lb92 = new Label();
            lb92.Font = new Font("Arial", 13);
            lb92.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb92.Size = new Size(600, Properties.Resources._843.Height);
            lb92.Margin = new Padding(10, 25, 0, 5);

            Label lb10 = new Label();
            lb10.Text = "";

            lb10.Image = Properties.Resources._843;
            lb10.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb10.Margin = new Padding(10, 10, 0, 5);

            lb102 = new Label();
            lb102.Font = new Font("Arial", 13);
            lb102.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb102.Size = new Size(600, Properties.Resources._843.Height);
            lb102.Margin = new Padding(10, 25, 0, 5);

            Label lb11 = new Label();
            lb11.Text = "";

            lb11.Image = Properties.Resources._843;
            lb11.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb11.Margin = new Padding(10, 10, 0, 5);

            lb112 = new Label();
            lb112.Font = new Font("Arial", 13);
            lb112.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb112.Size = new Size(600, Properties.Resources._843.Height);
            lb112.Margin = new Padding(10, 25, 0, 5);

            Label lb120 = new Label();
            lb120.Text = "";

            lb120.Image = Properties.Resources._843;
            lb120.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb120.Margin = new Padding(10, 10, 0, 5);

            lb122 = new Label();
            lb122.Font = new Font("Arial", 13);
            lb122.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb122.Size = new Size(600, Properties.Resources._843.Height);
            lb122.Margin = new Padding(10, 25, 0, 5);

            Label lb13 = new Label();
            lb13.Text = "";

            lb13.Image = Properties.Resources._843;
            lb13.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb13.Margin = new Padding(10, 10, 0, 5);

            lb132 = new Label();
            lb132.Font = new Font("Arial", 13);
            lb132.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb132.Size = new Size(600, Properties.Resources._843.Height);
            lb132.Margin = new Padding(10, 25, 0, 5);

            Label lb14 = new Label();
            lb14.Text = "";

            lb14.Image = Properties.Resources._843;
            lb14.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb14.Margin = new Padding(10, 10, 0, 5);

            lb142 = new Label();
            lb142.Font = new Font("Arial", 13);
            lb142.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb142.Size = new Size(600, Properties.Resources._843.Height);
            lb142.Margin = new Padding(10, 25, 0, 5);

            Label lb15 = new Label();
            lb15.Text = "";

            lb15.Image = Properties.Resources._843;
            lb15.Size = new Size(Properties.Resources._843.Width, Properties.Resources._843.Height);
            lb15.Margin = new Padding(10, 10, 0, 5);

            lb152 = new Label();
            lb152.Font = new Font("Arial", 13);
            lb152.Text = "Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.";
            lb152.Size = new Size(600, Properties.Resources._843.Height);
            lb52.Margin = new Padding(10, 25, 0, 5);


            pnl1.Controls.Add(lb1);
            pnl1.Controls.Add(lb12);

            pnl1.Controls.Add(lb2);
            pnl1.Controls.Add(lb22);

            pnl1.Controls.Add(lb3);
            pnl1.Controls.Add(lb32);

            pnl1.Controls.Add(lb4);
            pnl1.Controls.Add(lb42);

            pnl1.Controls.Add(lb5);
            pnl1.Controls.Add(lb52);

            pnl1.Controls.Add(lb6);
            pnl1.Controls.Add(lb62);

            pnl1.Controls.Add(lb7);
            pnl1.Controls.Add(lb72);

            pnl1.Controls.Add(lb8);
            pnl1.Controls.Add(lb82);

            pnl1.Controls.Add(lb9);
            pnl1.Controls.Add(lb92);

            pnl1.Controls.Add(lb10);
            pnl1.Controls.Add(lb102);

            pnl1.Controls.Add(lb11);
            pnl1.Controls.Add(lb112);

            pnl1.Controls.Add(lb120);
            pnl1.Controls.Add(lb122);

            pnl1.Controls.Add(lb13);
            pnl1.Controls.Add(lb132);

            pnl1.Controls.Add(lb14);
            pnl1.Controls.Add(lb142);

            pnl1.Controls.Add(lb15);
            pnl1.Controls.Add(lb152);

            lb1.Click += new EventHandler(lb1_Click);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            lb12.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb22.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb32.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb42.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb52.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb62.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb72.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb82.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb92.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb102.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb112.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb122.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb132.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb142.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
            lb152.Size = new Size(this.Width - 300, Properties.Resources._843.Height);
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            Form2 Contain = new Form2(1);
            this.Hide();
            Contain.ShowDialog();
            this.Show();
        }
    }
}
