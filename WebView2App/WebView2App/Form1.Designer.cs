namespace WebView2App
{
    partial class WebView2Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PdfLoadButton = new System.Windows.Forms.Button();
            this.MyWebView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ImgLoadButton = new System.Windows.Forms.Button();
            this.MovLoadButton = new System.Windows.Forms.Button();
            this.UNCMovLoadButton = new System.Windows.Forms.Button();
            this.UNCImgLoadButton = new System.Windows.Forms.Button();
            this.UNCPdfLoadButton = new System.Windows.Forms.Button();
            this.LocalMovLoadButton = new System.Windows.Forms.Button();
            this.LocalImgLoadButton = new System.Windows.Forms.Button();
            this.LocalPdfLoadButton = new System.Windows.Forms.Button();
            this.LocalPptxLoadButton_Click = new System.Windows.Forms.Button();
            this.LocalPptLoadButton_Click = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyWebView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PdfLoadButton
            // 
            this.PdfLoadButton.Location = new System.Drawing.Point(15, 15);
            this.PdfLoadButton.Name = "PdfLoadButton";
            this.PdfLoadButton.Size = new System.Drawing.Size(229, 80);
            this.PdfLoadButton.TabIndex = 0;
            this.PdfLoadButton.Text = "PDF (URL）";
            this.PdfLoadButton.UseVisualStyleBackColor = true;
            this.PdfLoadButton.Click += new System.EventHandler(this.PdfLoadButton_Click);
            // 
            // MyWebView2
            // 
            this.MyWebView2.AllowExternalDrop = true;
            this.MyWebView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWebView2.CreationProperties = null;
            this.MyWebView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MyWebView2.Location = new System.Drawing.Point(22, 292);
            this.MyWebView2.Name = "MyWebView2";
            this.MyWebView2.Size = new System.Drawing.Size(1263, 805);
            this.MyWebView2.TabIndex = 1;
            this.MyWebView2.ZoomFactor = 1D;
            // 
            // ImgLoadButton
            // 
            this.ImgLoadButton.Location = new System.Drawing.Point(251, 15);
            this.ImgLoadButton.Name = "ImgLoadButton";
            this.ImgLoadButton.Size = new System.Drawing.Size(229, 80);
            this.ImgLoadButton.TabIndex = 2;
            this.ImgLoadButton.Text = "JPG (URL)";
            this.ImgLoadButton.UseVisualStyleBackColor = true;
            this.ImgLoadButton.Click += new System.EventHandler(this.ImgLoadButton_Click);
            // 
            // MovLoadButton
            // 
            this.MovLoadButton.Location = new System.Drawing.Point(487, 15);
            this.MovLoadButton.Name = "MovLoadButton";
            this.MovLoadButton.Size = new System.Drawing.Size(229, 80);
            this.MovLoadButton.TabIndex = 3;
            this.MovLoadButton.Text = "MP4 (URL）";
            this.MovLoadButton.UseVisualStyleBackColor = true;
            this.MovLoadButton.Click += new System.EventHandler(this.MovLoadButton_Click);
            // 
            // UNCMovLoadButton
            // 
            this.UNCMovLoadButton.Location = new System.Drawing.Point(487, 105);
            this.UNCMovLoadButton.Name = "UNCMovLoadButton";
            this.UNCMovLoadButton.Size = new System.Drawing.Size(229, 80);
            this.UNCMovLoadButton.TabIndex = 6;
            this.UNCMovLoadButton.Text = "MP4 (UNCパス）";
            this.UNCMovLoadButton.UseVisualStyleBackColor = true;
            this.UNCMovLoadButton.Click += new System.EventHandler(this.UNCMovLoadButton_Click);
            // 
            // UNCImgLoadButton
            // 
            this.UNCImgLoadButton.Location = new System.Drawing.Point(251, 105);
            this.UNCImgLoadButton.Name = "UNCImgLoadButton";
            this.UNCImgLoadButton.Size = new System.Drawing.Size(229, 80);
            this.UNCImgLoadButton.TabIndex = 5;
            this.UNCImgLoadButton.Text = "JPG (UNCパス)";
            this.UNCImgLoadButton.UseVisualStyleBackColor = true;
            this.UNCImgLoadButton.Click += new System.EventHandler(this.UNCImgLoadButton_Click);
            // 
            // UNCPdfLoadButton
            // 
            this.UNCPdfLoadButton.Location = new System.Drawing.Point(15, 105);
            this.UNCPdfLoadButton.Name = "UNCPdfLoadButton";
            this.UNCPdfLoadButton.Size = new System.Drawing.Size(229, 80);
            this.UNCPdfLoadButton.TabIndex = 4;
            this.UNCPdfLoadButton.Text = "PDF (UNCパス）";
            this.UNCPdfLoadButton.UseVisualStyleBackColor = true;
            this.UNCPdfLoadButton.Click += new System.EventHandler(this.UNCPdfLoadButton_Click);
            // 
            // LocalMovLoadButton
            // 
            this.LocalMovLoadButton.Location = new System.Drawing.Point(487, 195);
            this.LocalMovLoadButton.Name = "LocalMovLoadButton";
            this.LocalMovLoadButton.Size = new System.Drawing.Size(229, 80);
            this.LocalMovLoadButton.TabIndex = 9;
            this.LocalMovLoadButton.Text = "MP4 (ローカルパス）";
            this.LocalMovLoadButton.UseVisualStyleBackColor = true;
            this.LocalMovLoadButton.Click += new System.EventHandler(this.LocalMovLoadButton_Click);
            // 
            // LocalImgLoadButton
            // 
            this.LocalImgLoadButton.Location = new System.Drawing.Point(251, 195);
            this.LocalImgLoadButton.Name = "LocalImgLoadButton";
            this.LocalImgLoadButton.Size = new System.Drawing.Size(229, 80);
            this.LocalImgLoadButton.TabIndex = 8;
            this.LocalImgLoadButton.Text = "JPG (ローカルパス)";
            this.LocalImgLoadButton.UseVisualStyleBackColor = true;
            this.LocalImgLoadButton.Click += new System.EventHandler(this.LocalImgLoadButton_Click);
            // 
            // LocalPdfLoadButton
            // 
            this.LocalPdfLoadButton.Location = new System.Drawing.Point(15, 195);
            this.LocalPdfLoadButton.Name = "LocalPdfLoadButton";
            this.LocalPdfLoadButton.Size = new System.Drawing.Size(229, 80);
            this.LocalPdfLoadButton.TabIndex = 7;
            this.LocalPdfLoadButton.Text = "PDF (ローカルパス）";
            this.LocalPdfLoadButton.UseVisualStyleBackColor = true;
            this.LocalPdfLoadButton.Click += new System.EventHandler(this.LocalPdfLoadButton_Click);
            // 
            // LocalPptxLoadButton_Click
            // 
            this.LocalPptxLoadButton_Click.Location = new System.Drawing.Point(724, 195);
            this.LocalPptxLoadButton_Click.Name = "LocalPptxLoadButton_Click";
            this.LocalPptxLoadButton_Click.Size = new System.Drawing.Size(229, 80);
            this.LocalPptxLoadButton_Click.TabIndex = 10;
            this.LocalPptxLoadButton_Click.Text = "pptx (ローカルパス）";
            this.LocalPptxLoadButton_Click.UseVisualStyleBackColor = true;
            this.LocalPptxLoadButton_Click.Click += new System.EventHandler(this.LocalPptxLoadButton_Click_Click);
            // 
            // LocalPptLoadButton_Click
            // 
            this.LocalPptLoadButton_Click.Location = new System.Drawing.Point(960, 195);
            this.LocalPptLoadButton_Click.Name = "LocalPptLoadButton_Click";
            this.LocalPptLoadButton_Click.Size = new System.Drawing.Size(229, 80);
            this.LocalPptLoadButton_Click.TabIndex = 11;
            this.LocalPptLoadButton_Click.Text = "ppt (ローカルパス）";
            this.LocalPptLoadButton_Click.UseVisualStyleBackColor = true;
            this.LocalPptLoadButton_Click.Click += new System.EventHandler(this.LocalPptLoadButton_Click_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1024, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 112);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // WebView2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1122);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LocalPptLoadButton_Click);
            this.Controls.Add(this.LocalPptxLoadButton_Click);
            this.Controls.Add(this.LocalMovLoadButton);
            this.Controls.Add(this.LocalImgLoadButton);
            this.Controls.Add(this.LocalPdfLoadButton);
            this.Controls.Add(this.UNCMovLoadButton);
            this.Controls.Add(this.UNCImgLoadButton);
            this.Controls.Add(this.UNCPdfLoadButton);
            this.Controls.Add(this.MovLoadButton);
            this.Controls.Add(this.ImgLoadButton);
            this.Controls.Add(this.MyWebView2);
            this.Controls.Add(this.PdfLoadButton);
            this.Name = "WebView2Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyWebView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button PdfLoadButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 MyWebView2;
        private Button ImgLoadButton;
        private Button MovLoadButton;
        private Button UNCMovLoadButton;
        private Button UNCImgLoadButton;
        private Button UNCPdfLoadButton;
        private Button LocalMovLoadButton;
        private Button LocalImgLoadButton;
        private Button LocalPdfLoadButton;
        private Button LocalPptxLoadButton_Click;
        private Button LocalPptLoadButton_Click;
        private PictureBox pictureBox1;
    }
}