namespace AgeCalculator
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
            this.date1TextBox = new System.Windows.Forms.TextBox();
            this.mon1TextBox = new System.Windows.Forms.TextBox();
            this.year1TextBox = new System.Windows.Forms.TextBox();
            this.date2TextBox = new System.Windows.Forms.TextBox();
            this.mon2TextBox = new System.Windows.Forms.TextBox();
            this.year2TextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.DoB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageBtn = new System.Windows.Forms.Button();
            this.loadCurDateBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.calculateAge = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.calculateAge.SuspendLayout();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // date1TextBox
            // 
            this.date1TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1TextBox.Location = new System.Drawing.Point(208, 91);
            this.date1TextBox.Name = "date1TextBox";
            this.date1TextBox.Size = new System.Drawing.Size(66, 23);
            this.date1TextBox.TabIndex = 0;
            this.date1TextBox.Text = "Date";
            this.date1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date1TextBox.TextChanged += new System.EventHandler(this.date1TextBox_TextChanged);
            this.date1TextBox.Enter += new System.EventHandler(this.date1TextBox_Enter);
            // 
            // mon1TextBox
            // 
            this.mon1TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon1TextBox.Location = new System.Drawing.Point(280, 91);
            this.mon1TextBox.Name = "mon1TextBox";
            this.mon1TextBox.Size = new System.Drawing.Size(66, 23);
            this.mon1TextBox.TabIndex = 1;
            this.mon1TextBox.Text = "Month";
            this.mon1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mon1TextBox.TextChanged += new System.EventHandler(this.mon1TextBox_TextChanged);
            this.mon1TextBox.Enter += new System.EventHandler(this.mon1TextBox_Enter);
            this.mon1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mon1TextBox_KeyPress);
            // 
            // year1TextBox
            // 
            this.year1TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year1TextBox.Location = new System.Drawing.Point(352, 91);
            this.year1TextBox.Name = "year1TextBox";
            this.year1TextBox.Size = new System.Drawing.Size(66, 23);
            this.year1TextBox.TabIndex = 2;
            this.year1TextBox.Text = "Year";
            this.year1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year1TextBox.TextChanged += new System.EventHandler(this.year1TextBox_TextChanged);
            this.year1TextBox.Enter += new System.EventHandler(this.year1TextBox_Enter);
            this.year1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year1TextBox_KeyPress);
            // 
            // date2TextBox
            // 
            this.date2TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2TextBox.Location = new System.Drawing.Point(208, 146);
            this.date2TextBox.Name = "date2TextBox";
            this.date2TextBox.Size = new System.Drawing.Size(66, 23);
            this.date2TextBox.TabIndex = 0;
            this.date2TextBox.Text = "Date";
            this.date2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date2TextBox.Enter += new System.EventHandler(this.date2TextBox_Enter);
            // 
            // mon2TextBox
            // 
            this.mon2TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon2TextBox.Location = new System.Drawing.Point(280, 146);
            this.mon2TextBox.Name = "mon2TextBox";
            this.mon2TextBox.Size = new System.Drawing.Size(66, 23);
            this.mon2TextBox.TabIndex = 1;
            this.mon2TextBox.Text = "Month";
            this.mon2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mon2TextBox.Enter += new System.EventHandler(this.mon2TextBox_Enter);
            // 
            // year2TextBox
            // 
            this.year2TextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year2TextBox.Location = new System.Drawing.Point(352, 146);
            this.year2TextBox.Name = "year2TextBox";
            this.year2TextBox.Size = new System.Drawing.Size(66, 23);
            this.year2TextBox.TabIndex = 2;
            this.year2TextBox.Text = "Year";
            this.year2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.year2TextBox.Enter += new System.EventHandler(this.year2TextBox_Enter);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(208, 242);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(210, 24);
            this.ageTextBox.TabIndex = 3;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoB
            // 
            this.DoB.AutoSize = true;
            this.DoB.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoB.Location = new System.Drawing.Point(106, 94);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(96, 16);
            this.DoB.TabIndex = 4;
            this.DoB.Text = "Date of Birth: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Age at Date:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Age: ";
            // 
            // ageBtn
            // 
            this.ageBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBtn.Location = new System.Drawing.Point(315, 202);
            this.ageBtn.Name = "ageBtn";
            this.ageBtn.Size = new System.Drawing.Size(103, 23);
            this.ageBtn.TabIndex = 5;
            this.ageBtn.Text = "Calculate Age";
            this.ageBtn.UseVisualStyleBackColor = true;
            this.ageBtn.Click += new System.EventHandler(this.ageBtn_Click);
            // 
            // loadCurDateBtn
            // 
            this.loadCurDateBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCurDateBtn.Location = new System.Drawing.Point(208, 202);
            this.loadCurDateBtn.Name = "loadCurDateBtn";
            this.loadCurDateBtn.Size = new System.Drawing.Size(101, 23);
            this.loadCurDateBtn.TabIndex = 6;
            this.loadCurDateBtn.Text = "Load Today";
            this.loadCurDateBtn.UseVisualStyleBackColor = true;
            this.loadCurDateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.calculateAge);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 414);
            this.tabControl1.TabIndex = 8;
            // 
            // calculateAge
            // 
            this.calculateAge.Controls.Add(this.label4);
            this.calculateAge.Controls.Add(this.label3);
            this.calculateAge.Controls.Add(this.loadCurDateBtn);
            this.calculateAge.Controls.Add(this.dateTimePicker1);
            this.calculateAge.Controls.Add(this.date1TextBox);
            this.calculateAge.Controls.Add(this.date2TextBox);
            this.calculateAge.Controls.Add(this.ageBtn);
            this.calculateAge.Controls.Add(this.mon1TextBox);
            this.calculateAge.Controls.Add(this.label2);
            this.calculateAge.Controls.Add(this.mon2TextBox);
            this.calculateAge.Controls.Add(this.label1);
            this.calculateAge.Controls.Add(this.year1TextBox);
            this.calculateAge.Controls.Add(this.DoB);
            this.calculateAge.Controls.Add(this.year2TextBox);
            this.calculateAge.Controls.Add(this.ageTextBox);
            this.calculateAge.Location = new System.Drawing.Point(4, 22);
            this.calculateAge.Name = "calculateAge";
            this.calculateAge.Padding = new System.Windows.Forms.Padding(3);
            this.calculateAge.Size = new System.Drawing.Size(637, 388);
            this.calculateAge.TabIndex = 0;
            this.calculateAge.Text = "Calculate Age";
            this.calculateAge.UseVisualStyleBackColor = true;
            this.calculateAge.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(623, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please fill up all required fields CORRECTLY before pressing the calculate button" +
    "!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome to free age Calculator!";
            // 
            // About
            // 
            this.About.Controls.Add(this.richTextBox1);
            this.About.Location = new System.Drawing.Point(4, 22);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(637, 388);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(637, 388);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 412);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Age Calculator";
            this.tabControl1.ResumeLayout(false);
            this.calculateAge.ResumeLayout(false);
            this.calculateAge.PerformLayout();
            this.About.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox date1TextBox;
        private System.Windows.Forms.TextBox mon1TextBox;
        private System.Windows.Forms.TextBox year1TextBox;
        private System.Windows.Forms.TextBox date2TextBox;
        private System.Windows.Forms.TextBox mon2TextBox;
        private System.Windows.Forms.TextBox year2TextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label DoB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ageBtn;
        private System.Windows.Forms.Button loadCurDateBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calculateAge;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
    }
}

