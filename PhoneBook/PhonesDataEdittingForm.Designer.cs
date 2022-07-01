
namespace PhoneBook
{
    partial class PhonesDataEdittingForm
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
            System.Windows.Forms.Label hPhoneNumLabel;
            System.Windows.Forms.Label mPhoneNumLabel;
            this.hPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.mPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.summaryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            hPhoneNumLabel = new System.Windows.Forms.Label();
            mPhoneNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summaryListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hPhoneNumLabel
            // 
            hPhoneNumLabel.AutoSize = true;
            hPhoneNumLabel.Location = new System.Drawing.Point(9, 15);
            hPhoneNumLabel.Name = "hPhoneNumLabel";
            hPhoneNumLabel.Size = new System.Drawing.Size(128, 17);
            hPhoneNumLabel.TabIndex = 1;
            hPhoneNumLabel.Text = "Дом. № телеофна";
            // 
            // hPhoneNumTextBox
            // 
            this.hPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Phones.HPhoneNum", true));
            this.hPhoneNumTextBox.Location = new System.Drawing.Point(143, 12);
            this.hPhoneNumTextBox.MaxLength = 13;
            this.hPhoneNumTextBox.Name = "hPhoneNumTextBox";
            this.hPhoneNumTextBox.Size = new System.Drawing.Size(289, 22);
            this.hPhoneNumTextBox.TabIndex = 2;
            this.hPhoneNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hPhoneNumTextBox_KeyPress);
            // 
            // mPhoneNumLabel
            // 
            mPhoneNumLabel.AutoSize = true;
            mPhoneNumLabel.Location = new System.Drawing.Point(9, 43);
            mPhoneNumLabel.Name = "mPhoneNumLabel";
            mPhoneNumLabel.Size = new System.Drawing.Size(127, 17);
            mPhoneNumLabel.TabIndex = 3;
            mPhoneNumLabel.Text = "Моб. № телефона";
            // 
            // mPhoneNumTextBox
            // 
            this.mPhoneNumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.summaryListBindingSource, "Phones.MPhoneNum", true));
            this.mPhoneNumTextBox.Location = new System.Drawing.Point(143, 40);
            this.mPhoneNumTextBox.MaxLength = 13;
            this.mPhoneNumTextBox.Name = "mPhoneNumTextBox";
            this.mPhoneNumTextBox.Size = new System.Drawing.Size(289, 22);
            this.mPhoneNumTextBox.TabIndex = 4;
            this.mPhoneNumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mPhoneNumTextBox_KeyPress);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelBtn.Location = new System.Drawing.Point(221, 68);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(212, 36);
            this.CancelBtn.TabIndex = 19;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OkBtn.Location = new System.Drawing.Point(6, 68);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(209, 36);
            this.OkBtn.TabIndex = 18;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // summaryListBindingSource
            // 
            this.summaryListBindingSource.DataSource = typeof(PhoneBook.Model.CommonClass);
            // 
            // PhonesDataEdittingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 112);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(hPhoneNumLabel);
            this.Controls.Add(this.hPhoneNumTextBox);
            this.Controls.Add(mPhoneNumLabel);
            this.Controls.Add(this.mPhoneNumTextBox);
            this.Name = "PhonesDataEdittingForm";
            this.Text = "Редактирование номеров телефонов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhonesDataEdittingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.summaryListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource summaryListBindingSource;
        private System.Windows.Forms.TextBox hPhoneNumTextBox;
        private System.Windows.Forms.TextBox mPhoneNumTextBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}