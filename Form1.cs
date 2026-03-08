namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            //R, G, B 값을 무작위로 생성, 배경색에 적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(255));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/pupuhang");
            //링크 클릭시 깃허브 페이지로 이동
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/pupuhang");
            //아이콘 클릭시 깃허브 페이지로 이동
        }


        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.new_pic;
            //버튼 클릭시 이미지 변경
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            //마우스가 이미지에 들어올 때 테두리 추가
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
            //마우스가 이미지에서 나갈 때 테두리 제거
        }
    }
}
