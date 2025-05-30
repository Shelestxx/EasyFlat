﻿using System;
using System.Linq;
using System.Windows.Forms;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class AllListingsForm : Form
    {
        private readonly AppDbContext _db = new AppDbContext();
        private User _currentUser;
        private readonly ListingRepository _listingRepository = new ListingRepository(new AppDbContext());

        public AllListingsForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            InitializeListView();

            
            RefreshListView();

            listView1.MouseDoubleClick += ListView1_MouseDoubleClick;
        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

        }

        private void RefreshListView()
        {
            listView1.Items.Clear();
            using (var db = new AppDbContext())
            {
                var listings = db.Listings.ToList();
                foreach (var l in listings)
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
            item.SubItems.Add(l.PhoneNumber);
            listView1.Items.Add(item);
        }
        private void Listingbtn_Click(object sender, EventArgs e)
        {
            ListingForm listingForm = new ListingForm(_currentUser);
            listingForm.Show();
            this.Hide();
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string title = listView1.SelectedItems[0].Text;
                using (var db = new AppDbContext())
                {
                    var selectedListing = db.Listings.FirstOrDefault(l => l.Title == title);

                    if (selectedListing != null)
                    {
                        var detailsForm = new ListingDetailsForm(selectedListing, _currentUser, _listingRepository);
                        detailsForm.FormClosed += (s, args) => RefreshListView();
                        detailsForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося знайти вибране оголошення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void AllListingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal priceFrom = numPriceFrom.Value;
            decimal priceTo = numPriceTo.Value;
            int roomsFrom = (int)numRoomsFrom.Value;
            int roomsTo = (int)numRoomsTo.Value;

            using (var db = new AppDbContext())
            {
                var filteredListings = db.Listings
                    .Where(l =>
                        (priceFrom == 0 || l.RentPrice >= priceFrom) &&
                        (priceTo == 0 || l.RentPrice <= priceTo) &&
                        (roomsFrom == 0 || l.RoomCount >= roomsFrom) &&
                        (roomsTo == 0 || l.RoomCount <= roomsTo)
                    )
                    .ToList();

                listView1.Items.Clear();
                foreach (var listing in filteredListings)
                    AddListingToListView(listing);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
