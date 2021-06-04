namespace Contact_Tracing_Application
{
    partial class Add_contact_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_contact_form));
            this.AddContact_btn = new System.Windows.Forms.Button();
            this.Female_rbtn = new System.Windows.Forms.RadioButton();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Age_label = new System.Windows.Forms.Label();
            this.Sex_label = new System.Windows.Forms.Label();
            this.Male_rbtn = new System.Windows.Forms.RadioButton();
            this.Address_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Contact_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContact_btn
            // 
            this.AddContact_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddContact_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.AddContact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContact_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.AddContact_btn.Location = new System.Drawing.Point(247, 524);
            this.AddContact_btn.Name = "AddContact_btn";
            this.AddContact_btn.Size = new System.Drawing.Size(138, 23);
            this.AddContact_btn.TabIndex = 0;
            this.AddContact_btn.Text = "Add Contact";
            this.AddContact_btn.UseVisualStyleBackColor = false;
            this.AddContact_btn.Click += new System.EventHandler(this.AddContact_btn_Click);
            // 
            // Female_rbtn
            // 
            this.Female_rbtn.AutoSize = true;
            this.Female_rbtn.BackColor = System.Drawing.Color.Transparent;
            this.Female_rbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Female_rbtn.ForeColor = System.Drawing.Color.White;
            this.Female_rbtn.Location = new System.Drawing.Point(24, 264);
            this.Female_rbtn.Name = "Female_rbtn";
            this.Female_rbtn.Size = new System.Drawing.Size(67, 18);
            this.Female_rbtn.TabIndex = 1;
            this.Female_rbtn.TabStop = true;
            this.Female_rbtn.Text = "Female";
            this.Female_rbtn.UseVisualStyleBackColor = false;
            // 
            // Name_box
            // 
            this.Name_box.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Name_box.Location = new System.Drawing.Point(24, 137);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(249, 21);
            this.Name_box.TabIndex = 2;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.BackColor = System.Drawing.Color.Transparent;
            this.Name_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(21, 111);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(47, 16);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.numericUpDown1.Location = new System.Drawing.Point(24, 199);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 4;
            // 
            // Age_label
            // 
            this.Age_label.AutoSize = true;
            this.Age_label.BackColor = System.Drawing.Color.Transparent;
            this.Age_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Age_label.ForeColor = System.Drawing.Color.White;
            this.Age_label.Location = new System.Drawing.Point(21, 172);
            this.Age_label.Name = "Age_label";
            this.Age_label.Size = new System.Drawing.Size(35, 16);
            this.Age_label.TabIndex = 5;
            this.Age_label.Text = "Age";
            // 
            // Sex_label
            // 
            this.Sex_label.AutoSize = true;
            this.Sex_label.BackColor = System.Drawing.Color.Transparent;
            this.Sex_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Sex_label.ForeColor = System.Drawing.Color.White;
            this.Sex_label.Location = new System.Drawing.Point(21, 243);
            this.Sex_label.Name = "Sex_label";
            this.Sex_label.Size = new System.Drawing.Size(32, 16);
            this.Sex_label.TabIndex = 6;
            this.Sex_label.Text = "Sex";
            // 
            // Male_rbtn
            // 
            this.Male_rbtn.AutoSize = true;
            this.Male_rbtn.BackColor = System.Drawing.Color.Transparent;
            this.Male_rbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Male_rbtn.ForeColor = System.Drawing.Color.White;
            this.Male_rbtn.Location = new System.Drawing.Point(24, 288);
            this.Male_rbtn.Name = "Male_rbtn";
            this.Male_rbtn.Size = new System.Drawing.Size(52, 18);
            this.Male_rbtn.TabIndex = 7;
            this.Male_rbtn.TabStop = true;
            this.Male_rbtn.Text = "Male";
            this.Male_rbtn.UseVisualStyleBackColor = false;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.BackColor = System.Drawing.Color.Transparent;
            this.Address_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Address_label.ForeColor = System.Drawing.Color.White;
            this.Address_label.Location = new System.Drawing.Point(21, 319);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(66, 16);
            this.Address_label.TabIndex = 8;
            this.Address_label.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.textBox1.Location = new System.Drawing.Point(24, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 21);
            this.textBox1.TabIndex = 9;
            // 
            // Contact_label
            // 
            this.Contact_label.AutoSize = true;
            this.Contact_label.BackColor = System.Drawing.Color.Transparent;
            this.Contact_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Contact_label.ForeColor = System.Drawing.Color.White;
            this.Contact_label.Location = new System.Drawing.Point(21, 381);
            this.Contact_label.Name = "Contact_label";
            this.Contact_label.Size = new System.Drawing.Size(118, 16);
            this.Contact_label.TabIndex = 10;
            this.Contact_label.Text = "Contact Number";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.textBox2.Location = new System.Drawing.Point(24, 407);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 21);
            this.textBox2.TabIndex = 11;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.BackColor = System.Drawing.Color.Transparent;
            this.Email_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Email_label.ForeColor = System.Drawing.Color.Transparent;
            this.Email_label.Location = new System.Drawing.Point(21, 441);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(45, 16);
            this.Email_label.TabIndex = 12;
            this.Email_label.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.textBox3.Location = new System.Drawing.Point(24, 468);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(279, 21);
            this.textBox3.TabIndex = 13;
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.Back_btn.ForeColor = System.Drawing.Color.Black;
            this.Back_btn.Location = new System.Drawing.Point(24, 524);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(84, 23);
            this.Back_btn.TabIndex = 14;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // Add_contact_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Contact_Tracing_Application.Properties.Resources.bckgrnd2;
            this.ClientSize = new System.Drawing.Size(402, 571);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Contact_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.Male_rbtn);
            this.Controls.Add(this.Sex_label);
            this.Controls.Add(this.Age_label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.Female_rbtn);
            this.Controls.Add(this.AddContact_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_contact_form";
            this.Text = "Contact Tracer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddContact_btn;
        private System.Windows.Forms.RadioButton Female_rbtn;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Age_label;
        private System.Windows.Forms.Label Sex_label;
        private System.Windows.Forms.RadioButton Male_rbtn;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Contact_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Back_btn;
    }
}