using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011S_Project_Group22.Presentation
{
    public partial class ViewAvailability : Form
    {
        public ViewAvailability()
        {
            InitializeComponent();
        }

        private void ViewAvailability_Load(object sender, EventArgs e)
        {
            //All textboxes are not visible when the form loads
            txtRoom101.Visible = false;
            txtRoom102.Visible = false;
            txtRoom103.Visible = false;
            txtRoom104.Visible = false;
            txtRoom105.Visible = false;



        }
        private void roomSelection()
        {
            //All textboxes are not visible when the form loads

            int noOfPeople= int.Parse(txtRoom101.Text);
            int noOfPeople2 = int.Parse(txtRoom102.Text);
            int noOfPeople3 = int.Parse(txtRoom103.Text);
            int noOfPeople4 = int.Parse(txtRoom104.Text);
            int noOfPeople5 = int.Parse(txtRoom105.Text);

            if (rb101.Checked == true)
            {
                txtRoom101.Visible = true;
            }



        }
    }
}
