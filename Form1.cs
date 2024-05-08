namespace 倒數計時器
{
    public partial class Form1 : Form
    {
        private int secondsLeft;//宣告一個整數變數來儲存剩餘秒數
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secondsLeft = 100;//設定倒數的秒數從100開始
            label1.Text = secondsLeft.ToString();//更新label1上的秒數。將整數變數secondsLeft轉換成字串形式，才能將label1的秒數顯示出來
            timer1.Start();//啟動計時器

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsLeft--;//每次計時器觸發時，秒數就減少一秒
            label1.Text = secondsLeft.ToString();//更新label1上的秒數。將整數變數secondsLeft轉換成字串形式，才能將label1的秒數顯示出來
            if (secondsLeft <= 0)//如果時間到達100秒時
            {
                timer1.Stop();//停止計時器
                MessageBox.Show("時間到！");//顯示訊息「時間到!」
            }
        }
    }
}