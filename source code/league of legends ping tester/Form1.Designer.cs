
namespace league_of_legends_ping_tester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.euw_radiobutton = new System.Windows.Forms.RadioButton();
            this.na_radiobutton = new System.Windows.Forms.RadioButton();
            this.startbutton = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.button2 = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.now = new System.Windows.Forms.Label();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_now = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // euw_radiobutton
            // 
            this.euw_radiobutton.AutoSize = true;
            this.euw_radiobutton.Location = new System.Drawing.Point(13, 49);
            this.euw_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.euw_radiobutton.Name = "euw_radiobutton";
            this.euw_radiobutton.Size = new System.Drawing.Size(61, 21);
            this.euw_radiobutton.TabIndex = 0;
            this.euw_radiobutton.TabStop = true;
            this.euw_radiobutton.Text = "EUW";
            this.euw_radiobutton.UseVisualStyleBackColor = true;
            // 
            // na_radiobutton
            // 
            this.na_radiobutton.AutoSize = true;
            this.na_radiobutton.Location = new System.Drawing.Point(135, 49);
            this.na_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.na_radiobutton.Name = "na_radiobutton";
            this.na_radiobutton.Size = new System.Drawing.Size(48, 21);
            this.na_radiobutton.TabIndex = 1;
            this.na_radiobutton.TabStop = true;
            this.na_radiobutton.Text = "NA";
            this.na_radiobutton.UseVisualStyleBackColor = true;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(13, 94);
            this.startbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 27);
            this.startbutton.TabIndex = 3;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(13, 174);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(794, 292);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(135, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Location = new System.Drawing.Point(382, 103);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(36, 17);
            this.min.TabIndex = 6;
            this.min.Text = "MIN:";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(491, 103);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(41, 17);
            this.max.TabIndex = 8;
            this.max.Text = "MAX:";
            // 
            // now
            // 
            this.now.AutoSize = true;
            this.now.Location = new System.Drawing.Point(613, 104);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(46, 17);
            this.now.TabIndex = 9;
            this.now.Text = "NOW:";
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(424, 100);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.ReadOnly = true;
            this.textBox_min.Size = new System.Drawing.Size(61, 22);
            this.textBox_min.TabIndex = 10;
            this.textBox_min.Text = "10000";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(537, 100);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.ReadOnly = true;
            this.textBox_max.Size = new System.Drawing.Size(70, 22);
            this.textBox_max.TabIndex = 11;
            this.textBox_max.Text = "0";
            // 
            // textBox_now
            // 
            this.textBox_now.Location = new System.Drawing.Point(665, 101);
            this.textBox_now.Name = "textBox_now";
            this.textBox_now.ReadOnly = true;
            this.textBox_now.Size = new System.Drawing.Size(70, 22);
            this.textBox_now.TabIndex = 12;
            this.textBox_now.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "min,now and max on vacation";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_now);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.now);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.na_radiobutton);
            this.Controls.Add(this.euw_radiobutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "league of legends ping tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton euw_radiobutton;
        private System.Windows.Forms.RadioButton na_radiobutton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label now;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_now;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

