using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Threading;
using Controller;
using System.Text.RegularExpressions;
using Model;

namespace KimDung
{
    public partial class Form2 : Form
    {
        private string NameBook;
        private int Id;
        RichTextBox[] containChapter;
        string[] listContent;
        string[] listTitle;
        bool[] mark;
        Label[] title;
        ArrayList containResult;
        ArrayList containError;
        Label[] setting;
        private string backColor;
        private string color;
        private bool isMenu;

        public Form2(int Id, string Name)
        {
            this.Id = Id;
            this.NameBook = Name;
            InitializeComponent();
        }
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BT9KKC7;Initial Catalog=TruyenKimDung;Integrated Security=True");

        private void LoadData()
        {
            conn.Open();

            string sql = "SELECT * FROM CHAPTER WHERE id_book = " + Id;

            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            contain.Margin = new Padding(20, 20, 20, 20);
            contain.Padding = new Padding(10, 10, 10, 10);
            tbSearch.Font = new Font("Arial", 13);
            containSearch.BackColor = Color.Aqua;

            int countChapter = 0;

            foreach (DataRow row in dt.Rows)
            {
                countChapter++;
            }

            listContent = new string[countChapter];
            listTitle = new string[countChapter];
            containChapter = new RichTextBox[countChapter];
            title = new Label[countChapter];
            mark = new bool[countChapter];

            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                mark[index] = false;
                string title = "********************************************************************************\n"
                    + row["chapter"].ToString();
                string content = row["contain"].ToString();
                string result = title + "\n\n" + content;
                listContent[index] = result;
                listTitle[index] = row["chapter"].ToString();
                index++;
            }

            mark[0] = true;
            containChapter[0] = new RichTextBox();
            containChapter[0] = CreateContainChapter(listContent[0], listTitle[0]);

            contain.Controls.Add(containChapter[0]);

            contain.MouseWheel += new MouseEventHandler(Contain_MouseWhell);

            containIndex.Margin = new Padding(10, 10, 10, 10);
            for (int i = 0; i < countChapter; i++)
            {
                title[i] = new Label();
                title[i].Text = "Chapter " + (i + 1) + ": " + listTitle[i];
                title[i].Width = containIndex.Width + 100;
                title[i].Margin = new Padding(5, 5, 5, 5);
                title[i].Font = new Font("Arial", 11, FontStyle.Underline);
                title[i].ForeColor = Color.Blue;
                title[i].MouseMove += new MouseEventHandler(title_MouseMove);
                title[i].MouseClick += new MouseEventHandler(title_MouseClick);
                title[i].MouseLeave += new EventHandler(title_MouseLeave);
                containIndex.Controls.Add(title[i]);
            }

            conn.Close();

            btnSearch.Image = Properties.Resources.search;
            nameBook.Text = this.NameBook;
        }

        private void title_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            int index = 0;
            for (int i = 0; i < listTitle.Length; i++)
            {
                if (label.Text.Equals("Chapter " + (i + 1) + ": " + listTitle[i]))
                {
                    index = i;
                    break;
                }
            }

            contain.Controls.Clear();
            for (int i = 0; i < mark.Length; i++)
            {
                mark[i] = false;
            }
            if (containChapter[index] == null)
            {
                containChapter[index] = new RichTextBox();
                containChapter[index] = CreateContainChapter(listContent[index], listTitle[index]);
                contain.Controls.Add(containChapter[index]);
                mark[index] = true;
            }
            else
            {
                contain.Controls.Add(containChapter[index]);
                mark[index] = true;
            }
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void title_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void insertChapter()
        {
            int currentChapter = 0;
            int currentHeight = 0;
            int count = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                if (mark[i] == true)
                {
                    currentChapter = i;
                    try
                    {
                        currentHeight += containChapter[i].Height;
                    }
                    catch (Exception)
                    {

                    }
                    count += 1;
                }
            }
            if (currentChapter + 1 < mark.Length)
            {
                if (containChapter[currentChapter + 1] == null)
                {
                    if (contain.VerticalScroll.Value >= (currentHeight - 1000 * count))
                    {
                        containChapter[currentChapter + 1] = new RichTextBox();
                        containChapter[currentChapter + 1] = CreateContainChapter(listContent[currentChapter + 1], listTitle[currentChapter + 1]);
                        contain.Controls.Add(containChapter[currentChapter + 1]);
                        mark[currentChapter + 1] = true;
                    }
                }
                else
                {
                    if (contain.VerticalScroll.Value >= (currentHeight - 1000 * count))
                    {
                        contain.Controls.Add(containChapter[currentChapter + 1]);
                        mark[currentChapter + 1] = true;
                    }
                }
            }
        }

        private void Contain_MouseWhell(object sender, MouseEventArgs e)
        {
            if (contain.VerticalScroll.Value == 0)
            {
                int currentChapter = 0;
                for (int i = 1; i < mark.Length; i++)
                {
                    if (mark[i] == true)
                    {
                        currentChapter = i;
                        break;
                    }
                }

                if (currentChapter != 0)
                {
                    for (int i = 0; i < mark.Length; i++)
                    {
                        mark[i] = false;
                    }

                    mark[currentChapter - 1] = true;
                    contain.Controls.Clear();
                    if (containChapter[currentChapter - 1] == null)
                    {
                        containChapter[currentChapter - 1] = new RichTextBox();
                        containChapter[currentChapter - 1] = CreateContainChapter(listContent[currentChapter - 1], listTitle[currentChapter - 1]);
                        contain.Controls.Add(containChapter[currentChapter - 1]);
                    }

                    Thread test = new Thread(test1);
                    test.Start();
                }
            }
            else
            {
                insertChapter();
            }
        }

        private void Search_MouseWhell(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    containSearch.VerticalScroll.Value += 60;
                    containSearch.VerticalScroll.Value += 60;
                }
                else
                {
                    containSearch.VerticalScroll.Value -= 60;
                    containSearch.VerticalScroll.Value -= 60;
                }
            }
            catch (Exception) { }
        }

        private void chapter_MouseWhell(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                insertChapter();
                contain.VerticalScroll.Value += 60;
                contain.VerticalScroll.Value += 60;

            }
            else
            {
                if (contain.VerticalScroll.Value < 60)
                {
                    if (contain.VerticalScroll.Value == 0)
                    {
                        int currentChapter = 0;
                        for (int i = 1; i < mark.Length; i++)
                        {
                            if (mark[i] == true)
                            {
                                currentChapter = i;
                                break;
                            }
                        }

                        if (currentChapter != 0)
                        {
                            for (int i = 0; i < mark.Length; i++)
                            {
                                mark[i] = false;
                            }

                            mark[currentChapter - 1] = true;
                            contain.Controls.Clear();
                            if (containChapter[currentChapter - 1] == null)
                            {
                                containChapter[currentChapter - 1] = new RichTextBox();
                                containChapter[currentChapter - 1] = CreateContainChapter(listContent[currentChapter - 1], listTitle[currentChapter - 1]);
                                contain.Controls.Add(containChapter[currentChapter - 1]);
                            }
                            else
                            {
                                contain.Controls.Add(containChapter[currentChapter - 1]);
                            }

                            Thread test = new Thread(test1);
                            test.Start();
                        }
                    }
                    else
                    {
                        contain.VerticalScroll.Value = 0;
                    }
                }
                else
                {
                    contain.VerticalScroll.Value -= 60;
                    if (contain.VerticalScroll.Value < 60)
                    {
                        contain.VerticalScroll.Value = 0;
                    }
                    else
                    {
                        contain.VerticalScroll.Value -= 60;
                    }
                }

            }
        }

        private void InsertPreviewChapter()
        {
            int index = 0;
            for (int i = 1; i < mark.Length; i++)
            {
                if (mark[i] == true)
                {
                    index = i;
                    break;
                }
            }
        }

        private void test1()
        {
            contain.VerticalScroll.Value = contain.VerticalScroll.Maximum;
            contain.VerticalScroll.Value = contain.VerticalScroll.Maximum;
        }
        private RichTextBox CreateContainChapter(string content, string title)
        {
            RichTextBox returnContain = new RichTextBox();
            returnContain.ContentsResized += new ContentsResizedEventHandler(RichTextBox_ContentsResized);
            returnContain.MouseWheel += new MouseEventHandler(chapter_MouseWhell);
            returnContain.Font = new Font("Arial", 13);
            returnContain.Width = contain.Width - 40;

            returnContain.Text = content;
            if (backColor == "white")
            {
                returnContain.BackColor = Color.White;
            }
            else
            {
                returnContain.BackColor = Color.Black;
            }

            if(color == "white")
            {
                returnContain.ForeColor = Color.White;
            }
            else
            {
                returnContain.ForeColor = Color.Black;
            }

            returnContain.SelectionStart = 0;
            returnContain.SelectionLength = 81 + title.Length;
            returnContain.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
            returnContain.ScrollBars = RichTextBoxScrollBars.None;
            returnContain.ReadOnly = true;
            returnContain.BorderStyle = BorderStyle.None;

            return returnContain;
        }

        private void RichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            var richTextBox = (RichTextBox)sender;
            richTextBox.Width = e.NewRectangle.Width;
            richTextBox.Height = e.NewRectangle.Height;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isMenu = true;
            backColor = "white";
            color = "black";
            LoadData();
        }

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contain_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            ResultSearch search = new ResultSearch("", "", false);
            if (e.KeyValue == 13)
            {
                if (isMenu == true)
                {
                    Thread myFormThread = new Thread(delegate ()
                    {
                        Application.Run(new LoadingSearch());
                    });
                    myFormThread.SetApartmentState(ApartmentState.STA);
                    myFormThread.Start();
                    bool found = Search();
                    myFormThread.Abort();

                    Thread.Sleep(1000);
                    if (found == false)
                    {
                        NotFound notFound = new NotFound();
                        notFound.FormBorderStyle = FormBorderStyle.FixedDialog;
                        notFound.MaximizeBox = false;
                        notFound.MinimizeBox = false;
                        notFound.StartPosition = FormStartPosition.CenterScreen;
                        notFound.ShowDialog();
                    }
                    else
                    {
                        tbSearch.Text = "";
                    }
                }
                else
                {
                    Notification notification = new Notification();
                    notification.FormBorderStyle = FormBorderStyle.FixedDialog;
                    notification.MaximizeBox = false;
                    notification.MinimizeBox = false;
                    notification.StartPosition = FormStartPosition.CenterScreen;
                    notification.ShowDialog();
                }
            }
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            if (isMenu == true)
            {
                containIndex.Height = ClientRectangle.Height - 73;
                contain.Height = ClientRectangle.Height - 73;
                contain.Width = ClientRectangle.Width - ClientRectangle.Width / 2 + ClientRectangle.Width / 9;
                containSearch.Location = new Point(containIndex.Width + ClientRectangle.Width - ClientRectangle.Width / 2 + ClientRectangle.Width / 9 + 20, 69);

                containSearch.Width = ClientRectangle.Width - containIndex.Width - contain.Width - 30;
                containSearch.Height = ClientRectangle.Height - 73;
                containSearchError.Width = ClientRectangle.Width - 17;

                for (int i = 0; i < listContent.Length; i++)
                {
                    if (mark[i] == true)
                    {
                        containChapter[i].Width = contain.Width - 40;
                    }
                }

                if (containResult != null)
                {
                    for (int i = 0; i < containResult.Count; i++)
                    {
                        ((RichTextBox)containResult[i]).Width = containSearch.Width - 30;
                    }
                }

                btnSetting.Location = new Point(this.Width - 172, 0);
            }
            else
            {
                containSearchError.Width = ClientRectangle.Width - 17;
                contain.Width = ClientRectangle.Width - 19;
                btnSetting.Location = new Point(this.Width - 172, 0);
                contain.Height = ClientRectangle.Height - 73;
                for(int i = 0; i < containChapter.Length; i++)
                {
                    if(containChapter[i] != null)
                    {
                        containChapter[i].Width = contain.Width - 59;
                    }
                }
            }
        }

        private void checkError_Click(object sender, EventArgs e)
        {
            if (isMenu == true)
            {
                Thread myFormThread = new Thread(delegate ()
                {
                    Application.Run(new WaitingCheckError());
                });
                myFormThread.SetApartmentState(ApartmentState.STA);
                myFormThread.Start();

                if (containError == null)
                {
                    containSearch.Controls.Clear();
                    containResult = new ArrayList();

                    for (int i = 0; i < listContent.Length; i++)
                    {
                        if (containChapter[i] == null)
                        {
                            containChapter[i] = new RichTextBox();
                            containChapter[i] = CreateContainChapter(listContent[i], listTitle[i]);
                        }

                        RuleController ruleController = RuleController.IsError(containChapter[i].Text, i);

                        if (ruleController.CHAPTER != -1)
                        {
                            for (int j = 0; j < ruleController.ARRAYCONTENT.Count; j++)
                            {
                                RichTextBox result = new RichTextBox();
                                result.ContentsResized += new ContentsResizedEventHandler(RichTextBox_ContentsResized);
                                result.MouseWheel += new MouseEventHandler(Search_MouseWhell);
                                result.Font = new Font("Arial", 13);
                                result.Width = containSearch.Width - 30;

                                if (j == 0)
                                {
                                    result.Text = "Chapter " + (i + 1) + ":\n" + ruleController.ARRAYCONTENT[j].ToString();
                                }
                                else
                                {
                                    result.Text = "\n*********\n" + ruleController.ARRAYCONTENT[j].ToString();
                                }

                                result.BackColor = Color.White;
                                result.ScrollBars = RichTextBoxScrollBars.None;
                                result.ReadOnly = true;
                                result.BorderStyle = BorderStyle.None;

                                Error tmp = (Error)ruleController.CONTAINERROR[j];
                                for (int k = 0; k < tmp.ARRAYINDEX.Count; k++)
                                {
                                    result.SelectionStart = 11 + int.Parse(tmp.ARRAYINDEX[k].ToString());
                                    result.SelectionLength = int.Parse(tmp.ARRAYLEN[k].ToString());
                                    result.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
                                    result.SelectionColor = Color.Red;
                                }

                                containResult.Add(result);
                                containSearch.Controls.Add(result);
                            }
                        }
                    }

                    containError = new ArrayList();
                    for (int i = 0; i < containResult.Count; i++)
                    {
                        containError.Add(containResult[i]);
                    }
                }
                else
                {
                    for (int i = 0; i < containError.Count; i++)
                    {
                        containResult.Add(containError[i]);
                        containSearch.Controls.Add((RichTextBox)containError[i]);
                    }
                }

                myFormThread.Abort();
            }
            else
            {
                Notification notification = new Notification();
                notification.FormBorderStyle = FormBorderStyle.FixedDialog;
                notification.MaximizeBox = false;
                notification.MinimizeBox = false;
                notification.StartPosition = FormStartPosition.CenterScreen;
                notification.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isMenu == true)
            {
                Thread myFormThread = new Thread(delegate ()
                {
                    Application.Run(new LoadingSearch());
                });
                myFormThread.SetApartmentState(ApartmentState.STA);
                myFormThread.Start();
                bool found = Search();
                myFormThread.Abort();

                Thread.Sleep(1000);
                if (found == false)
                {
                    NotFound notFound = new NotFound();
                    notFound.FormBorderStyle = FormBorderStyle.FixedDialog;
                    notFound.MaximizeBox = false;
                    notFound.MinimizeBox = false;
                    notFound.StartPosition = FormStartPosition.CenterScreen;
                    notFound.ShowDialog();
                }
                else
                {
                    tbSearch.Text = "";
                }
            }
            else
            {
                Notification notification = new Notification();
                notification.FormBorderStyle = FormBorderStyle.FixedDialog;
                notification.MaximizeBox = false;
                notification.MinimizeBox = false;
                notification.StartPosition = FormStartPosition.CenterScreen;
                notification.ShowDialog();
            }
        }

        private bool Search()
        {
            ResultSearch search = new ResultSearch("", "", false);
            containSearch.Controls.Clear();
            containResult = new ArrayList();

            bool mark = false;
            for (int index = 0; index < listTitle.Length; index++)
            {
                if (containChapter[index] == null)
                {
                    containChapter[index] = new RichTextBox();
                    containChapter[index] = CreateContainChapter(listContent[index], listTitle[index]);
                }

                search = ResultSearch.Search(tbSearch.Text, containChapter[index].Text, index);

                if (!search.CONTENT.Equals("") && search.PRIORITIZE == true)
                {

                    mark = true;
                    ArrayList arrayIndex = new ArrayList();
                    ArrayList arrayLen = new ArrayList();

                    Regex correct = new Regex(search.CORRECT);
                    foreach (Match item in correct.Matches(search.CONTENT.ToUpper()))
                    {
                        arrayIndex.Add(item.Index);
                        arrayLen.Add(item.Length);
                    }

                    RichTextBox result = new RichTextBox();
                    result.ContentsResized += new ContentsResizedEventHandler(RichTextBox_ContentsResized);
                    result.MouseWheel += new MouseEventHandler(Search_MouseWhell);
                    result.Font = new Font("Arial", 13);
                    result.Width = containSearch.Width - 30;

                    result.Text = search.CONTENT;
                    result.BackColor = Color.White;
                    result.ScrollBars = RichTextBoxScrollBars.None;
                    result.ReadOnly = true;
                    result.BorderStyle = BorderStyle.None;

                    for (int i = 0; i < arrayLen.Count; i++)
                    {
                        result.SelectionStart = int.Parse(arrayIndex[i].ToString());
                        result.SelectionLength = int.Parse(arrayLen[i].ToString());
                        result.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
                    }

                    containResult.Add(result);
                    containSearch.Controls.Add(result);
                }
            }

            for (int index = 0; index < listTitle.Length; index++)
            {
                if (containChapter[index] == null)
                {
                    containChapter[index] = new RichTextBox();
                    containChapter[index] = CreateContainChapter(listContent[index], listTitle[index]);
                }

                search = ResultSearch.Search(tbSearch.Text, containChapter[index].Text, index);

                if (!search.CONTENT.Equals("") && search.PRIORITIZE == false)
                {

                    mark = true;
                    ArrayList arrayIndex = new ArrayList();
                    ArrayList arrayLen = new ArrayList();

                    Regex correct = new Regex(search.CORRECT);
                    foreach (Match item in correct.Matches(search.CONTENT.ToUpper()))
                    {
                        arrayIndex.Add(item.Index);
                        arrayLen.Add(item.Length);
                    }

                    RichTextBox result = new RichTextBox();
                    result.ContentsResized += new ContentsResizedEventHandler(RichTextBox_ContentsResized);
                    result.MouseWheel += new MouseEventHandler(Search_MouseWhell);
                    result.Font = new Font("Arial", 13);
                    result.Width = containSearch.Width - 30;

                    result.Text = search.CONTENT;
                    result.BackColor = Color.White;
                    result.ScrollBars = RichTextBoxScrollBars.None;
                    result.ReadOnly = true;
                    result.BorderStyle = BorderStyle.None;

                    for (int i = 0; i < arrayLen.Count; i++)
                    {
                        result.SelectionStart = int.Parse(arrayIndex[i].ToString());
                        result.SelectionLength = int.Parse(arrayLen[i].ToString());
                        result.SelectionFont = new Font("Arial", 13, FontStyle.Bold);
                    }

                    containResult.Add(result);
                    containSearch.Controls.Add(result);
                }
            }

            return mark;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("Cài đặt"))
            {
                containSearch.Controls.Clear();
                containSearch.BackColor = Color.Aqua;

                if (setting == null)
                {
                    setting = new Label[8];

                    setting[0] = new Label();
                    setting[0].Text = "Màu nền";
                    setting[0].Margin = new Padding(5, 5, 5, 5);
                    setting[0].Font = new Font("Arial", 11, FontStyle.Bold);

                    setting[1] = new Label();
                    setting[1].Text = "";
                    setting[1].Name = "blackBackColor";
                    setting[1].Image = Properties.Resources.black;
                    setting[1].Margin = new Padding(5, 5, 5, 5);
                    setting[1].Size = new Size(Properties.Resources.black.Width, Properties.Resources.black.Height);
                    setting[1].MouseClick += new MouseEventHandler(SetColor);
                    setting[1].MouseMove += new MouseEventHandler(title_MouseMove);
                    setting[1].MouseLeave += new EventHandler(title_MouseLeave);

                    setting[2] = new Label();
                    setting[2].Text = "";
                    setting[2].Name = "whiteBackColor";
                    setting[2].Image = Properties.Resources.white;
                    setting[2].Margin = new Padding(5, 5, 5, 5);
                    setting[2].Size = new Size(Properties.Resources.white.Width, Properties.Resources.white.Height);
                    setting[2].MouseClick += new MouseEventHandler(SetColor);
                    setting[2].MouseMove += new MouseEventHandler(title_MouseMove);
                    setting[2].MouseLeave += new EventHandler(title_MouseLeave);

                    setting[3] = new Label();
                    setting[3].Text = "Màu chữ";
                    setting[3].Margin = new Padding(5, 5, 5, 5);
                    setting[3].Font = new Font("Arial", 11, FontStyle.Bold);

                    setting[4] = new Label();
                    setting[4].Text = "";
                    setting[4].Name = "blackColor";
                    setting[4].Image = Properties.Resources.black;
                    setting[4].Margin = new Padding(5, 5, 5, 5);
                    setting[4].Size = new Size(Properties.Resources.black.Width, Properties.Resources.black.Height);
                    setting[4].MouseClick += new MouseEventHandler(SetColor);
                    setting[4].MouseMove += new MouseEventHandler(title_MouseMove);
                    setting[4].MouseLeave += new EventHandler(title_MouseLeave);

                    setting[5] = new Label();
                    setting[5].Text = "";
                    setting[5].Name = "whiteColor";
                    setting[5].Image = Properties.Resources.white;
                    setting[5].Margin = new Padding(5, 5, 5, 5);
                    setting[5].Size = new Size(Properties.Resources.white.Width, Properties.Resources.white.Height);
                    setting[5].MouseClick += new MouseEventHandler(SetColor);
                    setting[5].MouseMove += new MouseEventHandler(title_MouseMove);
                    setting[5].MouseLeave += new EventHandler(title_MouseLeave);

                    setting[6] = new Label();
                    setting[6].Text = "Cài mặc định";
                    setting[6].Name = "setDefault";
                    setting[6].Width = containSearch.Width - 20;
                    setting[6].Margin = new Padding(5, 5, 5, 5);
                    setting[6].Font = new Font("Arial", 11, FontStyle.Bold);
                    setting[6].MouseClick += new MouseEventHandler(SetColor);
                    setting[6].MouseMove += new MouseEventHandler(title_MouseMove);
                    setting[6].MouseLeave += new EventHandler(title_MouseLeave);

                    setting[7] = new Label();
                    setting[7].Text = "Ẩn menu";
                    setting[7].Width = containSearch.Width - 20;
                    setting[7].Margin = new Padding(5, 5, 5, 5);
                    setting[7].Font = new Font("Arial", 11, FontStyle.Bold);
                    setting[7].MouseClick += new MouseEventHandler(HideMenu);
                    setting[7].MouseMove += new MouseEventHandler(title_MouseMove);
                    setting[7].MouseLeave += new EventHandler(title_MouseLeave);
                }

                for (int i = 0; i < setting.Length; i++)
                {
                    containSearch.Controls.Add(setting[i]);
                }
            }
            else
            {
                containIndex.Height = ClientRectangle.Height - 73;
                containIndex.Show();
                contain.Location = new Point(227, 69);
                contain.Height = ClientRectangle.Height - 73;
                contain.Width = ClientRectangle.Width - ClientRectangle.Width / 2 + ClientRectangle.Width / 9;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].Width = contain.Width - 40;
                    }
                }

                containSearch.Location = new Point(containIndex.Width + ClientRectangle.Width - ClientRectangle.Width / 2 + ClientRectangle.Width / 9 + 20, 69);
                containSearch.Height = ClientRectangle.Height - 73;
                containSearch.Width = ClientRectangle.Width - containIndex.Width - contain.Width - 30;
                containSearch.Show();

                isMenu = true;
                btnSetting.Text = "Cài đặt";
            }
        }

        private void HideMenu(object sender, MouseEventArgs e)
        {
            containIndex.Hide();
            containSearch.Hide();
            contain.Location = new Point(7, 69);
            contain.Width = ClientRectangle.Width - 19;
            for(int i = 0; i < containChapter.Length; i++)
            {
                if(containChapter[i] != null)
                {
                    containChapter[i].Width = contain.Width - 40;
                }
            }

            isMenu = false;
            btnSetting.Text = "Menu";
        }

        private void SetColor(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;

            if (label.Name.Equals("blackBackColor"))
            {
                containSearchError.BackColor = Color.Black;
                contain.BackColor = Color.Black;
                this.BackColor = Color.White;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].BackColor = Color.Black;
                    }
                }
                containIndex.BackColor = Color.Black;
                backColor = "black";
            }
            else if (label.Name.Equals("whiteBackColor"))
            {
                containSearchError.BackColor = Color.White;
                contain.BackColor = Color.White;
                this.BackColor = Color.Black;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].BackColor = Color.White;
                    }
                }
                containIndex.BackColor = Color.White;
                backColor = "white";
            }
            else if (label.Name.Equals("blackColor"))
            {
                containSearchError.ForeColor = Color.Black;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].ForeColor = Color.Black;
                    }
                }
                for(int i = 0; i < title.Length; i++)
                {
                    title[i].ForeColor = Color.Black;
                }

                color = "black";
            }
            else if(label.Name.Equals("whiteColor"))
            {
                containSearchError.ForeColor = Color.White;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].ForeColor = Color.White;
                    }
                }
                for (int i = 0; i < title.Length; i++)
                {
                    title[i].ForeColor = Color.White;
                }

                color = "white";
            }
            else
            {
                containSearchError.BackColor = Color.White;
                contain.BackColor = Color.White;
                this.BackColor = Color.Black;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].BackColor = Color.White;
                    }
                }
                containIndex.BackColor = Color.White;
                backColor = "white";

                containSearchError.ForeColor = Color.Black;
                for (int i = 0; i < containChapter.Length; i++)
                {
                    if (containChapter[i] != null)
                    {
                        containChapter[i].ForeColor = Color.Black;
                    }
                }
                for (int i = 0; i < title.Length; i++)
                {
                    title[i].ForeColor = Color.Blue;
                }

                color = "black";
            }
        }
    }
}
