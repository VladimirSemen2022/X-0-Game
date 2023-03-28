﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace X_0_Game__WinForm_
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
            //The main settings of the playing field 
            #region
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "X-Zero game";
            this.Size = new Size(530, 530);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Location = new Point(400, 200);
            bool Fplayer = true;  //A step of the first player
            int step = 1;         //A number of the step
            string symbolCheck = "X";
            bool win = false;
            #endregion

            //Creation of the buttons field
            #region
            int size = 100;     //Size of the playfield button
            int line = 1;
            int position = 1;
            bool exit = true;
            do
            {
                btn = new Button();
                btn.Text = "1";
                btn.ForeColor = Color.Aquamarine;
                btn.BackColor = Color.Aquamarine;
                btn.Size = new Size(size, size);
                btn.Location = new Point(line * size + 5, position * size + 5);
                buttonList.Add(btn);
                this.Controls.Add(btn);
                position++;
                if (position > 3)
                {
                    position = 1;
                    line++;
                }
                if (line > 3)
                    exit = false;
            } while (exit);
            #endregion
        }

        List<Button> buttonList = new List<Button>();
        Button btn; //Buttons of the cells

        #endregion
    }
}

