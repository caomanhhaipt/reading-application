namespace KimDung
{
    partial class BookMark
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnCencel = new System.Windows.Forms.Button();
            this.btnBookMark = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.rtbContent);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 249);
            this.panel1.TabIndex = 0;
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbContent.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContent.Location = new System.Drawing.Point(11, 12);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(517, 224);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // btnCencel
            // 
            this.btnCencel.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCencel.Location = new System.Drawing.Point(325, 255);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(87, 44);
            this.btnCencel.TabIndex = 1;
            this.btnCencel.Text = "Cancel";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBookMark
            // 
            this.btnBookMark.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookMark.Location = new System.Drawing.Point(434, 255);
            this.btnBookMark.Name = "btnBookMark";
            this.btnBookMark.Size = new System.Drawing.Size(108, 44);
            this.btnBookMark.TabIndex = 1;
            this.btnBookMark.Text = "BookMark";
            this.btnBookMark.UseVisualStyleBackColor = true;
            this.btnBookMark.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 299);
            this.Controls.Add(this.btnBookMark);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.panel1);
            this.Name = "BookMark";
            this.Text = "BookMark";
            this.Load += new System.EventHandler(this.BookMark_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Button btnBookMark;
    }
}