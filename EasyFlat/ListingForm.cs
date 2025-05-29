using EasyFlat.Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EasyFlat
{
    public partial class ListingForm : Form
    {
        private readonly ListingRepository _listingRepository;
        private readonly AppDbContext _dbContext = new AppDbContext();

        private readonly User _currentUser;

        public ListingForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _listingRepository = new ListingRepository(_dbContext);
            txtRentPrice.KeyPress += txtRentPrice_KeyPress;
            txtRoomCount.KeyPress += txtRoomCount_KeyPress;
            txtArea.KeyPress += txtArea_KeyPress;
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

        private void btnAddListing_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Помилка: користувач не авторизований.");
                return;
            }

            string title = txtTitle.Text;
            string description = txtDescription.Text;
            string location = txtLocation.Text;
            string phoneNumber = txtPhoneNumber.Text;
            decimal rentPrice;
            int roomCount;
            double area;
            DateTime publishDate = DateTime.Now;

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Будь ласка, введіть номер телефону.");
                return;
            }

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(location) || !decimal.TryParse(txtRentPrice.Text, out rentPrice) ||
                !int.TryParse(txtRoomCount.Text, out roomCount) || !double.TryParse(txtArea.Text, out area))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно!");
                return;
            }

            Listing newListing = new Listing
            {
                Title = title,
                Description = description,
                Location = location,
                RentPrice = rentPrice,
                RoomCount = roomCount,
                Area = area,
                PublishDate = publishDate,
                OwnerID = _currentUser.ID,
                PhoneNumber = phoneNumber
            };

            _listingRepository.Add(newListing);

            MessageBox.Show("Оголошення додано успішно!");
            ClearFields();

            AllListingsForm newForm = new AllListingsForm(_currentUser);
            newForm.Show();
            this.Hide();
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            txtRentPrice.Clear();
            txtRoomCount.Clear();
            txtArea.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
