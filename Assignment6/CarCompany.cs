using Assignment6.Controllers;
using Assignment6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class CarCompany : Form
    {
        ICarController carController;
        public CarCompany()
        {
            InitializeComponent();
            carController = new CarController();
        }

        private void CarCompany_Load(object sender, EventArgs e)
        {
            gbAddNewCar.Hide();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbAddNewCar.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int carId = int.Parse(txtCarId.Text);
                string brand = txtBrand.Text;
                string model = TxtModel.Text;
                DateTime date = DateTime.Parse(dateYear.Text);
                double mileage = double.Parse(txtMileage.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                bool availability = false;
                if (chkAvailable.CheckState == CheckState.Checked)
                {
                    availability = true;
                }

                int companyId = int.Parse(cbCompanyID.Text);

                Car car = new Car(carId, brand, model, date, mileage, price, availability, companyId);
                lblMessage.Text = carController.AddNewCar(car);
            }catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            gbAddNewCar.Hide();
        }
    }
}
