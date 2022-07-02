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
    public partial class AdressDataEdittingForm : Form
    {
        CommonClass NewRecord { get; set; }
        CommonClass SelectedRecord { get; set; }
        Adress PrevNewAdress { get; set; }
        Adress PrevSelectAdress { get; set; }


        Library lib = new Library();

        //flag for understand is it saved or not
        bool Saved { get; set; }

        public AdressDataEdittingForm()
        {
            InitializeComponent();
        }

        public AdressDataEdittingForm(CommonClass newRecord, CommonClass rec)
        {
            NewRecord = newRecord;
            SelectedRecord = rec;

            PrevNewAdress = NewRecord is null ? null : (Adress)NewRecord.Adr.Clone();
            PrevSelectAdress = SelectedRecord is null ? null : (Adress)SelectedRecord.Adr.Clone();

            InitializeComponent();
            if (NewRecord is null)
                DefaultDataLoad(SelectedRecord.Adr);
            else
                DefaultDataLoad(NewRecord.Adr);
        }

        private void DefaultDataLoad(Adress adr)
        {
            toolTip1.SetToolTip(CencelBtn, "Возврат к предыдущему сохраненному состоянию");

            streetTextBox.Text = adr.Street;
            houseNumberTextBox.Text = adr.HouseNumber;
            appNumNumericUpDown.Value = (int)adr.AppNumber;
           
        }

        

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (!lib.CheckValidationAdressData(streetTextBox.Text, houseNumberTextBox.Text))
                return;
            SaveChanges();
            Saved = true;
            this.Close();
        }

        private void SaveChanges()
        {
            if (SelectedRecord is null)
            {
                //add new data mode
                lib.CopyNewdataToAdressRecord(NewRecord, streetTextBox.Text, houseNumberTextBox.Text,
                                    (int) appNumNumericUpDown.Value);
                PrevNewAdress = (Adress)NewRecord.Adr.Clone();
                return;
            }
            //edit mode
            lib.CopyNewdataToAdressRecord(SelectedRecord, streetTextBox.Text, houseNumberTextBox.Text,
                                    (int)appNumNumericUpDown.Value);
            PrevSelectAdress = (Adress)SelectedRecord.Adr.Clone();
        }

        private void AdressDataEdittingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Saved)//straight way from SaveChanges and from cancel btn
            {
                e.Cancel = false;
                return;
            }

            //if previous state is the same as current than close the form
            if (!(NewRecord is null))
            {
                lib.CopyNewdataToAdressRecord(NewRecord, streetTextBox.Text, houseNumberTextBox.Text,
                                     (int)appNumNumericUpDown.Value);
                if (NewRecord.Adr == PrevNewAdress)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!lib.CheckValidationAdressData(streetTextBox.Text, houseNumberTextBox.Text))
                        {
                            e.Cancel = true;
                            return;
                        }
                        SaveChanges();
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        lib.CopyNewdataToAdressRecord(NewRecord, PrevNewAdress.Street, PrevNewAdress.HouseNumber,
                                     PrevNewAdress.AppNumber);                        
                        e.Cancel = false;
                    }
                }
            }
            else
            {
                lib.CopyNewdataToAdressRecord(SelectedRecord, streetTextBox.Text, houseNumberTextBox.Text,
                                    (int)appNumNumericUpDown.Value);
                if (SelectedRecord.Adr == PrevSelectAdress)
                {
                    e.Cancel = false;
                    return;
                }
                else
                {
                    if (MessageBox.Show("Не были сохранены внесенные изменения. \nСохранить?.\n"
                        , "Сделать выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (!lib.CheckValidationAdressData(streetTextBox.Text, houseNumberTextBox.Text))
                        {
                            e.Cancel = true;
                            return;
                        }
                        SaveChanges();
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        lib.CopyNewdataToAdressRecord(SelectedRecord, PrevSelectAdress.Street, PrevSelectAdress.HouseNumber,
                                     PrevSelectAdress.AppNumber);
                        e.Cancel = false;
                    }
                }
            }
        }

        private void CencelBtn_Click(object sender, EventArgs e)
        {
            if (NewRecord is null)
            {
                lib.CopyNewdataToAdressRecord(SelectedRecord, PrevSelectAdress.Street, PrevSelectAdress.HouseNumber,
                                    PrevSelectAdress.AppNumber);
                Saved = true;
            }
            else
            {
                lib.CopyNewdataToAdressRecord(NewRecord, PrevNewAdress.Street,PrevNewAdress.HouseNumber,
                                    PrevNewAdress.AppNumber);
                Saved = true;
            }
            this.Close();

        }
    }
}
