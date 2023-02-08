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
            ((System.ComponentModel.ISupportInitialize)(this.MyWebView2)).BeginInit();
            this.SuspendLayout();
            // 
            // PdfLoadButton
            // 
            this.PdfLoadButton.Location = new System.Drawing.Point(16, 16);
            this.PdfLoadButton.Name = "PdfLoadButton";
            this.PdfLoadButton.Size = new System.Drawing.Size(248, 85);
            this.PdfLoadButton.TabIndex = 0;
            this.PdfLoadButton.Text = "PDF読み込み";
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
            this.MyWebView2.Location = new System.Drawing.Point(24, 120);
            this.MyWebView2.Name = "MyWebView2";
            this.MyWebView2.Size = new System.Drawing.Size(1368, 834);
            this.MyWebView2.TabIndex = 1;
            this.MyWebView2.ZoomFactor = 1D;
            // 
            // ImgLoadButton
            // 
            this.ImgLoadButton.Location = new System.Drawing.Point(272, 16);
            this.ImgLoadButton.Name = "ImgLoadButton";
            this.ImgLoadButton.Size = new System.Drawing.Size(248, 85);
            this.ImgLoadButton.TabIndex = 2;
            this.ImgLoadButton.Text = "画像読み込み";
            this.ImgLoadButton.UseVisualStyleBackColor = true;
            this.ImgLoadButton.Click += new System.EventHandler(this.ImgLoadButton_Click);
            // 
            // MovLoadButton
            // 
            this.MovLoadButton.Location = new System.Drawing.Point(528, 16);
            this.MovLoadButton.Name = "MovLoadButton";
            this.MovLoadButton.Size = new System.Drawing.Size(248, 85);
            this.MovLoadButton.TabIndex = 3;
            this.MovLoadButton.Text = "動画読み込み";
            this.MovLoadButton.UseVisualStyleBackColor = true;
            this.MovLoadButton.Click += new System.EventHandler(this.MovLoadButton_Click);
            // 
            // WebView2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 980);
            this.Controls.Add(this.MovLoadButton);
            this.Controls.Add(this.ImgLoadButton);
            this.Controls.Add(this.MyWebView2);
            this.Controls.Add(this.PdfLoadButton);
            this.Name = "WebView2Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyWebView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button PdfLoadButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 MyWebView2;
        private Button ImgLoadButton;
        private Button MovLoadButton;
    }
}