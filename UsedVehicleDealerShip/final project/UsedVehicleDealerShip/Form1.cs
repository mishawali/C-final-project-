using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedVehicleDealerShip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // create a vehicle
            try
            {

                // get make id
                string make = comboBoxMake.Text.Trim();

                if (make.Length == 0)
                {
                    MessageBox.Show("Please Enter a Make");
                    return;
                }

                int makeid = DBMgr.getNameId(make, "Make", "MakeId", null);

                // get vehicle type
                string vehicleType = comboBoxVehicleType.Text.Trim();

                if (vehicleType.Length == 0)
                {
                    MessageBox.Show("Please Enter a Vehicle Type");
                    return;
                }

                int vehicleTypeId = DBMgr.getNameId(vehicleType, "VehicleType", "VehicleTypeId", null);



                // get vehicle model data
                VehicleModel vm = new VehicleModel();

                // get model name
                vm.Name = comboBoxModel.Text.Trim();

                if (vm.Name.Length == 0)
                {
                    MessageBox.Show("Please Enter a proper model Name");
                    return;
                }

                // engine size
                int engineSize = 0;
                if (!int.TryParse(textBoxEngineSize.Text, out engineSize))
                {
                    MessageBox.Show("Please Enter a proper Engine Size");
                    return;
                }

                // number of doors
                vm.EngineSize = engineSize;

                int numberOfDoors = 0;
                if (!int.TryParse(textBoxNumberOfDoors.Text, out numberOfDoors))
                {
                    MessageBox.Show("Please Enter a proper Number of Doors");
                    return;
                }

                vm.NumberOfDoors = numberOfDoors;

                // get colour
                vm.Colour = comboBoxColor.Text.Trim();

                if (vm.Colour.Length == 0)
                {
                    MessageBox.Show("Please Enter a proper vehicle Colour");
                    return;
                }

                // assign vehicle id
                vm.VehicleTypeId = vehicleTypeId;

                // add vehiclie model
                int vehicleModelId = DBMgr.getNameId(vm.Name, "VehicleModel", "ModelId", vm);

                // add vehicle
                Vehicle v = new Vehicle();
                v.MakeId = makeid;
                v.ModelId = vehicleModelId;


                // get year
                int year = 0;

                if (!int.TryParse(comboBoxYear.Text, out year))
                {
                    MessageBox.Show("Please Enter a proper year");
                    return;
                }

                v.Year = year;

                // get yprice
                double price = 0;

                if (!double.TryParse(textBoxPrice.Text, out price))
                {
                    MessageBox.Show("Please Enter a proper price");
                    return;
                }

                v.Price = price;

                // get cost
                double cost = 0;

                if (!double.TryParse(textBoxCost.Text, out cost))
                {
                    MessageBox.Show("Please Enter a proper cost");
                    return;
                }

                v.Cost = cost;

                // get sold date
              
                    v.SoldDate = dateTimePickerSoldDate.Value;


                v.Sold = checkBoxSoldDate.Checked;
                

                // add vehicle
                int index = DBMgr.insertVehicle(v);

                // update list of vehicle id
                comboBoxVehicles.DataSource = DBMgr.getTable("Vehicle");
                comboBoxVehicles.DisplayMember = "VehicleId";
                comboBoxVehicles.ValueMember = "VehicleId";

                // update makes
                comboBoxMake.DataSource = DBMgr.getTable("Make");
                comboBoxMake.DisplayMember = "Name";
                comboBoxMake.ValueMember = "MakeId";

                // update models
                comboBoxModel.DataSource = DBMgr.getTable("VehicleModel");
                comboBoxModel.DisplayMember = "Name";
                comboBoxModel.ValueMember = "ModelId";

                // update vehicle types
                comboBoxVehicleType.DataSource = DBMgr.getTable("VehicleType");
                comboBoxVehicleType.DisplayMember = "Name";
                comboBoxVehicleType.ValueMember = "Name";

                // show this vehicle id
                int id = DBMgr.getVehicleId(v.MakeId, v.ModelId);
                comboBoxVehicles.Text = id.ToString();

                show_vehicle();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }

        }

        // read data from controls
        public void readControls()
        {




        }

        private void buttonMakes_Click(object sender, EventArgs e)
        {
            // show makes in data grid

            try
            {
                dataGridView1.DataSource = DBMgr.getTable("Make");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            try
            {
                // show makes
                comboBoxMake.DataSource = DBMgr.getTable("Make");
                comboBoxMake.DisplayMember = "Name";
                comboBoxMake.ValueMember = "MakeId";

                // show models
                comboBoxModel.DataSource = DBMgr.getTable("VehicleModel");
                comboBoxModel.DisplayMember = "Name";
                comboBoxModel.ValueMember = "ModelId";

                // show vehicle types
                comboBoxVehicleType.DataSource = DBMgr.getTable("VehicleType");
                comboBoxVehicleType.DisplayMember = "Name";
                comboBoxVehicleType.ValueMember = "Name";

                // list of vehicle id
                comboBoxVehicles.DataSource = DBMgr.getTable("Vehicle");
                comboBoxVehicles.DisplayMember = "VehicleId";
                comboBoxVehicles.ValueMember = "VehicleId";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }

        }

        private void buttonVehicleTypes_Click(object sender, EventArgs e)
        {
            // show vehicle types in data grid

            try
            {
                dataGridView1.DataSource = DBMgr.getTable("VehicleType");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }
        }

        private void buttonModels_Click(object sender, EventArgs e)
        {
            // show models in data grid

            try
            {
                dataGridView1.DataSource = DBMgr.getTable("VehicleModel");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }
        }

        private void buttonVehicles_Click(object sender, EventArgs e)
        {
            // show vehicles in data grid

            try
            {
                dataGridView1.DataSource = DBMgr.getTable("Vehicle");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModel.Items.Count > 0)
            {

                // load model details
                string model = comboBoxModel.Text;
                VehicleModel vm = DBMgr.getModelByName(model);

                // update details
                if (vm != null)
                {
                    textBoxEngineSize.Text = vm.EngineSize.ToString();
                    textBoxNumberOfDoors.Text = vm.NumberOfDoors.ToString();
                    comboBoxColor.Text = vm.Colour;


                    // update vehicle combo's
                    int index = -1;
                    int i = 0;
                    foreach (DataRowView x in comboBoxVehicleType.Items)
                    {
                        int vehicleTypeId = (int)x.Row["VehicleTypeId"];
                        if (vehicleTypeId == vm.VehicleTypeId)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }


                    if (index >= 0) comboBoxVehicleType.SelectedIndex = index;
                }
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          
                show_vehicle();

        }


        private void show_vehicle()
        {
            if (comboBoxVehicles.SelectedValue != null)
            {

                // read vehicle
                int vehicleid = (int)comboBoxVehicles.SelectedValue;
                Vehicle v = DBMgr.getVehicleById(vehicleid);

                string make = DBMgr.getMakeById(v.MakeId);
                VehicleModel model = DBMgr.getModelById(v.ModelId);


                // update combo's
                int index = -1;
                int i = 0;
                foreach (DataRowView x in comboBoxModel.Items)
                {
                    string name = x.Row["Name"].ToString();
                    if (name == model.Name)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }


                if (index >= 0) comboBoxModel.SelectedIndex = index;

                i = 0;
                index = -1;
                foreach (DataRowView x in comboBoxMake.Items)
                {
                    string name = x.Row["Name"].ToString();
                    if (name == make)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                if (index >= 0) comboBoxMake.SelectedIndex = index;


                // update details
                if (v != null)
                {
                    comboBoxYear.Text = v.Year.ToString();
                    textBoxPrice.Text = v.Price.ToString();
                    textBoxCost.Text = v.Cost.ToString();
                    dateTimePickerSoldDate.Value = v.SoldDate;
                    checkBoxSoldDate.Checked = v.Sold;
                }
            }            
        }

        private void comboBoxMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedValue != null)
            {

                // load model details
                int makeid = (int)comboBoxModel.SelectedValue;

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        // clear controls
        private void clearControls()
        {
            // clear controls
            textBoxEngineSize.Clear();
            textBoxNumberOfDoors.Clear();
            comboBoxColor.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;
            textBoxPrice.Clear();
            textBoxCost.Clear();
            dateTimePickerSoldDate.Value = DateTime.Now;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // exit
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (comboBoxVehicles.SelectedValue != null)
            {

                // read vehicle
                int vehicleid = (int)comboBoxVehicles.SelectedValue;

                DBMgr.deleteVehicle(vehicleid);

                // list of vehicle id
                comboBoxVehicles.DataSource = DBMgr.getTable("Vehicle");
                comboBoxVehicles.DisplayMember = "VehicleId";
                comboBoxVehicles.ValueMember = "VehicleId";

                clearControls();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //  update a vehicle
            try
            {

                // get make id
                string make = comboBoxMake.Text.Trim();

                if (make.Length == 0)
                {
                    MessageBox.Show("Please Enter/select a Make");
                    return;
                }

                int makeid = DBMgr.getNameId(make, "Make", "MakeId", null);


                // get model 
                string model = comboBoxModel.Text.Trim();

                if (model.Length == 0)
                {
                    MessageBox.Show("Please Enter/select a Mudel");
                    return;
                }

        


                // get vehicle type
                string vehicleType = comboBoxVehicleType.Text.Trim();

                if (vehicleType.Length == 0)
                {
                    MessageBox.Show("Please Enter a Vehicle Type");
                    return;
                }

                int vehicleTypeId = DBMgr.getNameId(vehicleType, "VehicleType", "VehicleTypeId", null);

                // make model
                VehicleModel vm = new VehicleModel();
                vm.Name = model;
    
           
                // engine size
                int engineSize = 0;
                if (!int.TryParse(textBoxEngineSize.Text, out engineSize))
                {
                    MessageBox.Show("Please Enter a proper Engine Size");
                    return;
                }

                // number of doors
                vm.EngineSize = engineSize;

                int numberOfDoors = 0;
                if (!int.TryParse(textBoxNumberOfDoors.Text, out numberOfDoors))
                {
                    MessageBox.Show("Please Enter a proper Number of Doors");
                    return;
                }

                vm.NumberOfDoors = numberOfDoors;

                // get colour
                vm.Colour = comboBoxColor.Text.Trim();

                if (vm.Colour.Length == 0)
                {
                    MessageBox.Show("Please Enter a proper vehicle Colour");
                    return;
                }

                // assign vehicle id
                vm.VehicleTypeId = vehicleTypeId;

                // get model id
                int vehicleModelId = DBMgr.getNameId(model, "VehicleModel", "ModelId", vm);
                vm.ModelId = vehicleModelId;

                // update vehicle model
                DBMgr.updateModel(vm);

                // get vehicle 
                Vehicle v = new Vehicle();
                v.VehicleId = int.Parse(comboBoxVehicles.Text);
                v.ModelId = vm.ModelId;
                v.MakeId = makeid;
                
                
                // get year
                int year = 0;

                if (!int.TryParse(comboBoxYear.Text, out year))
                {
                    MessageBox.Show("Please Enter a proper year");
                    return;
                }

                v.Year = year;

                // get yprice
                double price = 0;

                if (!double.TryParse(textBoxPrice.Text, out price))
                {
                    MessageBox.Show("Please Enter a proper price");
                    return;
                }

                v.Price = price;

                // get cost
                double cost = 0;

                if (!double.TryParse(textBoxCost.Text, out cost))
                {
                    MessageBox.Show("Please Enter a proper cost");
                    return;
                }

                v.Cost = cost;

                // get sold date
                v.SoldDate = dateTimePickerSoldDate.Value;

                // get sold
                v.Sold = checkBoxSoldDate.Checked;

                // updae vehicle
                DBMgr.updateVehicle(v);

                // update makes
                comboBoxMake.DataSource = DBMgr.getTable("Make");
                comboBoxMake.DisplayMember = "Name";
                comboBoxMake.ValueMember = "MakeId";

                // update models
                comboBoxModel.DataSource = DBMgr.getTable("VehicleModel");
                comboBoxModel.DisplayMember = "Name";
                comboBoxModel.ValueMember = "ModelId";

                // update vehicle types
                comboBoxVehicleType.DataSource = DBMgr.getTable("VehicleType");
                comboBoxVehicleType.DisplayMember = "Name";
                comboBoxVehicleType.ValueMember = "Name";

                // show this vehicle id
                comboBoxVehicles.Text = v.VehicleId.ToString();

                show_vehicle();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error reading data base", ex.Message);
            }
        }

    }
}

