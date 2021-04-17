using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Menu
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            wplayer.settings.volume = 10;
            wplayer.URL = "M1OST.mp3";
            wplayer.controls.play();
            TimerForward.Interval = 10;
            TimerForward.Tick += TimerForward_Tick;
            TimerBackward.Interval = 10;
            TimerBackward.Tick += TimerBackward_Tick;
        }
        Timer TimerForward = new Timer();//Таймер для анимации движения вперед
        Timer TimerBackward = new Timer();//Таймер для анимации движения назад
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();//Проигрыватель
        int VolumeValue = 10;//Начальная громкость OST
        private void Game_Load(object sender, EventArgs e)
        {
            Components_Delete();
            #region Кнопки
            Button Start = new Button();
            Button Exit = new Button();
            Button Options = new Button();

            Start.Location = new Point(400, 320);
            Start.Size = new Size(160, 80);
            Start.Text = "Начать игру";
            Start.BackColor = Color.White;
            Start.ForeColor = Color.Black;
            Start.TabStop = false;

            Options.Location = new Point(560,320);
            Options.Size = new Size(160, 80);
            Options.Text = "Настройки";
            Options.BackColor = Color.White;
            Options.ForeColor = Color.Black;
            Options.TabStop = false;

            Exit.Location = new Point(720, 320);
            Exit.Size = new Size(160, 80);
            Exit.Text = "Выйти из игры";
            Exit.BackColor = Color.White;
            Exit.ForeColor = Color.Black;
            Exit.TabStop = false;
            #endregion

            #region Добавление в контролы
            this.Controls.Add(Start);
            this.Controls.Add(Options);
            this.Controls.Add(Exit);
            #endregion

            #region Обработчики событий
            Start.Click += new System.EventHandler(Start_Click);
            Exit.Click += new System.EventHandler(Exit_Click);
            Options.Click += new System.EventHandler(Options_Click);
            #endregion
        }//Загрузка игры
        public void Options_Click(object sender, EventArgs e)
        {
            Components_Delete();
            #region Кнопки
            Button volumeUp = new Button();
            Button volumeDown = new Button();
            Button back = new Button();

            volumeUp.Location = new Point(400, 320);
            volumeUp.Size = new Size(160, 80);
            volumeUp.Text = "Увеличить громкость";
            volumeUp.BackColor = Color.Black;
            volumeUp.ForeColor = Color.White;
            volumeUp.TabStop = false;

            volumeDown.Location = new Point(560, 320);
            volumeDown.Size = new Size(160, 80);
            volumeDown.Text = "Уменьшить громкость";
            volumeDown.BackColor = Color.Black;
            volumeDown.ForeColor = Color.White;
            volumeDown.TabStop = false;

            back.Location = new Point(720, 320);
            back.Size = new Size(160, 80);
            back.Text = "В главное меню";
            back.BackColor = Color.Black;
            back.ForeColor = Color.White;
            back.TabStop = false;
            #endregion

            #region Шкалы
            Bar volume = new Bar();
            volume.Location = new Point(400, 200);
            volume.Size = new Size(480, 50);
            volume.Value = VolumeValue;
            #endregion

            #region Добавление в контролы
            this.Controls.Add(volumeUp);
            this.Controls.Add(volumeDown);
            this.Controls.Add(back);
            this.Controls.Add(volume);
            #endregion

            #region Обработчики событий
            volumeUp.Click += new System.EventHandler(VolumeUp_Click);
            volumeDown.Click += new System.EventHandler(VolumeDown_Click);
            back.Click += new System.EventHandler(Back_Click);
            #endregion
        }//Настройки
        public void Start_Click(object sender, EventArgs e)
        {
            Components_Delete();
            #region Картинки
            PictureBox firstMob = new PictureBox();
            PictureBox secondMob = new PictureBox();
            PictureBox thirdMob = new PictureBox();
            PictureBox hero = new PictureBox();

            firstMob.Image = Image.FromFile("FirstMob.bmp");
            firstMob.Location = new Point(480, 180);
            firstMob.Size = new Size(80, 200);

            secondMob.Image = Image.FromFile("SecondMob.bmp");
            secondMob.Location = new Point (720, 180);
            secondMob.Size = new Size(80, 200);

            thirdMob.Image = Image.FromFile("ThirdMob.bmp");
            thirdMob.Location = new Point(960, 180);
            thirdMob.Size = new Size(80, 200);

            hero.Image = Image.FromFile("hero.png");
            hero.Location = new Point(240, 180);
            hero.Size = new Size(80, 200);
            #endregion

            #region Шкалы
            #endregion

            #region Кнопки
            Button attack = new Button();
            Button back = new Button();
            Button goForward = new Button();
            Button goBackward = new Button();

            back.Location = new Point(0, 0);
            back.Size = new Size(180, 90);
            back.Text = "Выйти в главное меню";
            back.Click += new System.EventHandler(Back_Click);

            goBackward.Location = new Point(150,480);
            goBackward.Size= new Size(180, 90);
            goBackward.Text = "Идти назад";
            goBackward.Click += new System.EventHandler(GoBackward);

            goForward.Location = new Point(950, 480);
            goForward.Size = new Size(180, 90);
            goForward.Text = "Идти вперед";
            goForward.Click += new System.EventHandler(GoForward);
            #endregion

            #region Добавление в контролы
            this.Controls.Add(hero);
            this.Controls.Add(firstMob);
            this.Controls.Add(secondMob);
            this.Controls.Add(thirdMob);
            this.Controls.Add(back);
            this.Controls.Add(goForward);
            this.Controls.Add(goBackward);
            #endregion

            MobPos = 0;
        }//Начало игры
        public Point Control0Location = new Point();//Первый контрол, который меняем
        public Point Control1Location = new Point();//Второй контрол, который меняем
        public int MobPos = 0;//Номер контрола, который меняем с героем
        public bool CurrentMob = false;//Флаг для движения назад
        public void GoForward(object sender, EventArgs e)
        {
            if (MobPos == 3)
                MobPos = 3;
            else
            if (CurrentMob == false)
                MobPos++;
            else CurrentMob = false;
            Control0Location = Controls[0].Location;
            Control1Location = Controls[MobPos].Location;
            TimerForward.Start();
        }//Движение вперед
        public void GoBackward(object sender, EventArgs e)
        {
            if (MobPos == 0)
                MobPos = 0;
            else
            if (MobPos == 1)
                MobPos = 1;
            else
            if (CurrentMob == true)
                MobPos--;
            CurrentMob = true;
            Control0Location = Controls[0].Location;
            Control1Location = Controls[MobPos].Location;
            TimerBackward.Start();
        }//Движение назад
        public void TimerForward_Tick(object sender, EventArgs e)
        {
            PictureBox c0 = Controls[0] as PictureBox;
            PictureBox c1 = Controls[MobPos] as PictureBox;
            if (c0.Location.X < Control1Location.X)
                c0.Location = new Point(c0.Location.X + 10, c0.Location.Y);
            else
            {
                TimerForward.Stop();
                Refresh();
            }
            if (c1.Location.X > Control0Location.X)
                c1.Location = new Point(c1.Location.X - 10, c1.Location.Y);
        }//Анимация движения вперед
        public void TimerBackward_Tick(object sender, EventArgs e)
        {
            PictureBox c0 = Controls[0] as PictureBox;
            PictureBox c1 = Controls[MobPos] as PictureBox;
            if (c0.Location.X > Control1Location.X)
                c0.Location = new Point(c0.Location.X - 10, c0.Location.Y);
            else
            {
                TimerBackward.Stop();
                Refresh();
            }
            if (c1.Location.X < Control0Location.X)
                c1.Location = new Point(c1.Location.X + 10, c1.Location.Y);
        }//Анимация движения назад
        public void Attack_Click(object sender, EventArgs e)
        {
        }//Атака
        public void VolumeUp_Click(object sender, EventArgs e)
        {
            Bar Volume = Controls[3] as Bar;
            if (wplayer.settings.volume < 100)
            {
                Volume.Step = 10;
                wplayer.settings.volume += 10;
                VolumeValue += 10;
                Volume.PerformStep();
            }
        }//Увеличение звука
        public void VolumeDown_Click(object sender, EventArgs e)
        {
            Bar Volume = Controls[3] as Bar;
            if (wplayer.settings.volume > 0)
            {
                Volume.Step = -10;
                wplayer.settings.volume -= 10;
                VolumeValue -= 10;
                Volume.PerformStep();
            }
        }//Уменьшение звука
        public void Back_Click(object sender, EventArgs e)
        {
            MobPos = 0;
            Game_Load(sender,e);
        }//Выход в главное меню
        public void Exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }//Выход из игры
        public void Components_Delete()
        {
            for (int i = Controls.Count-1; i >= 0; i--)
                Controls[i].Dispose();
        }//Удаление компонентов
    }
}
