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

        private void clearControls()
        {
            tbxClientName.Clear();
            tbxDroneModel.Clear();
            tbxServiceProblem.Clear();
            tbxCost.Clear();
            tbxClientName.Focus();
        }

        private void AddNewItem()
        {
            bool valid = isValid();
            if (valid)
            {
                nudServiceTag.Value += 10;
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

        private void tbxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Checking if char is digit or not. 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Limiting the input.
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
            if (tbxCost.Text.Contains(".") == false)
            {
                tbxCost.MaxLength = 32767;
            }
        }

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

        private void DisplayIntoTextExpress(int index)
        {
            rbExpress.Checked = true;
            tbxClientName.Text = ExpressService.ElementAt(index).getClientName();
            tbxDroneModel.Text = ExpressService.ElementAt(index).getDroneModel();
            tbxServiceProblem.Text = ExpressService.ElementAt(index).getServiceProblem();
            tbxCost.Text = ExpressService.ElementAt(index).getServiceCost().ToString();
            nudServiceTag.Value = ExpressService.ElementAt(index).getServiceTag();
        }

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

        private void DisplayIntoTextRegular(int index)
        {
            rbRegular.Checked = true;
            tbxClientName.Text = RegularService.ElementAt(index).getClientName();
            tbxDroneModel.Text = RegularService.ElementAt(index).getDroneModel();
            tbxServiceProblem.Text = RegularService.ElementAt(index).getServiceProblem();
            tbxCost.Text = RegularService.ElementAt(index).getServiceCost().ToString();
            nudServiceTag.Value = RegularService.ElementAt(index).getServiceTag();
        }

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

        private void btnUpdateExpress_Click(object sender, EventArgs e)
        {
            if (ExpressService.Count > 0)
            {
                FinishedList.Add(ExpressService.Dequeue());
                displayExpressQueue();
                displayFinishedList();
            }
        }

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
