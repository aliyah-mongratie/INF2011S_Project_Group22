using INF2011S_Project_Group22.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            
           roomSelection();


        }
        private void roomSelection()
        {
            



            //Textboxes are made visible based on the rooms selected by the user.
            if (cbRoom101.Checked)
           {
                txtRoom101.Visible = true;  
           }
           else
           {
                 txtRoom101.Visible = false;
           }

           if (cbRoom102.Checked)
           {
                 txtRoom102.Visible = true;
           }
           else
           {
                 txtRoom102.Visible = false;
           }

           if (cbRoom103.Checked)
           {
                    txtRoom103.Visible = true;
           }
           else
           {
                    txtRoom103.Visible = false;

           }
           if (cbRoom104.Checked)
           {
                      txtRoom104.Visible = true;
           }
           else
           {
                      txtRoom104.Visible = false;
           }
           if (cbRoom105.Checked)
           {
                         txtRoom105.Visible = true;
           }
           else
           {
                         txtRoom105.Visible = false;
           }

           //the textboxes will retrieve the number of people in each room from the user.






        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If the user is satisfied with the room selection, they can proceed to the reservation form
            frmCreateReservation newForm = new frmCreateReservation();
            newForm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if the user wants to carry out a different functionality, the back button directs them back to the homepage.
            this.Close();// close is used, since the homepage is already open in the background.
        }
    }
}

