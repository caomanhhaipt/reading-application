namespace KimDung
{
    partial class Form2
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
            this.contain = new System.Windows.Forms.FlowLayoutPanel();
            this.containIndex = new System.Windows.Forms.FlowLayoutPanel();
            this.containSearchError = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.containSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.checkError = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.containSearchError.SuspendLayout();
            this.SuspendLayout();
            // 
            // contain
            // 
            this.contain.AutoScroll = true;
            this.contain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contain.Location = new System.Drawing.Point(227, 69);
            this.contain.Name = "contain";
            this.contain.Size = new System.Drawing.Size(716, 607);
            this.contain.TabIndex = 0;
            this.contain.Scroll += new System.Windows.Forms.ScrollEventHandler(this.contain_Scroll);
            // 
            // containIndex
            // 
            this.containIndex.AutoScroll = true;
            this.containIndex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.containIndex.Location = new System.Drawing.Point(7, 6);
            this.containIndex.Name = "containIndex";
            this.containIndex.Size = new System.Drawing.Size(214, 670);
            this.containIndex.TabIndex = 1;
            // 
            // containSearchError
            // 
            this.containSearchError.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.containSearchError.Controls.Add(this.label1);
            this.containSearchError.Controls.Add(this.btnSearch);
            this.containSearchError.Controls.Add(this.checkError);
            this.containSearchError.Controls.Add(this.tbSearch);
            this.containSearchError.Location = new System.Drawing.Point(227, 6);
            this.containSearchError.Name = "containSearchError";
            this.containSearchError.Size = new System.Drawing.Size(921, 57);
            this.containSearchError.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(303, 3);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(363, 51);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // containSearch
            // 
            this.containSearch.AutoScroll = true;
            this.containSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.containSearch.Location = new System.Drawing.Point(949, 69);
            this.containSearch.Name = "containSearch";
            this.containSearch.Size = new System.Drawing.Size(199, 607);
            this.containSearch.TabIndex = 0;
            // 
            // checkError
            // 
            this.checkError.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkError.Location = new System.Drawing.Point(802, 0);
            this.checkError.Name = "checkError";
            this.checkError.Size = new System.Drawing.Size(119, 57);
            this.checkError.TabIndex = 1;
            this.checkError.Text = "Kiểm tra lỗi";
            this.checkError.UseVisualStyleBackColor = true;
            this.checkError.Click += new System.EventHandler(this.checkError_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(672, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 56);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anh hùng xạ điêu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1160, 684);
            this.Controls.Add(this.containSearch);
            this.Controls.Add(this.containSearchError);
            this.Controls.Add(this.containIndex);
            this.Controls.Add(this.contain);
            this.Location = new System.Drawing.Point(100, 10);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.containSearchError.ResumeLayout(false);
            this.containSearchError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel contain;
        private System.Windows.Forms.FlowLayoutPanel containIndex;
        private System.Windows.Forms.Panel containSearchError;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.FlowLayoutPanel containSearch;
        private System.Windows.Forms.Button checkError;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
    }
}