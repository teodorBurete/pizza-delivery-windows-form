using PizzaDeliveryProject2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDeliveryProject2.Forms
{
    public partial class ChangeAddressForm : Form
    {

        private Address _address;
        public Address Address { get { return _address; } set { _address = value; } }
        public ChangeAddressForm(Address address)
        {
            InitializeComponent();

            _address = address;
        }

        private void ChangeAddressForm_Load(object sender, EventArgs e)
        {
            this.tbStreet.Text = _address.Street;
            this.tbNumber.Text = _address.Number;
            this.tbDetails.Text = _address.Details;
        }

        private bool isSameAddress()
        {
            if (_address.Street.Equals(tbStreet.Text) &&
                _address.Number.Equals(tbNumber.Text) &&
                _address.Details.Equals(tbDetails.Text))
                return true;

            return false;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!isSameAddress())
            {
                Address newAddress = new Address(tbStreet.Text, tbNumber.Text, tbDetails.Text);
                _address = newAddress;
                this.DialogResult = DialogResult.Yes;
                return;
            }

            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region Data Validating Methods
        private bool isStreetNameValid()
        {
            string streetName = this.tbStreet.Text;
            if (String.IsNullOrWhiteSpace(streetName.Trim()) ||
                streetName.Length < 3)
                return false;

            return true;
        }

        private bool isStreetNumberValid()
        {
            string streetNumber = this.tbNumber.Text;
            if (String.IsNullOrWhiteSpace(streetNumber.Trim()) ||
               streetNumber.Length < 1)
                return false;

            return true;
        }
        #endregion
        #region ValidatingEvents
        private void tbStreetName_Validating(object sender, CancelEventArgs e)
        {
            if (!isStreetNameValid())
            {
                errorProvider1.SetError(tbStreet, "Street Name should be at least 3 characters long!");
                e.Cancel = true;
            }
        }

        private void tbStreetName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbStreet, null);
        }

        private void tbStreetNo_Validating(object sender, CancelEventArgs e)
        {
            if (!isStreetNumberValid())
            {
                errorProvider1.SetError(tbNumber, "Street Number should be at least 1 characters long!");
                e.Cancel = true;
            }

        }

        private void tbStreetNo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbNumber, null);
        }
        #endregion
    }
}
