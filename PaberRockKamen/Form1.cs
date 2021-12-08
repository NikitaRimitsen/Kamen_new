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
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Button btn2;
        Button btn3;
        Label lbl;


        public Form1()
        {
            this.Height = 600;//свойство высота формы
            this.Width = 700;//свойство ширины формы, если это свойство то после, ставится =
            this.Text = "Rock Paper Scissors";//Text - название, заголовок формы
            this.BackColor = Color.Gainsboro;


            tree = new TreeView();
            tree.Dock = DockStyle.Top;
            tree.Width = 50;
            tree.AfterSelect += Tree_AfterSelect;


            MainMenu menu = new MainMenu();
            MenuItem menuFile = new MenuItem("Seaded");
            menuFile.MenuItems.Add("Teema", new EventHandler(menuFile_Tema_Select)).Shortcut = Shortcut.CtrlS;
            menuFile.MenuItems.Add("Exit", new EventHandler(menuFile_Exit_Select));
            //menuFile.MenuItems.Add("Размер", new EventHandler());
            //menuFile.MenuItems.Add("Postimees", new EventHandler());
            menu.MenuItems.Add(menuFile);

            this.Menu = menu;

            /*TreeNode tnnas = new TreeNode("Настройки");

            tnnas.Nodes.Add(new TreeNode("Цвет"));
            tnnas.Nodes.Add(new TreeNode("Шрифт"));
            tnnas.Nodes.Add(new TreeNode("Размер"));
            tnnas.Nodes.Add(new TreeNode("Выбор картинок"));*/

            /*tree.Nodes.Add(tnnas);//связались
            this.Controls.Add(tree);//добавляет в форму*/

            lbl = new Label();// создали Label
            lbl.Text = "Kivi Paber Käärid";
            lbl.Size = new Size(600, 200);//Size(width,height)
            lbl.Location = new Point(247, 25); //Point(x,y) - местоположение Label
            lbl.Font = new Font("Oswald", 16, FontStyle.Bold);


            btn = new Button();
            btn.BackColor = Color.Honeydew;//фон кнопки
            btn.Text = "Botiga mängimine";//текст внутри кнопки
            btn.Location = new Point(280, 100);//Point(x,y) - местоположение кнопки
            btn.Height = 60;//высота кнопки
            btn.Width = 120;//ширина кнопки
            btn.Click += Btn_Click;

            btn2 = new Button();
            btn2.BackColor = Color.Honeydew;//фон кнопки
            btn2.Text = "Mäng kahele";//текст внутри кнопки
            btn2.Location = new Point(280, 200);//Point(x,y) - местоположение кнопки
            btn2.Height = 60;//высота кнопки
            btn2.Width = 120;//ширина кнопки
            btn2.Click += Btn_Click2;

            btn3 = new Button();
            btn3.BackColor = Color.Honeydew;//фон кнопки
            btn3.Text = "Bot versus bot";//текст внутри кнопки
            btn3.Location = new Point(280, 300);//Point(x,y) - местоположение кнопки
            btn3.Height = 60;//высота кнопки
            btn3.Width = 120;//ширина кнопки
            btn3.Click += Btn_Click3;

            this.Controls.Add(btn);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(lbl);
        }
        private void Btn_Click3(object sender, EventArgs e)
        {
            BotvsBot form3 = new BotvsBot();
            form3.Show();
            this.Hide();
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            Form3mängu2 form3 = new Form3mängu2();
            form3.Show();
            this.Hide();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        //p1==v1[0]
        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        int scetcik = 0;
        private void menuFile_Tema_Select(object sender, EventArgs e)
        {
            scetcik++;
            if (scetcik == 1)
            {
                this.BackColor = Color.Black;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                btn2.ForeColor = Color.Black;
                btn2.BackColor = Color.White;
                btn3.ForeColor = Color.Black;
                btn3.BackColor = Color.White;
            }
            else if (scetcik == 2)
            {
                this.BackColor = Color.White;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.Black;
                btn2.ForeColor = Color.White;
                btn2.BackColor = Color.Black;
                btn3.ForeColor = Color.Black;
                btn3.BackColor = Color.White;
            }
            else if (scetcik == 3)
            {
                this.BackColor = Color.Gainsboro;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.Honeydew;
                btn2.ForeColor = Color.Black;
                btn2.BackColor = Color.White;
                btn3.ForeColor = Color.Black;
                btn3.BackColor = Color.White;
                scetcik = 0;
            }
        }

        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
            this.Close();
        }
        //Создание формы
        /*Form2 form2 = new Form2()
         form2.Show();*/
    }
}
