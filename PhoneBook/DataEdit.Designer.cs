
namespace PhoneBook
{
    partial class DataEdit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditPersonalDataBtn = new System.Windows.Forms.Button();
            this.ClearPersDataBtn = new System.Windows.Forms.Button();
            this.ClearAdressBtn = new System.Windows.Forms.Button();
            this.EditAdressBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearPhonesBtn = new System.Windows.Forms.Button();
            this.EditPhonesBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Персональные данные";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(443, 22);
            this.textBox1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox1, "Это поле только для чтения");
            // 
            // EditPersonalDataBtn
            // 
            this.EditPersonalDataBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditPersonalDataBtn.Location = new System.Drawing.Point(637, 6);
            this.EditPersonalDataBtn.Name = "EditPersonalDataBtn";
            this.EditPersonalDataBtn.Size = new System.Drawing.Size(48, 23);
            this.EditPersonalDataBtn.TabIndex = 0;
            this.EditPersonalDataBtn.Text = "...";
            this.EditPersonalDataBtn.UseVisualStyleBackColor = false;
            this.EditPersonalDataBtn.Click += new System.EventHandler(this.EditPersonalDataBtn_Click);
            // 
            // ClearPersDataBtn
            // 
            this.ClearPersDataBtn.BackColor = System.Drawing.Color.Red;
            this.ClearPersDataBtn.Location = new System.Drawing.Point(691, 6);
            this.ClearPersDataBtn.Name = "ClearPersDataBtn";
            this.ClearPersDataBtn.Size = new System.Drawing.Size(48, 23);
            this.ClearPersDataBtn.TabIndex = 1;
            this.ClearPersDataBtn.Text = "X";
            this.ClearPersDataBtn.UseVisualStyleBackColor = false;
            this.ClearPersDataBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearAdressBtn
            // 
            this.ClearAdressBtn.BackColor = System.Drawing.Color.Red;
            this.ClearAdressBtn.Location = new System.Drawing.Point(691, 40);
            this.ClearAdressBtn.Name = "ClearAdressBtn";
            this.ClearAdressBtn.Size = new System.Drawing.Size(48, 23);
            this.ClearAdressBtn.TabIndex = 3;
            this.ClearAdressBtn.Text = "X";
            this.ClearAdressBtn.UseVisualStyleBackColor = false;
            this.ClearAdressBtn.Click += new System.EventHandler(this.ClearAdressBtn_Click);
            // 
            // EditAdressBtn
            // 
            this.EditAdressBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditAdressBtn.Location = new System.Drawing.Point(637, 40);
            this.EditAdressBtn.Name = "EditAdressBtn";
            this.EditAdressBtn.Size = new System.Drawing.Size(48, 23);
            this.EditAdressBtn.TabIndex = 2;
            this.EditAdressBtn.Text = "...";
            this.EditAdressBtn.UseVisualStyleBackColor = false;
            this.EditAdressBtn.Click += new System.EventHandler(this.EditAdressBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(443, 22);
            this.textBox2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox2, "Это поле только для чтения");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес";
            // 
            // ClearPhonesBtn
            // 
            this.ClearPhonesBtn.BackColor = System.Drawing.Color.Red;
            this.ClearPhonesBtn.Location = new System.Drawing.Point(691, 74);
            this.ClearPhonesBtn.Name = "ClearPhonesBtn";
            this.ClearPhonesBtn.Size = new System.Drawing.Size(48, 23);
            this.ClearPhonesBtn.TabIndex = 5;
            this.ClearPhonesBtn.Text = "X";
            this.ClearPhonesBtn.UseVisualStyleBackColor = false;
            this.ClearPhonesBtn.Click += new System.EventHandler(this.ClearPhonesBtn_Click);
            // 
            // EditPhonesBtn
            // 
            this.EditPhonesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditPhonesBtn.Location = new System.Drawing.Point(637, 74);
            this.EditPhonesBtn.Name = "EditPhonesBtn";
            this.EditPhonesBtn.Size = new System.Drawing.Size(48, 23);
            this.EditPhonesBtn.TabIndex = 4;
            this.EditPhonesBtn.Text = "...";
            this.EditPhonesBtn.UseVisualStyleBackColor = false;
            this.EditPhonesBtn.Click += new System.EventHandler(this.EditPhonesBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(443, 22);
            this.textBox3.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox3, "Это поле только для чтения");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Телефоны";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(188, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(443, 22);
            this.textBox4.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox4, "Это поле только для чтения");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(378, 150);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(360, 36);
            this.button9.TabIndex = 7;
            this.button9.Text = "Отменить";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveBtn.Location = new System.Drawing.Point(15, 150);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(357, 36);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DataEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 194);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearPhonesBtn);
            this.Controls.Add(this.EditPhonesBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearAdressBtn);
            this.Controls.Add(this.EditAdressBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearPersDataBtn);
            this.Controls.Add(this.EditPersonalDataBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DataEdit";
            this.Text = "DataEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataEdit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditPersonalDataBtn;
        private System.Windows.Forms.Button ClearPersDataBtn;
        private System.Windows.Forms.Button ClearAdressBtn;
        private System.Windows.Forms.Button EditAdressBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearPhonesBtn;
        private System.Windows.Forms.Button EditPhonesBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}