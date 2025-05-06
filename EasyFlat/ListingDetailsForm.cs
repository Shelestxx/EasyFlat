using System;
using System.Windows.Forms;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class ListingDetailsForm : Form
    {
        private Listing _listing;
        private User _currentUser;

        public ListingDetailsForm(Listing listing, User currentUser)
        {
            InitializeComponent();
            _listing = listing;
            _currentUser = currentUser;
            DisplayDetails();
            MakeFieldsReadOnly(); // ← робимо всі поля тільки для читання
        }

        private void DisplayDetails()
        {
            txtTitle.Text = _listing.Title;
            txtDescription.Text = _listing.Description;
            txtLocation.Text = _listing.Location;
            txtRentPrice.Text = _listing.RentPrice.ToString();
            txtRoomCount.Text = _listing.RoomCount.ToString();
            txtArea.Text = _listing.Area.ToString();
            lblPublishDate.Text = _listing.PublishDate.ToShortDateString();
        }

        private void MakeFieldsReadOnly()
        {
            txtTitle.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtLocation.ReadOnly = true;
            txtRentPrice.ReadOnly = true;
            txtRoomCount.ReadOnly = true;
            txtArea.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_currentUser.ID != _listing.OwnerID)
            {
                MessageBox.Show("Ви не можете редагувати це оголошення.");
                return;
            }

            EditListingForm editForm = new EditListingForm(_listing);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                _listing = editForm.UpdatedListing;
                ListingRepository.Instance.Update(_listing);
                MessageBox.Show("Оголошення оновлено.");
                DisplayDetails();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentUser.ID != _listing.OwnerID)
            {
                MessageBox.Show("Ви не можете видалити це оголошення.");
                return;
            }

            var result = MessageBox.Show("Ви впевнені, що хочете видалити це оголошення?", "Підтвердження", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ListingRepository.Instance.Remove(_listing);
                MessageBox.Show("Оголошення видалено.");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
