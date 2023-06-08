using System.Diagnostics.Eventing.Reader;

namespace fukuv0608
{
    public partial class Form1 : Form
    {
        int vx = -5;
        int vy = -5;
        int labelnamber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            label1.Text = "label" + labelnamber.ToString();
            labelnamber++;

            if (label1.Top <= 0 || ClientSize.Height <= label1.Bottom)
                vy *= -2;
            if (label1.Left <= 0 || ClientSize.Width <= label1.Right)
                vx *= -2;
            if (50 < vx)
                vx = 50;
            if (50 < vy)
                vy = 50;

            // 授業-----

            // 変数mposを宣言して、マウスのフォーム座標を取り出す
            //// 1. MousePositionにマウス座標のスクリーン左上からのX、Yが入っている
            Text = $"{MousePosition.X},{MousePosition.Y}";

            //// 2. 変数fposを宣言して、PointToClient()でスクリーン座標をフォーム座標に変換
            var fpos = PointToClient(MousePosition);

            // ラベルに座標を表示
            //// 変換したフォーム座標は、fpos.X、fpos.Yで取り出せる
            label1.Text = $"{fpos.X},{fpos.Y}";

            // label2.Widthでラベルの幅
            // label2.Heightでラベルの高さ
            // マウスカーソルがLabel2の中央を指すようにする
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            // -----
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "田渕";
        }
    }
}