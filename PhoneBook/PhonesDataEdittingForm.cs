using PhoneBook.Helps;
using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class PhonesDataEdittingForm : Form
    {
        CommonClass NewRecord { get; set; }
        CommonClass SelectedRecord { get; set; }
        PhoneNumbers PrevNewPhones { get; set; }
        PhoneNumbers PrevSelectPhones { get; set; }


        Library lib = new Library();

        //flag for understand is it saved or not
        bool Saved { get; set; }
       
        public PhonesDataEdittingForm()
        {
            InitializeComponent();
        }

        public PhonesDataEdittingForm(CommonClass newRecord, CommonClass rec)
        {
            NewRecord = newRecord;
            SelectedRecord = rec;

            PrevNewPhones = NewRecord is null ? null : (PhoneNumbers)NewRecord.Phones.Clone();
            PrevSelectPhones = SelectedRecord is null ? null : (PhoneNumbers)SelectedRecord.Phones.Clone();

            InitializeComponent();
            if (NewRecord is null)
                DefaultDataLoad(SelectedRecord.Phones);
            else
                DefaultDataLoad(NewRecord.Phones);
        }

        private void DefaultDataLoad(PhoneNumbers ph)
        {
            toolTip1.SetToolTip(CancelBtn, "Возврат к предыдущему сохраненному состоянию");
            toolTip1.SetToolTip(hPhoneNumTextBox, "В формате +380*********. Не менее 11 символов");
            toolTip1.SetToolTip(mPhoneNumTextBox, "В формате +380*********. Не менее 11 символов");
            hPhoneNumTextBox.Text = ph.HPhoneNum ;
            mPhoneNumTextBox.Text = ph.MPhoneNum ;

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (hPhoneNumTextBox.Text.Length < 10 || hPhoneNumTextBox.Text.Length < 10)
            {
                MessageBox.Show("Не корректный формат одного или обоих номеров телефона");
                return;
            }
            SaveChanges();
            Saved = true;
            this.Close();
        }

        private void SaveChanges()
        {
            if (SelectedRecord is null)
            {
                //add new data mode
                lib.CopyNewdataToPhonesRecord(NewRecord,  mPhoneNumTextBox.Text, hPhoneNumTextBox.Text);
                PrevNewPhones = (PhoneNumbers)NewRecord.Phones.Clone();
                return;
            }
            //edit mode
            lib.CopyNewdataToPhonesRecord(SelectedRecord, mPhoneNumTextBox.Text, hPhoneNumTextBox.Text);
            PrevSelectPhones = (PhoneNumbers)SelectedRecord.Phones.Clone();
        }

        private void PhonesDataEdittingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Saved)//straight way from SaveChanges and from cancel btn
            {
                e.Cancel = false;
                return;
            }

            //if previous state is the same as current than close the form
            if (!(NewRecord is null))
            {
                lib.CopyNewdataToPhonesRecord(NewRecord, mPhoneNumTextBox.Text, hPhoneNumTextBox.Text);                
                if (NewRecord.Phones == PrevNewPhones)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (hPhoneNumTextBox.Text.Length < 10 || hPhoneNumTextBox.Text.Length < 10)
                        {
                            MessageBox.Show("Не корректный формат одного или обоих номеров телефона");
                            e.Cancel = true;
                            return;
                        }
                       
                        SaveChanges();
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        lib.CopyNewdataToPhonesRecord(NewRecord, PrevNewPhones.MPhoneNum, PrevNewPhones.HPhoneNum);                        
                        e.Cancel = false;
                    }
                }
            }
            else
            {
                lib.CopyNewdataToPhonesRecord(SelectedRecord, mPhoneNumTextBox.Text, hPhoneNumTextBox.Text);
                if (SelectedRecord.Phones == PrevSelectPhones)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (hPhoneNumTextBox.Text.Length < 10 || hPhoneNumTextBox.Text.Length < 10)
                        {
                            MessageBox.Show("Не корректный формат одного или обоих номеров телефона");
                            e.Cancel = true;
                            return;
                        }
                        SaveChanges();
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        lib.CopyNewdataToPhonesRecord(SelectedRecord, PrevSelectPhones.MPhoneNum, PrevSelectPhones.HPhoneNum);
                        e.Cancel = false;
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (NewRecord is null)
            {
                lib.CopyNewdataToPhonesRecord(SelectedRecord, PrevSelectPhones.MPhoneNum, PrevSelectPhones.HPhoneNum);
                Saved = true;
            }
            else
            {
                lib.CopyNewdataToPhonesRecord(NewRecord, PrevNewPhones.MPhoneNum, PrevNewPhones.HPhoneNum);
                Saved = true;
            }
            this.Close();

        }

        private void hPhoneNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            hPhoneNumTextBox.Text = lib.PhoneNumValidation(hPhoneNumTextBox.Text);
            hPhoneNumTextBox.SelectionStart = hPhoneNumTextBox.Text.Length;
            hPhoneNumTextBox.SelectionLength = hPhoneNumTextBox.Text.Length;
        }

        private void mPhoneNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            mPhoneNumTextBox.Text = lib.PhoneNumValidation(mPhoneNumTextBox.Text);
            mPhoneNumTextBox.SelectionStart = mPhoneNumTextBox.Text.Length;
            mPhoneNumTextBox.SelectionLength = mPhoneNumTextBox.Text.Length;
        }

       

       
    }
}
