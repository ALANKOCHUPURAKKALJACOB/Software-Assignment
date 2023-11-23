namespace demo_5
{
    partial class Form2
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
            panel1 = new Panel();
            textBox3 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            editUser = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            editVendor = new Button();
            signOut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(editUser);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 104);
            panel1.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Navy;
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(12, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 33);
            textBox3.TabIndex = 2;
            textBox3.Text = "CITISOFT";
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.Screenshot__20_;
            button6.Location = new Point(713, 3);
            button6.Name = "button6";
            button6.Size = new Size(75, 81);
            button6.TabIndex = 5;
            button6.Text = "User";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(380, 74);
            button7.Name = "button7";
            button7.Size = new Size(157, 23);
            button7.TabIndex = 4;
            button7.Text = "Products";
            button7.UseVisualStyleBackColor = true;
            // 
            // editUser
            // 
            editUser.Location = new Point(712, 81);
            editUser.Name = "editUser";
            editUser.Size = new Size(75, 23);
            editUser.TabIndex = 15;
            editUser.Text = "Edit User";
            editUser.UseVisualStyleBackColor = true;
            editUser.Click += editUser_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(134, 74);
            button8.Name = "button8";
            button8.Size = new Size(183, 23);
            button8.TabIndex = 3;
            button8.Text = "Vendors";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(134, 12);
            button9.Name = "button9";
            button9.Size = new Size(22, 23);
            button9.TabIndex = 2;
            button9.Text = "All";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(462, 12);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 1;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 12);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(315, 23);
            textBox4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot__20_;
            pictureBox1.Location = new Point(-97, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(991, 486);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // editVendor
            // 
            editVendor.Location = new Point(714, 109);
            editVendor.Name = "editVendor";
            editVendor.Size = new Size(75, 23);
            editVendor.TabIndex = 16;
            editVendor.Text = "Edit Vendor";
            editVendor.UseVisualStyleBackColor = true;
            editVendor.Click += button2_Click;
            // 
            // signOut
            // 
            signOut.Location = new Point(713, 138);
            signOut.Name = "signOut";
            signOut.Size = new Size(75, 23);
            signOut.TabIndex = 17;
            signOut.Text = "Sign Out";
            signOut.UseVisualStyleBackColor = true;
            signOut.Click += signOut_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signOut);
            Controls.Add(editVendor);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Button editUser;
        private Button editVendor;
        private Button signOut;
    }
}