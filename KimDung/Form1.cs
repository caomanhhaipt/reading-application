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
        Label OverviewAHXD;
        Label OverviewTDDH;
        Label OverviewTNGH;
        Label OverviewTLBB;
        Label OverviewLDK;
        Label OverviewYTDLK;
        Label OverviewLTQ;
        Label OverviewBHK;
        Label OverviewHKH;
        Label OverviewBMKTP;
        Label OverviewPHNT;
        Label OverviewTSPH;
        Label OverviewTKACL;
        Label OverviewUUD;
        Label OverviewVNK;
        public Form1()
        {
            InitializeComponent();
            pnl1.Margin = new Padding(10, 10, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label AHXD = new Label();
            AHXD.Text = "";

            AHXD.Image = Properties.Resources.AHXD;
            AHXD.Size = new Size(Properties.Resources.AHXD.Width, Properties.Resources.AHXD.Height);
            AHXD.Margin = new Padding(10, 10, 0, 5);

            OverviewAHXD = CreateOverviewLable("Anh Hùng Xạ Điêu\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: Một trong những tiểu thuyết võ hiệp của Kim Dung được đánh giá cao, được Hương Cảng Thương Báo xuất bản năm 1957. Đây là tiểu thuyết đầu tiên của Xạ Điêu Tam Bộ Khúc. Kim Dung đã chỉnh sửa tất cả các tác phẩm của mình bao gồm tiểu thuyết này vào những năm 1970 và một lần nữa vào những năm 2000.");
            OverviewAHXD.Size = new Size(600, Properties.Resources.AHXD.Height);

            Label TDDH = new Label();
            TDDH.Text = "";

            TDDH.Image = Properties.Resources.TDDH;
            TDDH.Size = new Size(Properties.Resources.TDDH.Width, Properties.Resources.TDDH.Height);
            TDDH.Margin = new Padding(10, 10, 0, 5);

            OverviewTDDH = CreateOverviewLable("Thần Điêu Đại Hiệp\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Full\n\n" +
                "Mô tả: Thần Điêu Đại Hiệp là phần hai trong bộ Xạ điêu tam bộ khúc, được đánh giá là tiểu thuyết võ hiệp viết về tình yêu hay nhất của Kim Dung. Bối cảnh của Thần Điêu Đại Hiệp là vào cuối thời Nam Tống, khi quân Mông Cổ đã lớn mạnh, tiêu diệt hầu hết châu Á, châu Âu, đang trực tiếp uy hiếp an nguy của Nam Tống");
            OverviewTDDH.Size = new Size(600, Properties.Resources.TDDH.Height);

            Label TNGH = new Label();
            TNGH.Text = "";

            TNGH.Image = Properties.Resources.TNGH;
            TNGH.Size = new Size(Properties.Resources.TNGH.Width, Properties.Resources.TNGH.Height);
            TNGH.Margin = new Padding(10, 10, 0, 5);

            OverviewTNGH = CreateOverviewLable("Tiếu ngạo giang hồ\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Nội dung bộ truyện xoay quanh những đề tài về tình bạn, tình yêu, sự dối trá, phản bội, những âm mưu và cả ham muốn quyền lực");
            OverviewTNGH.Size = new Size(600, Properties.Resources.TNGH.Height);

            Label TLBB = new Label();
            TLBB.Text = "";

            TLBB.Image = Properties.Resources.TLBB;
            TLBB.Size = new Size(Properties.Resources.TLBB.Width, Properties.Resources.TLBB.Height);
            TLBB.Margin = new Padding(10, 10, 0, 5);

            OverviewTLBB = CreateOverviewLable("Thiên Long Bát Bộ\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Câu chuyện xoay quanh mối quan hệ phức tạp giữa nhiều nhân vật đến từ nhiều nước khác nhau: Kiều Phong, Đoàn Dự, Hư Trúc. Với tác phẩm này, Kim Dung muốn nói đến mối quan hệ nhân - quả giữa chính bản thân các nhân vật với gia đình, xã hội, dân tộc, đất nước");
            OverviewTLBB.Size = new Size(600, Properties.Resources.AHXD.Height);

            Label LDK = new Label();
            LDK.Text = "";

            LDK.Image = Properties.Resources.LDK;
            LDK.Size = new Size(Properties.Resources.LDK.Width, Properties.Resources.LDK.Height);
            LDK.Margin = new Padding(10, 10, 0, 5);

            OverviewLDK = CreateOverviewLable("Lộc đỉnh ký\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Câu chuyện xoay quanh một nhân vật chính có hình ảnh pha trộn giữa tốt xấu, thiện ác, đồng thời trọng tình nghĩa bạn bè, có chí hiến thân vì nước nhưng cũng tiểu nhân gian xảo, mưu mô thủ đoạn, sẵn sàng hại bạn khi cần bảo vệ lợi ích của mình tên gọi Vi Tiểu Bảo");
            OverviewLDK.Size = new Size(600, Properties.Resources.LDK.Height);

            Label YTDLK = new Label();
            YTDLK.Text = "";

            YTDLK.Image = Properties.Resources.YTDLK;
            YTDLK.Size = new Size(Properties.Resources.YTDLK.Width, Properties.Resources.YTDLK.Height);
            YTDLK.Margin = new Padding(10, 10, 0, 5);

            OverviewYTDLK = CreateOverviewLable("Ỷ thiên đồ long ký\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Truyện xoay quanh Trương Vô Kỵ và mối tình phức tạp với 4 cô gái, bên cạnh đó là những âm mưu thủ đoạn đầy máu tanh trên giang hồ nhằm chiếm đoạt hai món báu vật là Đồ Long đao và Ỷ Thiên kiếm, với lời đồn nếu tìm được bí mật trong đao kiếm sẽ hiệu triệu được thiên hạ");
            OverviewYTDLK.Size = new Size(600, Properties.Resources.YTDLK.Height);

            Label LTQ = new Label();
            LTQ.Text = "";

            LTQ.Image = Properties.Resources.LTQ;
            LTQ.Size = new Size(Properties.Resources.LTQ.Width, Properties.Resources.LTQ.Height);
            LTQ.Margin = new Padding(10, 10, 0, 5);

            OverviewLTQ = CreateOverviewLable("Liên Thành Quyết\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Nội dung truyện kể về cuộc phiêu lưu của chàng Địch Vân giữa sóng gió giang hồ, nơi đang tranh giành một bí kíp võ công cùng với một kho báu vật trị giá liên thành.");
            OverviewLTQ.Size = new Size(600, Properties.Resources.LTQ.Height);

            Label BHK = new Label();
            BHK.Text = "";

            BHK.Image = Properties.Resources.BHK;
            BHK.Size = new Size(Properties.Resources.BHK.Width, Properties.Resources.BHK.Height);
            BHK.Margin = new Padding(10, 10, 0, 5);

            OverviewBHK = CreateOverviewLable("Bích huyết kiếm\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Cuối đời nhà Minh, triều đình mục nát, gian thần hoành hành, dân tình thống khổ. Viên đại tướng quân bị tên thái giám gian tặc Ngụy Trung Hiền hãm hại mà thác oan. Các bộ tướng của ông hết lòng phụ tá con ông là Viên Thừa Chí , ước mong một ngày nào đó giang sơn sẽ yên bình trở lại");
            OverviewBHK.Size = new Size(600, Properties.Resources.BHK.Height);

            Label HKH = new Label();
            HKH.Text = "";

            HKH.Image = Properties.Resources.HKH;
            HKH.Size = new Size(Properties.Resources.HKH.Width, Properties.Resources.HKH.Height);
            HKH.Margin = new Padding(10, 10, 0, 5);

            OverviewHKH = CreateOverviewLable("Hiệp khách hành\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Câu truyện xoay quanh các cuộc phiêu lưu của Thạch Phá Thiên, xoay quanh bài thơ 'Hiệp khách hành' của thi tiên Lý Bạch. Hiệp khách hành là câu chuyện hoàn toàn không có sự liên hệ với lịch sử, với những tình tiết mang tính chất mờ ảo, thần thoại");
            OverviewHKH.Size = new Size(600, Properties.Resources.AHXD.Height);

            Label BMKTP = new Label();
            BMKTP.Text = "";

            BMKTP.Image = Properties.Resources.BMKTP;
            BMKTP.Size = new Size(Properties.Resources.BMKTP.Width, Properties.Resources.BMKTP.Height);
            BMKTP.Margin = new Padding(10, 10, 0, 5);

            OverviewBMKTP = CreateOverviewLable("Bạch mã khiếu tây phong\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Câu chuyện nói về hành trình lưu lạc của Lý Văn Tú, con gái của Bạch Mã Lý Tam và Kim Ngân Tiểu Kiếm Tam Nương Tử (Thượng Quan Hồng)");
            OverviewBMKTP.Size = new Size(600, Properties.Resources.BMKTP.Height);

            Label PHNT = new Label();
            PHNT.Text = "";

            PHNT.Image = Properties.Resources.PHNT;
            PHNT.Size = new Size(Properties.Resources.PHNT.Width, Properties.Resources.PHNT.Height);
            PHNT.Margin = new Padding(10, 10, 0, 5);

            OverviewPHNT = CreateOverviewLable("Phi hổ ngoại truyện\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Với những tình tiết gây cấn Phi hồ ngoại truyện đấu trí giữ các thế lực lớn trong giang hồ tranh đoạt địa vị");
            OverviewPHNT.Size = new Size(600, Properties.Resources.PHNT.Height);

            Label TSPH = new Label();
            TSPH.Text = "";

            TSPH.Image = Properties.Resources.TSPH;
            TSPH.Size = new Size(Properties.Resources.TSPH.Width, Properties.Resources.TSPH.Height);
            TSPH.Margin = new Padding(10, 10, 0, 5);

            OverviewTSPH = CreateOverviewLable("Tuyết sơn phi hồ\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Diễn biến chính của tiểu thuyết này diễn ra vào thời đại nhà Thanh dưới triều vua Càn Long, nhưng các tình tiết câu chuyện lại được kéo dài từ thời đại nhà Đại Thuận dưới triều Lý Tự Thành, và bắt đầu của nhà Thanh dưới lời kể của một số nhân vật");
            OverviewTSPH.Size = new Size(600, Properties.Resources.TSPH.Height);

            Label TKACL = new Label();
            TKACL.Text = "";

            TKACL.Image = Properties.Resources.TKACL;
            TKACL.Size = new Size(Properties.Resources.TKACL.Width, Properties.Resources.TKACL.Height);
            TKACL.Margin = new Padding(10, 10, 0, 5);

            OverviewTKACL = CreateOverviewLable("Thư kiếm ân cừu lục\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Tình tiết của truyện xoay quanh cuộc phiêu liêu giải cứu Văn Thái Lai, mà qua đó, Trần gia Lạc tình cờ gặp gỡ rồi ra tay giúp một bộ lạc người Hồi truy nã đoàn xe của Trấn Viễn tiêu cục, đoạt lại thánh vật là bộ kinh Koran");
            OverviewTKACL.Size = new Size(600, Properties.Resources.AHXD.Height);

            Label UUD = new Label();
            UUD.Text = "";

            UUD.Image = Properties.Resources.UUD;
            UUD.Size = new Size(Properties.Resources.UUD.Width, Properties.Resources.UUD.Height);
            UUD.Margin = new Padding(10, 10, 0, 5);

            OverviewUUD = CreateOverviewLable("Uyên ương đao\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Uyên Ương Ðao là một cặp đao báu, ai chiếm được Uyên Ương Đao có thể xưng bá võ lâm. Là một trong mười bốn tuyệt tác của Kim Dung nhưng truyện rất ngắn, chỉ có ý nghĩa đối với bản thân tác giả, vì đây là tác phẩm đầu đời của ông");
            OverviewUUD.Size = new Size(600, Properties.Resources.UUD.Height);

            Label VNK = new Label();
            VNK.Text = "";

            VNK.Image = Properties.Resources.VNK;
            VNK.Size = new Size(Properties.Resources.VNK.Width, Properties.Resources.VNK.Height);
            VNK.Margin = new Padding(10, 10, 0, 5);

            OverviewVNK = CreateOverviewLable("Việt nữ kiếm\n\n" +
                "Tác giả: Kim Dung\n\n" +
                "Thể loại: Kiếm Hiệp\n\n" +
                "Tình trạng: Đang cập nhật\n\n" +
                "Mô tả: Câu chuyện xảy ra vào thời Chiến Quốc, sau khi Việt vương Câu Tiễn bại trận trước Ngô vương Phù Sai. Câu Tiễn thi hành chín chính sách diệt Ngô của Văn Chủng.");
            OverviewVNK.Size = new Size(600, Properties.Resources.VNK.Height);


            pnl1.Controls.Add(AHXD);
            pnl1.Controls.Add(OverviewAHXD);

            pnl1.Controls.Add(TDDH);
            pnl1.Controls.Add(OverviewTDDH);

            pnl1.Controls.Add(TNGH);
            pnl1.Controls.Add(OverviewTNGH);

            pnl1.Controls.Add(TLBB);
            pnl1.Controls.Add(OverviewTLBB);

            pnl1.Controls.Add(LDK);
            pnl1.Controls.Add(OverviewLDK);

            pnl1.Controls.Add(YTDLK);
            pnl1.Controls.Add(OverviewYTDLK);

            pnl1.Controls.Add(LTQ);
            pnl1.Controls.Add(OverviewLTQ);

            pnl1.Controls.Add(BHK);
            pnl1.Controls.Add(OverviewBHK);

            pnl1.Controls.Add(HKH);
            pnl1.Controls.Add(OverviewHKH);

            pnl1.Controls.Add(BMKTP);
            pnl1.Controls.Add(OverviewBMKTP);

            pnl1.Controls.Add(PHNT);
            pnl1.Controls.Add(OverviewPHNT);

            pnl1.Controls.Add(TSPH);
            pnl1.Controls.Add(OverviewTSPH);

            pnl1.Controls.Add(TKACL);
            pnl1.Controls.Add(OverviewTKACL);

            pnl1.Controls.Add(UUD);
            pnl1.Controls.Add(OverviewUUD);

            pnl1.Controls.Add(VNK);
            pnl1.Controls.Add(OverviewVNK);

            AHXD.Click += new EventHandler(AHXD_Click);
            TDDH.Click += new EventHandler(TDDH_Click);
            //TNGH.Click += new EventHandler(TNGH_Click);
            //TLBB.Click += new EventHandler(TLBB_Click);
            //LDK.Click += new EventHandler(LDK_Click);
            //YTDLK.Click += new EventHandler(YTDLK_Click);
            //LTQ.Click += new EventHandler(LTQ_Click);
        }

        private Label CreateOverviewLable(string overview)
        {
            Label label = new Label();

            label.Font = new Font("Arial", 13);
            label.Text = overview;
            //label.Size = new Size(600, Properties.Resources.name.Height);
            label.Margin = new Padding(10, 25, 0, 5);

            return label;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            OverviewAHXD.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewTDDH.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewTNGH.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewTLBB.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewLDK.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewYTDLK.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewLTQ.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewBHK.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewHKH.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewBMKTP.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewPHNT.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewTSPH.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewTKACL.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewUUD.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
            OverviewVNK.Size = new Size(this.Width - 300, Properties.Resources.AHXD.Height);
        }

        private void AHXD_Click(object sender, EventArgs e)
        {
            Form2 Contain = new Form2(1, "Anh Hùng Xạ Điêu");
            this.Hide();
            Contain.ShowDialog();
            this.Show();
        }

        private void TDDH_Click(object sender, EventArgs e)
        {
            Form2 Contain = new Form2(2, "Thần Điêu Đại Hiệp");
            this.Hide();
            Contain.ShowDialog();
            this.Show();
        }

        private void TNGH_Click(object sender, EventArgs e)
        {
            Form2 Contain = new Form2(3, "Tiếu Ngạo Giang Hồ");
            this.Hide();
            Contain.ShowDialog();
            this.Show();
        }
    }
}
