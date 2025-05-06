using EasyFlat.Classes;
using EasyFlat;
using Newtonsoft.Json;
using static System.Windows.Forms.MonthCalendar;
namespace EasyFlat
{
    public partial class ListingForm : Form
    {
        private readonly ListingRepository _listingRepository = new ListingRepository();
        private readonly User _currentUser;

        private const string ListingsFilePath = "../../listings.json";

        public ListingForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadListingsFromFile();

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
            {
                e.Handled = true;
            }
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
            {
                e.Handled = true;
            }
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
            decimal rentPrice;
            int roomCount;
            double area;
            DateTime publishDate = DateTime.Now;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(location) || !decimal.TryParse(txtRentPrice.Text, out rentPrice) ||
                !int.TryParse(txtRoomCount.Text, out roomCount) || !double.TryParse(txtArea.Text, out area))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно!");
                return;
            }

            int newId = _listingRepository.GetAll().Any() ? _listingRepository.GetAll().Max(l => l.ID) + 1 : 1;
            int ownerId = _currentUser.ID;

            Listing newListing = new Listing(newId, title, description, location, rentPrice, roomCount, area, ownerId, publishDate);
            _listingRepository.Add(newListing);
            SaveListingsToFile();

            MessageBox.Show("Список додано успішно!");
            ClearFields();

            AllListingsForm newForm = new AllListingsForm(_currentUser);
            newForm.Show();
            this.Hide();
        }

        private void LoadListingsFromFile()
        {
            if (File.Exists(ListingsFilePath))
            {
                string json = File.ReadAllText(ListingsFilePath);
                var listings = JsonConvert.DeserializeObject<List<Listing>>(json);
                foreach (var listing in listings)
                {
                    _listingRepository.Add(listing);
                }
            }
        }

        private void SaveListingsToFile()
        {
            string json = JsonConvert.SerializeObject(_listingRepository.GetAll().ToList(), Formatting.Indented);
            File.WriteAllText(ListingsFilePath, json);
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            txtRentPrice.Clear();
            txtRoomCount.Clear();
            txtArea.Clear();
        }
    }
}
