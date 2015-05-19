using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_University
{
    public partial class AddNewClientWindow : Form
    {
        public AddNewClientWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date birthDateClient = new Date(DTPBirthDate.Value.Day,
                                            DTPBirthDate.Value.Month,
                                            DTPBirthDate.Value.Year);
            Date releaseDatePassport = new Date(DTPReleaseDate.Value.Day,
                                                DTPReleaseDate.Value.Month,
                                                DTPReleaseDate.Value.Year);

            char gender;
            if (RBMale.Checked)
                gender = 'M';
            else if (RBFemale.Checked)
                gender = 'F';
            else
                gender = 'M';

            Passport passport = new Passport(Convert.ToInt16(TBSeries.Text),
                                            Convert.ToInt16(TBNumber.Text),
                                            Convert.ToInt16(TBSubCode.Text),
                                          TBPassportOffice.Text, releaseDatePassport, TBBirthPlace.Text,
                                          TBAddress.Text);

            Client client = new Client(TBFirstName.Text, TBMiddleName.Text, TBLastName.Text, 
                                        birthDateClient, gender, TBinn.Text, TBbik.Text, null, passport);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
