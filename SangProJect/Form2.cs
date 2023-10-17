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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            this.ClientSize = new Size(400, 163);

            ServerWait sw = new ServerWait();
            sw.StartServerWait(1000);
            sw.SetServerWaitValue(15000);
            sw.SetLocation(new Point(221, 76));
            this.Controls.Add(sw);

            
            
        }      

        public void Result(string v)
        {
            textBox1.Text = v;
        }

        class ServerWait : TextBox
        {
            Timer TimerServerWait = new Timer();
            Random Rnd = new Random();

            public ServerWait()
            {
                TimerServerWait.Tick += TimerServerWait_Tick;
                TimerServerWait.Interval = 1000;

                this.Text = "";
                this.ReadOnly = true;
                this.ForeColor = Color.Yellow;
                this.BackColor = Color.Black;
                this.Size = new Size(48, 22);
                this.Font = new Font(Font, FontStyle.Bold);
                this.TextAlign = HorizontalAlignment.Center;
            }

            public void StartServerWait(int interval)
            {
                TimerServerWait.Interval = interval;
                TimerServerWait.Start();
            }
            public void SetServerWaitValue(int v)
            {
                this.Text = v.ToString();
            }

            public void SetLocation(Point p)
            {
                this.Location = p;
            }

            private void TimerServerWait_Tick(object sender, EventArgs e)
            {
                
                int val = Int32.Parse(this.Text) - Rnd.Next(1,400);
                //에러뜸 에러뜸 에러뜸 에러뜸 에러뜸 하...
                this.Text = val.ToString();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CenterToParent();
            
        }

        
    }
}
