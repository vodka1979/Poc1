namespace WebView2App
{
    public partial class WebView2Form : Form
    {
        // ローカルパス（あなたの環境に応じて書き換えて）
        private string _localFilePath = @"C:\Git\Poc1\WebView2App\WebView2App\files";

        // UNCパス（あなたの環境に応じて書き換えて）
        private string _uncFilePath = @"\\GAIA-KSUZUKI\work";


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WebView2Form()
        {
            InitializeComponent();
           //aaaa
           //bbbb
        }


        #region URL指定読み込みの検証

        /// <summary>
        /// （URL指定）PDF読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://www.mhlw.go.jp/content/000813070.pdf");
        }

        /// <summary>
        /// （URL指定）jpg読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://ferret.akamaized.net/uploads/article/6740/eyecatch/default-aaba17b0f0f2f71adb795ed6117493af.jpg");

        }

        /// <summary>
        /// （URL指定）mp4読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://digitalnavi.net/wp-content/uploads/2018/11/SampleVideo_1280x720_1mb.mp4");
        }

        #endregion


        #region UNCパス読み込みの検証

        /// <summary>
        /// (UNCパス指定)PDF読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UNCPdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_uncFilePath, "MyPdfFile.pdf"));
        }

        /// <summary>
        /// (UNCパス指定)jpg読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UNCImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_uncFilePath, "MyJpgFile.jpg"));
        }

        /// <summary>
        /// (UNCパス指定)mp4読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UNCMovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_uncFilePath, "MyMp4File.mp4"));

        }

        #endregion


        #region 絶対パス読み込みの検証

        /// <summary>
        /// （ローカスパス指定）PDF読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyPdfFile.pdf"));
        }

        /// <summary>
        /// （ローカスパス指定）jpg読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyJpgFile.jpg"));
        }

        /// <summary>
        /// （ローカスパス指定）mp4読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalMovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyMp4File.mp4"));
        }

        /// <summary>
        /// （ローカルパス指定）pptxファイル読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPptxLoadButton_Click_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyPptxFile.pptx"));
        }

        /// <summary>
        /// （ローカルパス指定）pptファイル読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPptLoadButton_Click_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyPptFile.ppt"));
        }









        #endregion
    }
}