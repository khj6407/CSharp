namespace WindowsFormsApp1
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.NumButton3 = new System.Windows.Forms.Button();
            this.NumButton6 = new System.Windows.Forms.Button();
            this.NumButton5 = new System.Windows.Forms.Button();
            this.NumButton4 = new System.Windows.Forms.Button();
            this.NumButton9 = new System.Windows.Forms.Button();
            this.NumButton8 = new System.Windows.Forms.Button();
            this.NumButton7 = new System.Windows.Forms.Button();
            this.NumButton10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(24, 231);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(126, 117);
            this.NumButton1.TabIndex = 0;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(186, 231);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(131, 117);
            this.NumButton2.TabIndex = 2;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 12F);
            this.NumScreen.Location = new System.Drawing.Point(16, 12);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(610, 80);
            this.NumScreen.TabIndex = 3;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(507, 496);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(119, 117);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumButton3
            // 
            this.NumButton3.Location = new System.Drawing.Point(354, 231);
            this.NumButton3.Name = "NumButton3";
            this.NumButton3.Size = new System.Drawing.Size(120, 117);
            this.NumButton3.TabIndex = 5;
            this.NumButton3.Text = "3";
            this.NumButton3.UseVisualStyleBackColor = true;
            this.NumButton3.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton6
            // 
            this.NumButton6.Location = new System.Drawing.Point(354, 363);
            this.NumButton6.Name = "NumButton6";
            this.NumButton6.Size = new System.Drawing.Size(120, 117);
            this.NumButton6.TabIndex = 8;
            this.NumButton6.Text = "6";
            this.NumButton6.UseVisualStyleBackColor = true;
            this.NumButton6.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton5
            // 
            this.NumButton5.Location = new System.Drawing.Point(186, 363);
            this.NumButton5.Name = "NumButton5";
            this.NumButton5.Size = new System.Drawing.Size(131, 117);
            this.NumButton5.TabIndex = 7;
            this.NumButton5.Text = "5";
            this.NumButton5.UseVisualStyleBackColor = true;
            this.NumButton5.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton4
            // 
            this.NumButton4.Location = new System.Drawing.Point(24, 363);
            this.NumButton4.Name = "NumButton4";
            this.NumButton4.Size = new System.Drawing.Size(126, 117);
            this.NumButton4.TabIndex = 6;
            this.NumButton4.Text = "4";
            this.NumButton4.UseVisualStyleBackColor = true;
            this.NumButton4.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton9
            // 
            this.NumButton9.Location = new System.Drawing.Point(354, 496);
            this.NumButton9.Name = "NumButton9";
            this.NumButton9.Size = new System.Drawing.Size(120, 117);
            this.NumButton9.TabIndex = 11;
            this.NumButton9.Text = "9";
            this.NumButton9.UseVisualStyleBackColor = true;
            this.NumButton9.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton8
            // 
            this.NumButton8.Location = new System.Drawing.Point(186, 496);
            this.NumButton8.Name = "NumButton8";
            this.NumButton8.Size = new System.Drawing.Size(131, 117);
            this.NumButton8.TabIndex = 10;
            this.NumButton8.Text = "8";
            this.NumButton8.UseVisualStyleBackColor = true;
            this.NumButton8.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton7
            // 
            this.NumButton7.Location = new System.Drawing.Point(24, 496);
            this.NumButton7.Name = "NumButton7";
            this.NumButton7.Size = new System.Drawing.Size(126, 117);
            this.NumButton7.TabIndex = 9;
            this.NumButton7.Text = "7";
            this.NumButton7.UseVisualStyleBackColor = true;
            this.NumButton7.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton10
            // 
            this.NumButton10.Location = new System.Drawing.Point(186, 629);
            this.NumButton10.Name = "NumButton10";
            this.NumButton10.Size = new System.Drawing.Size(131, 121);
            this.NumButton10.TabIndex = 12;
            this.NumButton10.Text = "0";
            this.NumButton10.UseVisualStyleBackColor = true;
            this.NumButton10.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 117);
            this.button1.TabIndex = 13;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(186, 95);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(131, 117);
            this.NumClear.TabIndex = 14;
            this.NumClear.Text = "C";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 633);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 117);
            this.button2.TabIndex = 15;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 777);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumButton10);
            this.Controls.Add(this.NumButton9);
            this.Controls.Add(this.NumButton8);
            this.Controls.Add(this.NumButton7);
            this.Controls.Add(this.NumButton6);
            this.Controls.Add(this.NumButton5);
            this.Controls.Add(this.NumButton4);
            this.Controls.Add(this.NumButton3);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.NumButton1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button NumButton3;
        private System.Windows.Forms.Button NumButton6;
        private System.Windows.Forms.Button NumButton5;
        private System.Windows.Forms.Button NumButton4;
        private System.Windows.Forms.Button NumButton9;
        private System.Windows.Forms.Button NumButton8;
        private System.Windows.Forms.Button NumButton7;
        private System.Windows.Forms.Button NumButton10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NumClear;
        private System.Windows.Forms.Button button2;
    }
}

