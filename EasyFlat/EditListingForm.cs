using System;
using System.Windows.Forms;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class EditListingForm : Form
    {
        public Listing UpdatedListing { get; private set; }
        private readonly Listing _originalListing;

        private readonly ListingRepository _listingRepository;

        public EditListingForm(Listing listing, ListingRepository listingRepository)
        {
            InitializeComponent();
            _originalListing = listing;
            _listingRepository = listingRepository;
            FillFields();

            txtRentPrice.KeyPress += txtRentPrice_KeyPress;
            txtRoomCount.KeyPress += txtRoomCount_KeyPress;
            txtArea.KeyPress += txtArea_KeyPress;
        }

        private void FillFields()
        {
            txtTitle.Text = _originalListing.Title;
            txtDescription.Text = _originalListing.Description;
            txtLocation.Text = _originalListing.Location;
            txtRentPrice.Text = _originalListing.RentPrice.ToString();
            txtRoomCount.Text = _originalListing.RoomCount.ToString();
            txtArea.Text = _originalListing.Area.ToString();
            txtPhoneNumber.Text = _originalListing.PhoneNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                !decimal.TryParse(txtRentPrice.Text, out decimal rentPrice) ||
                !int.TryParse(txtRoomCount.Text, out int roomCount) || !double.TryParse(txtArea.Text, out double area))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            _originalListing.Title = txtTitle.Text;
            _originalListing.Description = txtDescription.Text;
            _originalListing.Location = txtLocation.Text;
            _originalListing.RentPrice = rentPrice;
            _originalListing.RoomCount = roomCount;
            _originalListing.Area = area;
            _originalListing.PhoneNumber = txtPhoneNumber.Text;

            _listingRepository.Update(_originalListing);

            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtRentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("У поле 'Ціна' можна вводити лише цифри.");
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }

        private void txtRoomCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("У поле 'Кількість кімнат' можна вводити лише цифри.");
                e.Handled = true;
            }
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("У поле 'Площа' можна вводити лише цифри.");
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }
    }
}
