using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1, a2, a3, a4;
            a1 = "";
            a2 = "";
            a3 = "";
            if (radioButton1.Checked)
            {
                a1 = radioButton1.Text;
            }
            else if (radioButton2.Checked)
                a1 = radioButton2.Text;
            else if (radioButton3.Checked)
                a1 = radioButton3.Text;
            else if (radioButton4.Checked)
                a1 = radioButton4.Text;

                if (checkBox1.Checked)
                    a2 = a2 + checkBox1.Text + ";";
                if (checkBox2.Checked)
                    a2 = a2 +checkBox2.Text + ";";
                if (checkBox3.Checked)
                    a2 = a2 + checkBox3.Text + ";";
                if (checkBox4.Checked)
                    a2 = a2 + checkBox4.Text + ";";
            

            a3 = listBox1.SelectedItem.ToString();
            a4 = comboBox1.Text;
            listBox2.Items.Add("第一题答案：" + a1);
            listBox2.Items.Add("第二题答案：" + a2);
            listBox2.Items.Add("第三题答案：" + a3);
            listBox2.Items.Add("第四题答案：" + a4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
