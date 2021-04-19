
namespace Descent_into_the_Dungeon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.map = new System.Windows.Forms.Panel();
            this.enemy7 = new System.Windows.Forms.PictureBox();
            this.enemy5 = new System.Windows.Forms.PictureBox();
            this.enemy6 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.mainHero = new System.Windows.Forms.PictureBox();
            this.mapPanel = new System.Windows.Forms.Panel();
            this.scrollBar = new System.Windows.Forms.Panel();
            this.scroll = new System.Windows.Forms.PictureBox();
            this.map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemy7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainHero)).BeginInit();
            this.mapPanel.SuspendLayout();
            this.scrollBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.BackColor = System.Drawing.SystemColors.Highlight;
            this.map.Controls.Add(this.enemy7);
            this.map.Controls.Add(this.enemy5);
            this.map.Controls.Add(this.enemy6);
            this.map.Controls.Add(this.enemy3);
            this.map.Controls.Add(this.enemy4);
            this.map.Controls.Add(this.enemy2);
            this.map.Controls.Add(this.enemy1);
            this.map.Controls.Add(this.mainHero);
            this.map.Location = new System.Drawing.Point(10, 6);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(380, 80);
            this.map.TabIndex = 0;
            // 
            // enemy7
            // 
            this.enemy7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy7.BackgroundImage")));
            this.enemy7.Location = new System.Drawing.Point(700, 0);
            this.enemy7.Name = "enemy7";
            this.enemy7.Size = new System.Drawing.Size(80, 80);
            this.enemy7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy7.TabIndex = 3;
            this.enemy7.TabStop = false;
            // 
            // enemy5
            // 
            this.enemy5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy5.BackgroundImage")));
            this.enemy5.Location = new System.Drawing.Point(500, 0);
            this.enemy5.Name = "enemy5";
            this.enemy5.Size = new System.Drawing.Size(80, 80);
            this.enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy5.TabIndex = 3;
            this.enemy5.TabStop = false;
            // 
            // enemy6
            // 
            this.enemy6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy6.BackgroundImage")));
            this.enemy6.Location = new System.Drawing.Point(600, 0);
            this.enemy6.Name = "enemy6";
            this.enemy6.Size = new System.Drawing.Size(80, 80);
            this.enemy6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy6.TabIndex = 2;
            this.enemy6.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy3.BackgroundImage")));
            this.enemy3.Location = new System.Drawing.Point(300, 0);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(80, 80);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 3;
            this.enemy3.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy4.BackgroundImage")));
            this.enemy4.Location = new System.Drawing.Point(400, 0);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(80, 80);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy4.TabIndex = 2;
            this.enemy4.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
            this.enemy2.Location = new System.Drawing.Point(200, 0);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(80, 80);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.enemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy1.BackgroundImage")));
            this.enemy1.Location = new System.Drawing.Point(100, 0);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(80, 80);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // mainHero
            // 
            this.mainHero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainHero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainHero.BackgroundImage")));
            this.mainHero.Location = new System.Drawing.Point(0, 0);
            this.mainHero.Name = "mainHero";
            this.mainHero.Size = new System.Drawing.Size(80, 80);
            this.mainHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainHero.TabIndex = 0;
            this.mainHero.TabStop = false;
            // 
            // mapPanel
            // 
            this.mapPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.mapPanel.Controls.Add(this.scrollBar);
            this.mapPanel.Controls.Add(this.map);
            this.mapPanel.Location = new System.Drawing.Point(438, 302);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(400, 100);
            this.mapPanel.TabIndex = 1;
            // 
            // scrollBar
            // 
            this.scrollBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.scrollBar.Controls.Add(this.scroll);
            this.scrollBar.Location = new System.Drawing.Point(10, 87);
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Size = new System.Drawing.Size(380, 8);
            this.scrollBar.TabIndex = 2;
            // 
            // scroll
            // 
            this.scroll.BackColor = System.Drawing.SystemColors.ControlDark;
            this.scroll.Location = new System.Drawing.Point(0, 0);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(20, 8);
            this.scroll.TabIndex = 3;
            this.scroll.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 437);
            this.Controls.Add(this.mapPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemy7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainHero)).EndInit();
            this.mapPanel.ResumeLayout(false);
            this.scrollBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.PictureBox mainHero;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy7;
        private System.Windows.Forms.PictureBox enemy5;
        private System.Windows.Forms.PictureBox enemy6;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Panel mapPanel;
        private System.Windows.Forms.Panel scrollBar;
        private System.Windows.Forms.PictureBox scroll;
    }
}

