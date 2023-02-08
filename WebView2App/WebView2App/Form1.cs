namespace WebView2App
{
    public partial class WebView2Form : Form
    {
        public WebView2Form()
        {
            InitializeComponent();
        }


        /// <summary>
        /// âÊëúì«Ç›çûÇ›
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://cc-prod.scene7.com/is/image/CCProdAuthor/hero-png?$pjpeg$&jpegSize=200&wid=900");

        }

        /// <summary>
        /// ìÆâÊì«Ç›çûÇ›
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://digitalnavi.net/wp-content/uploads/2018/11/SampleVideo_1280x720_1mb.mp4");
        }

        /// <summary>
        /// PDFì«Ç›çûÇ›
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://www.mhlw.go.jp/content/000813070.pdf");
        }
    }
}