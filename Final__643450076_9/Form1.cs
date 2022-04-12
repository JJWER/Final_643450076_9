using System.Text;

namespace Final__643450076_9
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                string data = File.ReadAllText(filepath);
                this.textBox1.Text = data;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = this.textBox1.Text;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;
                File.WriteAllText(filepath, data, Encoding.UTF8);
            }
        }
        double a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
            num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, total, total2, total3;

        private void button4_Click(object sender, EventArgs e)
        {
            {
                f2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ปิดการทำงานแล้ว สวัสดีครับ");
            Close();
        }

        private void textBoxCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "12345")
                MessageBox.Show("โปรดใส่รหัสส่วนลด");
            else
            {
                MessageBox.Show("ใช่งานส่วนลดแล้ว");
                total2 = total * 5 / 100;
                total3 = total - total2;

                textBoxAll.Text = total3.ToString();

                textBoxCP.Text = total2.ToString();
                textBox12.Text = textBox10.Text;

            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                numericUpDown9.Enabled = true;
 
            }
            else
            {
  
                numericUpDown9.Enabled = false;
                numericUpDown9.Value = 0;

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                numericUpDown10.Enabled = true;

            }
            else
            {
  
                numericUpDown10.Enabled = false;
                numericUpDown10.Value = 0;
           
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                numericUpDown8.Enabled = true;
      
            }
            else
            {
                numericUpDown8.Enabled = false;
                numericUpDown8.Value = 1;
   
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                numericUpDown7.Enabled = true;
           
            }
            else
            {
                numericUpDown7.Enabled = false;
                numericUpDown7.Value = 1;
             
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                numericUpDown5.Enabled = true;
      
            }
            else
            {
                numericUpDown5.Enabled = false;
                numericUpDown5.Value = 1;
           
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                numericUpDown6.Enabled = true;
         
            }
            else
            {
                numericUpDown6.Enabled = false;
                numericUpDown6.Value = 1;
     
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown4.Enabled = true;
   
            }
            else
            {
                numericUpDown4.Enabled = false;
                numericUpDown4.Value = 1;
    
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown2.Enabled = true;
        
            }
            else
            {
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 1;
 
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown3.Enabled = true;
   
            }
            else
            {
                numericUpDown3.Enabled = false;
                numericUpDown3.Value = 1;
          
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
 
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 1;
 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            a5 = 0;
            a6 = 0;
            a7 = 0;
            a8 = 0;
            a9 = 0;
            a10 = 0;
            textBox2.Text = numericUpDown1.Value.ToString();
            textBox3.Text = numericUpDown2.Value.ToString();
            textBox4.Text = numericUpDown3.Value.ToString();
            textBox5.Text = numericUpDown4.Value.ToString();
            textBox6.Text = numericUpDown5.Value.ToString();
            textBox7.Text = numericUpDown6.Value.ToString();
            textBox8.Text = numericUpDown7.Value.ToString();
            textBox9.Text = numericUpDown8.Value.ToString();
            textBox10.Text = numericUpDown9.Value.ToString();
            textBox11.Text = numericUpDown10.Value.ToString();
            //check 1
            if (checkBox1.Checked)
            {
                b1 = double.Parse(textBox2.Text);
                a1 = 289;
                num1 = b1 * a1;
            }
            else
            {
                b1 = double.Parse(textBox2.Text);
                a1 = 289;
                num1 = b1 * a1;
            }
            //check 2
            if (checkBox3.Checked)
            {
                b2 = double.Parse(textBox3.Text);
                a2 = 250;
                num2 = b2 * a2;
            }
            else
            {
                b2 = double.Parse(textBox3.Text);
                a2 = 289;
                num2 = b2 * a2;
            }
            //check 3
            if (checkBox2.Checked)
            {
                b3 = double.Parse(textBox4.Text);
                a3 = 399;
                num3 = b3 * a3;
            }
            else
            {
                b3 = double.Parse(textBox4.Text);
                a3 = 399;
                num3 = b3 * a3;
            }
            //check 4
            if (checkBox4.Checked)
            {
                b4 = double.Parse(textBox5.Text);
                a4 = 199;
                num4 = b4 * a4;
            }
            else
            {
                b4 = double.Parse(textBox5.Text);
                a4 = 289;
                num4 = b4 * a4;
            }
            //check 5
            if (checkBox5.Checked)
            {
                b5 = double.Parse(textBox7.Text);
                a5 = 20;
                num5 = b5 * a5;
            }
            else
            {
                b5 = double.Parse(textBox7.Text);
                a5 = 20;
                num1 = b5 * a5;
            }
            //check 6
            if (checkBox8.Checked)
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 59;
                num6 = b6 * a6;
            }
            else
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 59;
                num6 = b6 * a6;
            }
            //check 7
            if (checkBox6.Checked)
            {
                b7 = double.Parse(textBox8.Text);
                a7 = 69;
                num7 = b7 * a7;
            }
            else
            {
                b7 = double.Parse(textBox8.Text);
                a7 = 69;
                num7 = b7 * a7;
            }
            //check 8
            if (checkBox9.Checked)
            {
                b8 = double.Parse(textBox9.Text);
                a8 = 59;
                num8 = b8 * a8;
            }
            else
            {
                b8 = double.Parse(textBox9.Text);
                a8 = 59;
                num8 = b8 * a8;
            }
            //check 9
            if (checkBox7.Checked)
            {
                b9 = double.Parse(textBox11.Text);
                a9 = 15;
                num9 = b9 * a9;
            }
            else
            {
                b9 = double.Parse(textBox11.Text);
                a9 = 15;
                num9 = b9 * a9;
            }
            //check 10
            if (checkBox10.Checked)
            {
                b10 = double.Parse(textBox10.Text);
                a10 = 89;
                num10 = b10 * a10;
            }
            else
            {
                b10 = double.Parse(textBox10.Text);
                a10 = 89;
                num1 = b10 * a10;
            }
            total = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
            textBoxTotal.Text = total.ToString();

               
        }
    }
}