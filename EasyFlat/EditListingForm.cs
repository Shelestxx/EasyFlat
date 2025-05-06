using System;
using System.Windows.Forms;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class EditListingForm : Form
    {
        public Listing UpdatedListing { get; private set; }

        private readonly Listing _originalListing;

        public EditListingForm(Listing listing)
        {
            InitializeComponent();
            _originalListing = listing;
            FillFields();
        }

        private void FillFields()
        {
            txtTitle.Text = _originalListing.Title;
            txtDescription.Text = _originalListing.Description;
            txtLocation.Text = _originalListing.Location;
            txtRentPrice.Text = _originalListing.RentPrice.ToString();
            txtRoomCount.Text = _originalListing.RoomCount.ToString();
            txtArea.Text = _originalListing.Area.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) || !decimal.TryParse(txtRentPrice.Text, out decimal rentPrice) ||
                !int.TryParse(txtRoomCount.Text, out int roomCount) || !double.TryParse(txtArea.Text, out double area))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            UpdatedListing = new Listing(
                _originalListing.ID,
                txtTitle.Text,
                txtDescription.Text,
                txtLocation.Text,
                rentPrice,
                roomCount,
                area,
                _originalListing.OwnerID,
                _originalListing.PublishDate
            );

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
