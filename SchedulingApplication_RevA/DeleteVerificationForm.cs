using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication_RevA
{
    public partial class DeleteVerificationForm : Form
    {
        public string User { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } 
        public DeleteVerificationForm()
        {
            InitializeComponent();
        }

        public DeleteVerificationForm(string user, int custId, string custName)
        {
            InitializeComponent();
            User = user;
            CustomerId = custId;
            CustomerName = custName;

        }
        private void YesBtn_Click(object sender, EventArgs e)
        {
            DataHelperModify.DeleteCustomer(CustomerId, CustomerName);
            this.Hide();
            CustomerRecordsForm rtn = new CustomerRecordsForm(User);
            rtn.ShowDialog();
            this.Close();
        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerRecordsForm rtn = new CustomerRecordsForm(User);
            rtn.ShowDialog();
            this.Close();
        }
    }
}
