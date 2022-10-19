using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// Patrick Wheatley | 30053724
namespace IcarusDroneRepairManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        // 6.2	Create a global List<T> of type Drone called “FinishedList”. 
        // 6.3	Create a global Queue<T> of type Drone called “RegularService”.
        // 6.4	Create a global Queue<T> of type Drone called “ExpressService”.

        List<Drone> FinishedList = new List<Drone>();
        Queue<Drone> RegularService = new Queue<Drone>();
        Queue<Drone> ExpressService = new Queue<Drone>();
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        // 6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void clearControls()
        {
            tbxClientName.Clear();
            tbxDroneModel.Clear();
            tbxServiceProblem.Clear();
            tbxCost.Clear();
            tbxClientName.Focus();
        }

        // 6.5	Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority. Use TextBoxes for the Client Name, Drone Model, Service Problem and Service Cost. Use a numeric up/down control for the Service Tag. The new service item will be added to the appropriate Queue based on the Priority radio button.
        private void AddNewItem()
        {
            bool valid = isValid();
            if (valid)
            {
                incrementServiceTag();
                char servicePriority = GetServicePriority();
                double cost = Convert.ToDouble(tbxCost.Text);
                string name = tbxClientName.Text;
                string model = tbxDroneModel.Text;
                string problem = tbxServiceProblem.Text;
                int servicetag = Convert.ToInt32(nudServiceTag.Value);
                if (servicePriority == 'R')
                {
                    RegularService.Enqueue(new Drone(name, model, problem, cost, servicetag));
                    displayRegularQueue();
                }
                else
                {
                    // 6.6	Before a new service item is added to the Express Queue the service cost must be increased by 15%.
                    cost = Math.Round(cost * 1.15, 2);
                    ExpressService.Enqueue(new Drone(name, model, problem, cost, servicetag));
                    displayExpressQueue();
                }
                clearControls();
            }
            else
            {
                MessageBox.Show("Atleast one of the input controls are empty.");
            }
        }
        // 6.11	Create a custom method to increment the service tag control, this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void incrementServiceTag()
        {
            nudServiceTag.Value += 10;
        }

        // 6.8	Create a custom method that will display all the elements in the RegularService queue. The display must use a List View and with appropriate column headers.
        private void displayRegularQueue()
        {
            lvRegular.Items.Clear();
            foreach (var i in RegularService)
            {
                ListViewItem lv1 = new ListViewItem(i.getClientName(), 0);
                lv1.SubItems.Add(i.getDroneModel());
                lv1.SubItems.Add(i.getServiceProblem());
                lv1.SubItems.Add("$" + i.getServiceCost().ToString());
                lv1.SubItems.Add(i.getServiceTag().ToString());
                lvRegular.Items.Add(lv1);
            }
        }
        // 6.9	Create a custom method that will display all the elements in the ExpressService queue. The display must use a List View and with appropriate column headers.
        private void displayExpressQueue()
        {
            lvExpress.Items.Clear();
            foreach (var i in ExpressService)
            {
                ListViewItem lv1 = new ListViewItem(i.getClientName(), 0);
                lv1.SubItems.Add(i.getDroneModel());
                lv1.SubItems.Add(i.getServiceProblem());
                lv1.SubItems.Add("$" + i.getServiceCost().ToString());
                lv1.SubItems.Add(i.getServiceTag().ToString());
                lvExpress.Items.Add(lv1);
            }
        }
        private bool isValid()
        {
            char rbSP = GetServicePriority();
            bool valid = false;
            if (!string.IsNullOrEmpty(tbxClientName.Text) && !string.IsNullOrEmpty(tbxDroneModel.Text) && !string.IsNullOrEmpty(tbxServiceProblem.Text) && !string.IsNullOrEmpty(tbxCost.Text) && char.IsLetter(rbSP)) {                
                valid = true;
                try
                {
                    double cost = Convert.ToDouble(tbxCost.Text);
                }
                catch (Exception)
                {
                    valid = false;
                }
            }
            return valid;
        }

        // 6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group. This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private char GetServicePriority()
        {
            if (rbRegular.Checked)
            {
                return 'R';
            }
            else if (rbExpress.Checked)
            {
                return 'E';
            }
            return '0';
        }

        // 6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        private void tbxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checking if char is digit or not. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Limiting the input to only 2 decimals. 
            if (e.KeyChar == '.' && tbxCost.Text.Contains(".") == false)
            {
                tbxCost.MaxLength = tbxCost.TextLength + 3;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {               
                e.Handled = true;
            }
        }

        private void tbxCost_TextChanged(object sender, EventArgs e)
        {
            // If there isn't a decimal point then remove the 2 decimals restriction. 
            if (tbxCost.Text.Contains(".") == false)
            {
                tbxCost.MaxLength = 32767;
            }
        }
        // 6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void lvExpress_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayIntoTextExpress(lvExpress.SelectedIndices[0]);
            }
            catch (Exception)
            {

            }
        }
        // 6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void DisplayIntoTextExpress(int index)
        {
            rbExpress.Checked = true;
            tbxClientName.Text = ExpressService.ElementAt(index).getClientName();
            tbxDroneModel.Text = ExpressService.ElementAt(index).getDroneModel();
            tbxServiceProblem.Text = ExpressService.ElementAt(index).getServiceProblem();
            tbxCost.Text = ExpressService.ElementAt(index).getServiceCost().ToString();
            nudServiceTag.Value = ExpressService.ElementAt(index).getServiceTag();
        }

        // 6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void lvRegular_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DisplayIntoTextRegular(lvRegular.SelectedIndices[0]);
            }
            catch (Exception)
            {

            }
        }
        // 6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void DisplayIntoTextRegular(int index)
        {
            rbRegular.Checked = true;
            tbxClientName.Text = RegularService.ElementAt(index).getClientName();
            tbxDroneModel.Text = RegularService.ElementAt(index).getDroneModel();
            tbxServiceProblem.Text = RegularService.ElementAt(index).getServiceProblem();
            tbxCost.Text = RegularService.ElementAt(index).getServiceCost().ToString();
            nudServiceTag.Value = RegularService.ElementAt(index).getServiceTag();
        }

        // 6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure. The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void btnUpdateRegular_Click(object sender, EventArgs e)
        {
            if (RegularService.Count > 0)
            {
                FinishedList.Add(RegularService.Dequeue());
                displayRegularQueue();
                displayFinishedList();
            }
        }

        private void displayFinishedList()
        {
            lbFinished.Items.Clear();
            foreach (var i in FinishedList)
            {
                lbFinished.Items.Add(i.getClientName() + " $" + i.getServiceCost());
            }
        }

        // 6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure. The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void btnUpdateExpress_Click(object sender, EventArgs e)
        {
            if (ExpressService.Count > 0)
            {
                FinishedList.Add(ExpressService.Dequeue());
                displayExpressQueue();
                displayFinishedList();
            }
        }
        // 6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void lbFinished_DoubleClick(object sender, EventArgs e)
        {
            if (FinishedList.Count > 0 && lbFinished.SelectedIndex >= 0)
            {
                FinishedList.Remove(FinishedList[0]);
                displayFinishedList();
            }
        }
    }
}
