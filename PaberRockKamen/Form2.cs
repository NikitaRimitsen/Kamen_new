using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaberRockKamen
{


    
    public partial class Form2 : Form
    {
        static string[] kartinkicel = { "kamen.jpg", "noznice.jpg", "bumaga.jpg" };
        static string[] kartinkibot = { "kamen.jpg", "noznice.jpg", "bumaga.jpg" };
        public Random rnd = new Random();  
        

        PictureBox ptb;
        PictureBox ptb2;
        Button btn;
        Label lbl;
        ListBox lb;
        public Form2()
        {

            this.Height = 700;//свойство высота формы
            this.Width = 1200;//свойство ширины формы, если это свойство то после, ставится =
            this.Text = "Botiga mängimine";//Text - название, заголовок формы
            this.BackColor = Color.Gainsboro;

            ptb = new PictureBox();//создали PictureBox
            ptb.Size = new Size(300, 200);
            ptb.Location = new Point(70, 100);//(x,y)
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb.Image = Image.FromFile(@"..\..\image\vopros.jpg");
            ptb.DoubleClick += Ptb_DoubleClick;

            ptb2 = new PictureBox();//создали PictureBox
            ptb2.Size = new Size(300, 200);
            ptb2.Location = new Point(830, 100);//(x,y)
            ptb2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb2.Image = Image.FromFile(@"..\..\image\vopros.jpg");


            btn = new Button();
            btn.BackColor = Color.Honeydew;//фон кнопки
            btn.Text = "Start";//текст внутри кнопки
            btn.Location = new Point(500, 100);//Point(x,y) - местоположение кнопки
            btn.Height = 60;//высота кнопки
            btn.Width = 180;//ширина кнопки
            btn.Click += Btn_Click;
            btn.Click += Btn_Click1;


            lbl = new Label();// создали Label
            lbl.Text = "0";
            lbl.Size = new Size(600, 200);//Size(width,height)
            lbl.Location = new Point(70, 25); //Point(x,y) - местоположение Label
            lbl.Font = new Font("Oswald", 16, FontStyle.Bold);

            lb = new ListBox();
            lb.Items.Add("Kivi");
            lb.Items.Add("Käärid");
            lb.Items.Add("Paber");
            lb.Location = new Point(150, 400);


            this.Controls.Add(lb);

            this.Controls.Add(ptb);
            this.Controls.Add(ptb2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);

        }


        private void Btn_Click1(object sender, EventArgs e)
        {

            if (kartinkicel[0] == kartinkibot[1])
            {
                MessageBox.Show("MessageBox", "Самое обычное окно");
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int randombot = rnd.Next(1, 4);
            /*string str1 = scetcik.ToString();
            lbl.Text = str1;*/

            //scetcik++;

            if (randombot == 1)
            {
                //string str1 = scetcik.ToString();
                ptb2.Image = Image.FromFile(@"..\..\image\"+ kartinkibot[0]);
                //lbl.Text = str1;
            }
            else if (randombot == 2)
            {

                ptb2.Image = Image.FromFile(@"..\..\image\"+ kartinkibot[1]);
            }
            else if (randombot == 3)
            {

                ptb2.Image = Image.FromFile(@"..\..\image\" + kartinkibot[2]);
            }


            /*if ( == kartinkibot[1])
            {
                MessageBox.Show("MessageBox", "Самое обычное окно");
            }*/
        }

        int scetcikkartinok = 0;
        private void Ptb_DoubleClick(object sender, EventArgs e)
        {
            scetcikkartinok++; //тут я увеличиваю значения счетчика на 1
            if (scetcikkartinok == 1)
            {
                
                //string str1 = scetcik.ToString();
                ptb.Image = Image.FromFile(@"..\..\image\"+ kartinkicel[0]);
                //lbl.Text = str1;
            }
            else if (scetcikkartinok == 2)
            {

                ptb.Image = Image.FromFile(@"..\..\image\"+ kartinkicel[1]);
            }
            else if (scetcikkartinok == 3)
            {

                scetcikkartinok = 0; //сбрасывает счетчик, что бы начать все заново
                ptb.Image = Image.FromFile(@"..\..\image\"+ kartinkicel[2]);
            }
        }
    }
}
