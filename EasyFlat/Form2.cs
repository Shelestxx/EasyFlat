using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyFlat.Classes; 

namespace EasyFlat
{
    public partial class Form2 : Form
    {
        private List<Listing> apartments = new List<Listing>();
        public Form2()
        {
            InitializeComponent();
            listBoxApartments.DoubleClick += ListBoxApartments_DoubleClick;
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddApartmentForm addForm = new AddApartmentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Listing newApartment = addForm.ApartmentListing; // Отримуємо об'єкт Listing
                apartments.Add(newApartment);
                listBoxApartments.Items.Add(newApartment.Title); // Відображаємо заголовок
            }
        }

        private void listBoxApartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ListBoxApartments_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = listBoxApartments.SelectedIndex;
            if (selectedIndex >= 0) // Перевіряємо, чи вибрано елемент
            {
                Listing selectedListing = apartments[selectedIndex]; // Отримуємо вибране оголошення
                ApartmentDetailsForm detailsForm = new ApartmentDetailsForm(selectedListing);
                detailsForm.ShowDialog(); // Відкриваємо форму деталей
            }
        }
    }
}
