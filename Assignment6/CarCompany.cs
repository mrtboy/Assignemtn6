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
            pAddNewCar.Hide();
            pTopup.Hide();
            
            UpdatePanels();
            
            //TODO:: Get Company Data
        }

        private void UpdatePanels()
        {
            listCars.Items.Clear();
            foreach (Car c in carController.GetCars())
                listCars.Items.Add(c.ToString());
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pAddNewCar.Show();
        }

    

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            ClearAddCarPabel();
            pAddNewCar.Hide();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
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

                RemoveDuplicateCar(carId);

                Car car = new Car(carId, brand, model, date, mileage, price, availability, companyId);
                lblMessage.Text = carController.AddNewCar(car);
                ClearAddCarPabel();

                UpdatePanels();

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void editCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pTopup.Show();
            btnDelete.Show();
        }

        private void ClearAddCarPabel()
        {
            txtCarId.Text = "";
            txtBrand.Text = "";
            TxtModel.Text = "";
            dateYear.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
            cbCompanyID.Text = "";
        }

        private void btnIdToChange_Click(object sender, EventArgs e)
        {
            pTopup.Hide();
            pAddNewCar.Show();

            int id = int.Parse(txtIdToChange.Text);
            Car oldCar = new Car();
            
            foreach(Car c in carController.GetCars())
            {
                if(c.Id == id)
                {
                    oldCar = c;
                }
            }

            txtCarId.Text = oldCar.Id.ToString();
            txtBrand.Text = oldCar.Brand;
            TxtModel.Text = oldCar.Model;
            dateYear.Text = oldCar.ManufacturingYear.ToLongTimeString() ;
            txtMileage.Text = oldCar.Mileage.ToString();
            txtPrice.Text = oldCar.Price.ToString();
            cbCompanyID.Text = oldCar.CompanyId.ToString();
        }

        private string RemoveDuplicateCar(int id)
        {
            bool flag = false;
            foreach (Car c in carController.GetCars())
            {
                if (c.Id == id)
                {
                    carController.DeleteCar(id);
                    flag = true;
                }
            }

            if (!flag)
            {
                return "There are no Car with this ID";
            }
            return "Car Deleted";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCarId.Text);
                lblMessage.Text = RemoveDuplicateCar(id);
                UpdatePanels();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
        }

        private void findCarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
