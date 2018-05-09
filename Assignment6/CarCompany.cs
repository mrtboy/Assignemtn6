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
        ICompanyController companyController;
        public CarCompany()
        {
            InitializeComponent();
            carController = new CarController();
            companyController = new CompanyController();
        }

        private void CarCompany_Load(object sender, EventArgs e)
        {
            pAddNewCar.Hide();
            pTopup.Hide();
            UpdateCarPanels();
            btnDelete.Hide();
            //TODO:: Get Company Data
            UpdateCompanyPanels();
            pCompanyManagement.Hide();
            pGetId.Hide();
            btnDeleteCompany.Hide();
            pShowCarsInCompany.Hide();
        }

        private void UpdateCarPanels()
        {
            listCars.Items.Clear();
            foreach (Car c in carController.GetCars())
                listCars.Items.Add(c.ToString());
        }

        private void UpdateCompanyPanels()
        {
            listCompanies.Items.Clear();
            foreach (Company c in companyController.GetCompanies())
                listCompanies.Items.Add(c.ToString());
            FillDropBoxCompany();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDropBoxCompany();
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

                UpdateCarPanels();

            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void editCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillDropBoxCompany();
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
            try
            {
                pTopup.Hide();
                pAddNewCar.Show();
                int id = int.Parse(txtIdToChange.Text);
                Car oldCar = new Car();

                foreach (Car c in carController.GetCars())
                {
                    if (c.Id == id)
                    {
                        oldCar = c;
                    }
                }

                txtCarId.Text = oldCar.Id.ToString();
                txtBrand.Text = oldCar.Brand;
                TxtModel.Text = oldCar.Model;
                dateYear.Text = oldCar.ManufacturingYear.ToLongTimeString();
                txtMileage.Text = oldCar.Mileage.ToString();
                txtPrice.Text = oldCar.Price.ToString();
                cbCompanyID.Text = oldCar.CompanyId.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK);
            }
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
                UpdateCarPanels();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
        }

        private void findCarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearCompanyForm()
        {
            txtCompanyId.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnSubmitCompany_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtCompanyId.Text);
                string address = txtAddress.Text;
                string phone = txtPhoneNumber.Text;

                Company company = new Company(id, address, phone);
                RemoveDuplicateCompany(id);

                lblMessagCompany.Text = companyController.AddNewCompany(company);
                
                ClearCompanyForm();
                UpdateCompanyPanels();

            }
            catch(Exception ex)
            {
                lblMessagCompany.Text = ex.Message;
            }
        }

        private string RemoveDuplicateCompany(int id)
        {
            bool flag = false;
            foreach (Company c in companyController.GetCompanies())
            {
                if (c.Id == id)
                {
                    companyController.DeleteCompany(id);
                    flag = true;
                }
            }

            if (!flag)
            {
                return "There are no Company with this ID";
            }
            return "Car Deleted";
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            lblMessagCompany.Text = companyController.DeleteCompany(int.Parse(txtCompanyId.Text));
            UpdateCompanyPanels();
        }

        private void btnCloseComapny_Click(object sender, EventArgs e)
        {
            pCompanyManagement.Hide();
        }

        private void addComapnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pCompanyManagement.Show();
        }

        private void updateCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteCompany.Show();
            pGetId.Show();
        }

        private void btnSubmitIdToChange_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdCompanyToChange.Text);
                Company oldCompany = new Company();

                foreach (Company c in companyController.GetCompanies())
                {
                    if (c.Id == id)
                    {
                        oldCompany = c;
                    }
                }

                txtCompanyId.Text = oldCompany.Id.ToString();
                txtAddress.Text = oldCompany.Address;
                txtPhoneNumber.Text = oldCompany.PhoneNumber.ToString();

                pCompanyManagement.Show();
                pGetId.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning", MessageBoxButtons.OK);
            }
        }

        private void pCompanyManagement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDropBoxCompany()
        {
            cbCompanyID.Items.Clear();
            foreach(Company c in companyController.GetCompanies())
            {
                cbCompanyID.Items.Add(c.Id.ToString());
            }
        }

        private void showCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pShowCarsInCompany.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pShowCarsInCompany.Hide();
                int id = int.Parse(txtShowCarsId.Text);

                List<string> companiesCars = new List<string>();
                foreach (Company com in companyController.GetCompanies())
                {
                    if(com.Id == id)
                    {
                        foreach (Car car in carController.GetCars())
                        {
                            if (id == car.CompanyId)
                            {
                                companiesCars.Add(car.ToString());
                            }
                        }
                    }
                }
                listCars.Items.Clear();
                foreach (string c in companiesCars)
                {
                    listCars.Items.Add(c);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pGetId.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pShowCarsInCompany.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pTopup.Hide();
        }

        private void showAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCarPanels();
        }
    }
}
