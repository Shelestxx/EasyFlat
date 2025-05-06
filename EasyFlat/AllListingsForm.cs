using System;
using System.Linq;
using System.Windows.Forms;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class AllListingsForm : Form
    {
        private readonly ListingRepository _listingRepository = ListingRepository.Instance;
        private User _currentUser;

        public AllListingsForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            InitializeListView();

            _listingRepository.LoadFromFile();
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
            foreach (var l in _listingRepository.GetAll())
                AddListingToListView(l);
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

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string title = listView1.SelectedItems[0].Text;
                var selectedListing = _listingRepository.GetAll().FirstOrDefault(l => l.Title == title);

                if (selectedListing != null)
                {
                    ListingDetailsForm detailsForm = new ListingDetailsForm(selectedListing, _currentUser);
                    detailsForm.FormClosed += (s, args) => RefreshListView();
                    detailsForm.Show();
                }
                else
                {
                    MessageBox.Show("Не вдалося знайти вибране оголошення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AllListingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
