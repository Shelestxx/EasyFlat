using EasyFlat.Classes;
using System;
using System.Windows.Forms;

namespace EasyFlat
{
    public partial class AddApartmentForm : Form
    {
        public Listing ApartmentListing { get; private set; }

        public AddApartmentForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ApartmentListing = new Listing(
                id: new Random().Next(1, 1000), // Генеруємо випадковий ID
                title: txtTitle.Text,
                description: txtDescription.Text,
                location: txtLocation.Text,
                rentPrice: decimal.Parse(txtRentPrice.Text),
                roomCount: int.Parse(txtRoomCount.Text),
                area: double.Parse(txtArea.Text),
                photoUrl: txtPhotoUrl.Text,
                ownerID: 1, // Потрібно передавати реального власника
                publishDate: DateTime.Now
            );

            DialogResult = DialogResult.OK;
            Close(); 
        }
    }
}
