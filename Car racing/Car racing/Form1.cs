using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_racing
{
    public partial class Car_racing : Form
    {

        Random r = new Random();
        int x;
        int carspeed = 0;
        int counter_coin = 0;
        public Car_racing()
        {
             
            InitializeComponent();
            restart.Visible = false;
            over.Visible = false;
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carspeed);
            rock(carspeed);
            gameover();
            collectcoin();
            coin(carspeed);
        }
       
        void collectcoin()
        {
            //  đếm đồng xu 1
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {

                x = r.Next(0, 80);

                coin1.Location = new Point(x, 0);

                counter_coin++;
                label.Text = "Coins =" + counter_coin.ToString();
            }


            //đếm đồng xu 2
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                counter_coin++;
                label.Text = "Coins =" + counter_coin.ToString();
                x = r.Next(80, 120);

                coin2.Location = new Point(x, 0);


            }
         
           //đếm đồng xu 3
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                counter_coin++;
                label.Text = "Coins= " + counter_coin.ToString();

                x = r.Next(120, 200);

            
                coin3.Location = new Point(x, 0);


            }


            // đếm đồng xu 4
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                counter_coin++;
                label.Text = "Coins =" + counter_coin.ToString();
                x = r.Next(200, 290);

                coin4.Location = new Point(x, 0);


            }



        }
        void rock (int speed)
        {

            if (rock1.Top >= 500)
            {
                x = r.Next(0, 100);

                rock1.Location = new Point(x, 0);
            }
            else { rock1.Top += speed; }

            if (rock2.Top >= 500)
            {
                x = r.Next(110, 200);

                rock2.Location = new Point(x, 0);
            }
            else { rock2.Top += speed; }
                         
            if (rock3.Top >= 500)
            {
                x = r.Next(210, 280);
                
                rock3.Location = new Point(x, 0);
            }
            else { rock3.Top += speed; }
        }
        void moveline(int speed)
        {
            // vach 1
            if(pictureBox1.Top >=500)
            { pictureBox1.Top= 0;}
            else { pictureBox1.Top += speed;}

            // vach 2
            if (pictureBox2.Top >= 500)
            { pictureBox2.Top =0; }
            else { pictureBox2.Top +=speed;}
            
            // vach 3
            if (pictureBox3.Top >= 500)
            { pictureBox3.Top =0; }
            else { pictureBox3.Top += speed;}

            // vach 4
            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed;}



        }
        void coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 40);

               coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(90, 120);

                coin2.Location = new Point(x, 0);
            }
            else
            { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(180, 220);

                coin3.Location = new Point(x, 0);
            }
            else
            { coin3.Top += speed; }


            if (coin4.Top >= 500)
            {
                x = r.Next(260, 280);

               coin4.Location = new Point(x, 0);
            }
            else
            { coin4.Top += speed; }



        }
    

        void gameover()
        {
            if (car.Bounds.IntersectsWith(rock1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

                restart.Visible = true;
                
                
            }
            if (car.Bounds.IntersectsWith(rock2.Bounds))
            {
                timer1.Enabled = false;
                restart.Visible = true;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(rock3.Bounds))
            {
                restart.Visible = true;
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                // Giới hạn trái 
                if (car.Left > 0)
                {
                    // Xe chạy ngang bằng mũi tên trái 
                    car.Left += -15;
                }
            }

        
            if (e.KeyCode == Keys.Right)
            {
                // Giới hạn phải 
                if (car.Right < 290)
                {
                    // Xe chạy ngang bằng mũi tên trái 
                    car.Left += 15;
                }
            }

            // Tăng tốc xe bằng mũi tên lên 
            if (e.KeyCode == Keys.Up)
            {
                if(carspeed < 21)
                { carspeed++; }
            }

            // Tăng tốc xe bằng mũi tên xuống
            if (e.KeyCode == Keys.Down)
            {
                if (carspeed >0)
                { carspeed--; }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void coin_Click(object sender, EventArgs e)
        {
          
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();  
        }
    }
}
