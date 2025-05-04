using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EasyFlat.Classes;

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
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            int newId = _listingRepository.GetAll().Any() ? _listingRepository.GetAll().Max(l => l.ID) + 1 : 1;
            int ownerId = _currentUser.ID;

            Listing newListing = new Listing(newId, title, description, location, rentPrice, roomCount, area, ownerId, publishDate);
            _listingRepository.Add(newListing);
            SaveListingsToFile();

            MessageBox.Show("Listing added successfully.");
            ClearFields();

            AllListingsForm newForm = new AllListingsForm(_currentUser); // Создаем экземпляр Form2  
            newForm.Show(); // Открываем Form2
            this.Hide(); // Скрываем Form1 (чтобы можно было вернуться)
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
