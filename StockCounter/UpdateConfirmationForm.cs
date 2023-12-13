using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockCounter
{
    public partial class UpdateConfirmationForm : Form
    {
        public bool UpdateName { get { return chkUpdateName.Checked; } }
        public bool UpdateHulpnummer { get { return chkUpdateHulpnummer.Checked; } }
        public bool UpdateType { get { return chkUpdateType.Checked; } }
        public bool UpdateLeverancier { get { return chkUpdateLeverancier.Checked; } }
        public bool UpdateStockCount { get { return chkUpdateStockCount.Checked; } }

        public UpdateConfirmationForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
