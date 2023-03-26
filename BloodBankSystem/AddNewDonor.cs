using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankSystem
{
    public partial class AddNewDonor : Form
    {
        protected readonly BloodBank2Entities BloodOBJ;
        BFunction bfn = new BFunction();
        public AddNewDonor()
        {
            InitializeComponent();
            BloodOBJ= new BloodBank2Entities();
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            /* String query = "select max(ID) from NewDonor";  //this command is suppose to show the highest number on thw form when program runs
             DataSet ds = new DataSet(); */

            var bld = BloodOBJ.NewDonors.OrderByDescending(q => q.ID).FirstOrDefault();
            //labelNewID.Text = bld.ToString();
           // labelNewID.


            //int count = int.Parse();
            //labelNewID.Text = (bld + 1).ToString();   //CODES FOR LABEL COUNT ON FORM




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String dfname = txtfname.Text;
            String dlname = txtlname.Text;
            DateTime dDOB = txtDOB.Value;
            String dphone = txtphone.Text;
            var dgen = txtgender.SelectedItem.ToString();
            String dema = txtemail.Text;
            String dgroup = txtBloodGroup.SelectedItem.ToString();
            int dquan = Convert.ToInt32(txtBloodLitres.Text);
            String dcity = txtCity.Text;
            String dadd = txtAddress.Text;

            bool isValid = true;

            if(String.IsNullOrWhiteSpace(dfname) || String.IsNullOrWhiteSpace(dlname) 
                || String.IsNullOrWhiteSpace(dgen) || String.IsNullOrWhiteSpace(dgroup))
            {
                isValid = false;
                MessageBox.Show("Please enter missing data");
            }

            
            if(dDOB > DateTime.Now)
            {
                isValid = false;
                MessageBox.Show("Illegal Date Selection");
            }


            if (isValid)
            {
                MessageBox.Show($"Name: {dfname}+ {dlname}\n\r" +
                                $"Gender: {dgen}\n\r" +
                                $"Blood Type: {dgroup}\n\r" +
                                $"Blood Quantity: {dquan}\n\r" +
                                $"YOUR BLOOD WILL SAVE A LIFE");

            }
            



        }
    }
}
