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

            // ����-----

            // �ϐ�mpos��錾���āA�}�E�X�̃t�H�[�����W�����o��
            //// 1. MousePosition�Ƀ}�E�X���W�̃X�N���[�����ォ���X�AY�������Ă���
            Text = $"{MousePosition.X},{MousePosition.Y}";

            //// 2. �ϐ�fpos��錾���āAPointToClient()�ŃX�N���[�����W���t�H�[�����W�ɕϊ�
            var fpos = PointToClient(MousePosition);

            // ���x���ɍ��W��\��
            //// �ϊ������t�H�[�����W�́Afpos.X�Afpos.Y�Ŏ��o����
            label1.Text = $"{fpos.X},{fpos.Y}";

            // label2.Width�Ń��x���̕�
            // label2.Height�Ń��x���̍���
            // �}�E�X�J�[�\����Label2�̒������w���悤�ɂ���
            label2.Left = fpos.X - label2.Width / 2;
            label2.Top = fpos.Y - label2.Height / 2;

            // -----
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "�c��";
        }
    }
}