using EasyFlat.Classes;
using System;
using System.Windows.Forms;

namespace EasyFlat
{
    public partial class ApartmentDetailsForm : Form
    {
        private Listing apartment; // Змінна для збереження переданого оголошення

        public ApartmentDetailsForm(Listing apartment)
        {
            InitializeComponent();
            this.apartment = apartment;
            DisplayApartmentDetails(); // Викликаємо метод для відображення даних
        }

        private void DisplayApartmentDetails()
        {
            lblTitle.Text = $"Назва: {apartment.Title}";
            lblDescription.Text = $"Опис: {apartment.Description}";
            lblLocation.Text = $"Локація: {apartment.Location}";
            lblRentPrice.Text = $"Ціна оренди: {apartment.RentPrice} грн";
            lblRoomCount.Text = $"Кімнат: {apartment.RoomCount}";
            lblArea.Text = $"Площа: {apartment.Area} м²";
            lblOwnerID.Text = $"ID власника: {apartment.OwnerID}";
            lblPublishDate.Text = $"Дата публікації: {apartment.PublishDate.ToShortDateString()}";
        }
    } 
}
