using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EasyFlat.Classes;
using Newtonsoft.Json;

namespace EasyFlat
{
    public partial class AllListingsForm : Form
    {
        private readonly ListingRepository _listingRepository = new ListingRepository();
        private const string ListingsFilePath = "../../listings.json";
        private User _currentUser;

        public AllListingsForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            InitializeListView();
            LoadListingsFromFile();

            // Додаємо обробник події дабл-кліку
            listView1.MouseDoubleClick += ListView1_MouseDoubleClick;
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

           
        }

        private void LoadListingsFromFile()
        {
            if (!File.Exists(ListingsFilePath)) return;

            string json = File.ReadAllText(ListingsFilePath);
            var listings = JsonConvert.DeserializeObject<List<Listing>>(json);

            foreach (var l in listings)
            {
                _listingRepository.Add(l);
                AddListingToListView(l);
            }
        }

        private void AddListingToListView(Listing l)
        {
            ListViewItem item = new ListViewItem(l.Title);
            item.SubItems.Add(l.Description);
            item.SubItems.Add(l.Location);
            item.SubItems.Add(l.RentPrice.ToString("C"));
            item.SubItems.Add(l.RoomCount.ToString());
            item.SubItems.Add(l.Area.ToString());
            item.SubItems.Add(l.PublishDate.ToShortDateString());

            listView1.Items.Add(item);
        }

        private void Listingbtn_Click(object sender, EventArgs e)
        {
            ListingForm listingForm = new ListingForm(_currentUser);
            listingForm.Show();
            this.Hide();
        }

        // Обробник події дабл-кліку
        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string title = selectedItem.Text;

                var selectedListing = _listingRepository.GetAll()
                    .FirstOrDefault(l => l.Title == title);

                if (selectedListing != null)
                {
                    ListingDetailsForm detailsForm = new ListingDetailsForm(selectedListing, _currentUser);

                    detailsForm.Show();
                }
                else
                {
                    MessageBox.Show("Не вдалося знайти вибране оголошення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
