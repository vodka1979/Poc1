namespace WebView2App
{
    public partial class WebView2Form : Form
    {
        // ���[�J���p�X�i���Ȃ��̊��ɉ����ď��������āj
        private string _localFilePath = @"C:\Git\Poc1\WebView2App\WebView2App\files";

        // UNC�p�X�i���Ȃ��̊��ɉ����ď��������āj
        private string _uncFilePath = @"\\GAIA-KSUZUKI\work";


        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public WebView2Form()
        {
            InitializeComponent();
           //aaaa
           //bbbb
        }


        #region URL�w��ǂݍ��݂̌���

        /// <summary>
        /// �iURL�w��jPDF�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://www.mhlw.go.jp/content/000813070.pdf");
        }

        /// <summary>
        /// �iURL�w��jjpg�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://ferret.akamaized.net/uploads/article/6740/eyecatch/default-aaba17b0f0f2f71adb795ed6117493af.jpg");

        }

        /// <summary>
        /// �iURL�w��jmp4�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(@"https://digitalnavi.net/wp-content/uploads/2018/11/SampleVideo_1280x720_1mb.mp4");
        }

        #endregion


        #region UNC�p�X�ǂݍ��݂̌���

        /// <summary>
        /// (UNC�p�X�w��)PDF�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UNCPdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_uncFilePath, "MyPdfFile.pdf"));
        }

        /// <summary>
        /// (UNC�p�X�w��)jpg�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UNCImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_uncFilePath, "MyJpgFile.jpg"));
        }

        /// <summary>
        /// (UNC�p�X�w��)mp4�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UNCMovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_uncFilePath, "MyMp4File.mp4"));

        }

        #endregion


        #region ��΃p�X�ǂݍ��݂̌���

        /// <summary>
        /// �i���[�J�X�p�X�w��jPDF�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPdfLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyPdfFile.pdf"));
        }

        /// <summary>
        /// �i���[�J�X�p�X�w��jjpg�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalImgLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyJpgFile.jpg"));
        }

        /// <summary>
        /// �i���[�J�X�p�X�w��jmp4�ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalMovLoadButton_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyMp4File.mp4"));
        }

        /// <summary>
        /// �i���[�J���p�X�w��jpptx�t�@�C���ǂݍ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocalPptxLoadButton_Click_Click(object sender, EventArgs e)
        {
            this.MyWebView2.Source = new Uri(Path.Combine(_localFilePath, "MyPptxFile.pptx"));
        }

        /// <summary>
        /// �i���[�J���p�X�w��jppt�t�@�C���ǂݍ���
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