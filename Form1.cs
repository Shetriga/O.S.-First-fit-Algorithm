using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_fit_Trial
{
    public partial class Form1 : Form
    {


        public class CActor
        {
            public int value;
            public int fittedone;

            public int flagfit;
        }

        public List<CActor> portions = new List<CActor>();

        public List<CActor> processes = new List<CActor>();



        public Form1()
        {
            InitializeComponent();
            this.Text = "MSA";
            //this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //MessageBox.Show("portions are" + portions[0].value + ", " + portions[1].value + ", " + portions[2].value + ", " + portions[3].value + ", " + portions[4].value);
        }

        void Create()
        {
            CActor pnn = new CActor();
            pnn.value = int.Parse(Firstvalue.Text);
            pnn.flagfit = 0;
            processes.Add(pnn);

            CActor pnn1 = new CActor();
            pnn1.value = int.Parse(Secondvalue.Text);
            pnn.flagfit = 0;
            processes.Add(pnn1);

            CActor pnn2 = new CActor();
            pnn.flagfit = 0;
            pnn2.value = int.Parse(Thirdvalue.Text);
            processes.Add(pnn2);

            CActor pnn3 = new CActor();
            pnn.flagfit = 0;
            pnn3.value = int.Parse(Fourthvalue.Text);
            processes.Add(pnn3);

            CActor pnn4 = new CActor();
            pnn4.value = int.Parse(textBox1.Text);
            portions.Add(pnn4);

            CActor pnn5 = new CActor();
            pnn5.value = int.Parse(textBox2.Text);
            portions.Add(pnn5);

            CActor pnn6 = new CActor();
            pnn6.value = int.Parse(textBox3.Text);
            portions.Add(pnn6);

            CActor pnn7 = new CActor();
            pnn7.value = int.Parse(textBox4.Text);
            portions.Add(pnn7);

            CActor pnn8 = new CActor();
            pnn8.value = int.Parse(textBox5.Text);
            portions.Add(pnn8);

            //MessageBox.Show("Processes are" + processes[0].value + ", " + processes[1].value + ", " + processes[2].value + ", " + processes[3].value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Create();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < processes.Count(); i++)
            {
                for (int j = 0; j < portions.Count(); j++)
                {
                    if (portions[j].value >= processes[i].value)
                    {
                        processes[i].flagfit = 1;
                        processes[i].fittedone = j;
                        portions[j].value = portions[j].value - processes[i].value;
                        break;
                    }
                }
            }

           // for (int i = 0; i < processes.Count(); i++)
            {

                //if (i == 0)
                {
                    if (processes[0].flagfit == 1)
                    {
                        label8.Text = "Process 1 is in portion number " + (processes[0].fittedone + 1).ToString();
                    }

                    if (processes[0].flagfit == 0)
                    {
                        label8.ForeColor = Color.Red;
                        label8.Text = "Process 1" + " must wait";
                    }
                }
                //if (i == 1)
                {
                    if (processes[1].flagfit == 1)
                    {
                        label9.Text = "Process 2 is in portion number " + (processes[1].fittedone + 1).ToString();
                    }

                    if (processes[1].flagfit == 0)
                    {
                        label9.ForeColor = Color.Red;
                        label9.Text = "Process 2" + " must wait";
                    }
                }

                //if (i == 2)
                {
                    if (processes[2].flagfit == 1)
                    {
                        label10.Text = "Process 3 is in portion number " + (processes[2].fittedone + 1).ToString();
                    }

                    if (processes[2].flagfit == 0)
                    {
                        label10.ForeColor = Color.Red;
                        label10.Text = "Process 3" + " must wait";
                    }
                }

                //if (i == 3)
                {
                    if (processes[3].flagfit == 1)
                    {
                        label11.Text = "Process 4 is in portion number " + (processes[3].fittedone + 1).ToString();
                    }

                    if (processes[3].flagfit == 0)
                    {
                        label11.ForeColor = Color.Red;
                        label11.Text = "Process 4" + " must wait";
                    }
                }
            }

            label12.Text = "Portion 1 = " + portions[0].value.ToString();
            label13.Text = "Portion 2 = " + portions[1].value.ToString();
            label14.Text = "Portion 3 = " + portions[2].value.ToString();
            label15.Text = "Portion 4 = " + portions[3].value.ToString();
            label16.Text = "Portion 5 = " + portions[4].value.ToString();

            //MessageBox.Show("portions are" + portions[0].value + ", " + portions[1].value + ", " + portions[2].value + ", " + portions[3].value + ", " + portions[4].value);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
