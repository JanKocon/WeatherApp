namespace WeatherApp
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.City_Label = new System.Windows.Forms.Label();
            this.Temperature_Label = new System.Windows.Forms.Label();
            this.City_TextBox = new System.Windows.Forms.TextBox();
            this.Pressure_Label = new System.Windows.Forms.Label();
            this.Search_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentWeather_PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cloudiness_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeather_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.City_Label.Location = new System.Drawing.Point(158, 193);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(0, 20);
            this.City_Label.TabIndex = 0;
            // 
            // Temperature_Label
            // 
            this.Temperature_Label.AutoSize = true;
            this.Temperature_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temperature_Label.Location = new System.Drawing.Point(158, 223);
            this.Temperature_Label.Name = "Temperature_Label";
            this.Temperature_Label.Size = new System.Drawing.Size(0, 20);
            this.Temperature_Label.TabIndex = 2;
            // 
            // City_TextBox
            // 
            this.City_TextBox.Location = new System.Drawing.Point(24, 30);
            this.City_TextBox.Name = "City_TextBox";
            this.City_TextBox.Size = new System.Drawing.Size(156, 22);
            this.City_TextBox.TabIndex = 4;
            // 
            // Pressure_Label
            // 
            this.Pressure_Label.AutoSize = true;
            this.Pressure_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pressure_Label.Location = new System.Drawing.Point(158, 255);
            this.Pressure_Label.Name = "Pressure_Label";
            this.Pressure_Label.Size = new System.Drawing.Size(0, 20);
            this.Pressure_Label.TabIndex = 6;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(187, 30);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 7;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(28, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pressure";
            // 
            // CurrentWeather_PictureBox
            // 
            this.CurrentWeather_PictureBox.Location = new System.Drawing.Point(120, 119);
            this.CurrentWeather_PictureBox.Name = "CurrentWeather_PictureBox";
            this.CurrentWeather_PictureBox.Size = new System.Drawing.Size(60, 58);
            this.CurrentWeather_PictureBox.TabIndex = 3;
            this.CurrentWeather_PictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current weater";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cloudiness";
            // 
            // Cloudiness_Label
            // 
            this.Cloudiness_Label.AutoSize = true;
            this.Cloudiness_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cloudiness_Label.Location = new System.Drawing.Point(158, 288);
            this.Cloudiness_Label.Name = "Cloudiness_Label";
            this.Cloudiness_Label.Size = new System.Drawing.Size(0, 20);
            this.Cloudiness_Label.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(295, 347);
            this.Controls.Add(this.Cloudiness_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Pressure_Label);
            this.Controls.Add(this.City_TextBox);
            this.Controls.Add(this.CurrentWeather_PictureBox);
            this.Controls.Add(this.Temperature_Label);
            this.Controls.Add(this.City_Label);
            this.Name = "Form1";
            this.Text = "App";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentWeather_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Label Temperature_Label;
        private System.Windows.Forms.PictureBox CurrentWeather_PictureBox;
        private System.Windows.Forms.TextBox City_TextBox;
        private System.Windows.Forms.Label Pressure_Label;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cloudiness_Label;
    }
}

