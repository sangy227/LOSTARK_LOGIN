using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SangProJect
{
    
    
    public partial class Form1 : Form
    {
        string[] pathImage = { @"./image/back(1).jpg", @"./image/back(2).jpg", @"./image/back(3).jpg"
        , @"./image/back(4).jpg", @"./image/back(5).jpg", @"./image/back(6).jpg", @"./image/back(7).jpg", @"./image/back(8).jpg"
        , @"./image/back(9).jpg", @"./image/back(10).jpg", @"./image/back(11).jpg", @"./image/back(12).jpg", @"./image/back(13).jpg"
        , @"./image/back(14).jpg", @"./image/back(15).jpg", @"./image/back(16).jpg", @"./image/back(17).jpg", @"./image/back(18).jpg"
        , @"./image/back(19).jpg", @"./image/back(20).jpg", @"./image/back(21).jpg", @"./image/back(22).jpg", @"./image/back(23).jpg"
        , @"./image/back(24).jpg", @"./image/back(25).jpg", @"./image/back(26).jpg", @"./image/back(27).jpg", @"./image/back(28).jpg"
        , @"./image/back(29).jpg", @"./image/back(30).jpg", @"./image/back(31).jpg", @"./image/back(32).jpg", @"./image/back(33).jpg"
        , @"./image/back(34).jpg", @"./image/back(35).jpg", @"./image/back(36).jpg", @"./image/back(37).jpg", @"./image/back(38).jpg"
        , @"./image/back(39).jpg", @"./image/back(40).jpg", @"./image/back(41).jpg", @"./image/back(42).jpg", @"./image/back(43).jpg"
        , @"./image/back(44).jpg", @"./image/back(45).jpg", @"./image/back(46).jpg", @"./image/back(47).jpg", @"./image/back(48).jpg"
        , @"./image/back(49).jpg", @"./image/back(50).jpg", @"./image/back(51).jpg", @"./image/back(52).jpg", @"./image/back(53).jpg"
        , @"./image/back(54).jpg", @"./image/back(55).jpg", @"./image/back(56).jpg", @"./image/back(57).jpg", @"./image/back(58).jpg"
        , @"./image/back(59).jpg", @"./image/back(60).jpg", @"./image/back(61).jpg", @"./image/back(62).jpg", @"./image/back(63).jpg"
        , @"./image/back(64).jpg", @"./image/back(65).jpg", @"./image/back(66).jpg", @"./image/back(67).jpg", @"./image/back(68).jpg"
        , @"./image/back(69).jpg", @"./image/back(70).jpg", @"./image/back(71).jpg", @"./image/back(72).jpg", @"./image/back(73).jpg"
        , @"./image/back(74).jpg", @"./image/back(75).jpg", @"./image/back(76).jpg", @"./image/back(77).jpg", @"./image/back(78).jpg"
        , @"./image/back(79).jpg", @"./image/back(80).jpg", @"./image/back(81).jpg", @"./image/back(82).jpg", @"./image/back(83).jpg"
        , @"./image/back(84).jpg", @"./image/back(85).jpg", @"./image/back(86).jpg", @"./image/back(87).jpg", @"./image/back(88).jpg"
        , @"./image/back(89).jpg", @"./image/back(90).jpg"};
        int imagecur = 0;
        public Form1()
        {
            InitializeComponent();
            System.Timers.Timer _timer = new System.Timers.Timer(60);
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.bgm1);
            player.Play();

            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;

            radioButton1.BackColor = Color.Transparent;
            radioButton1.Parent = pictureBox1;

            radioButton2.BackColor = Color.Transparent;
            radioButton2.Parent = pictureBox1;

            radioButton3.BackColor = Color.Transparent;
            radioButton3.Parent = pictureBox1;

            button1.BackColor = Color.Transparent;
            button1.Parent = pictureBox1;
        }

       
        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.pictureBox1.Image = System.Drawing.Image.FromFile(pathImage[imagecur++]);
            imagecur = imagecur++ % pathImage.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.AddOwnedForm(f2);

            f2.Show();
            if (radioButton1.Checked)
            {
                f2.Result("루페온");
            }
            else if (radioButton2.Checked)
            {
                f2.Result("실리안");

            }
            else if (radioButton3.Checked)
            {
                f2.Result("니나브");
            }
            else
                f2.Result("서버 X");
        }
    }
}
