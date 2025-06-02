using System;
using System.Linq;
using System.Windows.Forms;
using EasyFlat.Classes;

namespace EasyFlat
{
    public partial class AdminUserManagementForm : Form
    {
        private AppDbContext _context;


        public AdminUserManagementForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            LoadUsers();
        }



        private void LoadUsers()
        {
            dgvUsers.DataSource = _context.Users
                .Select(u => new { u.ID, u.Name, u.Email, u.PhoneNumber, u.Type })
                .ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                int userId = (int)dgvUsers.CurrentRow.Cells["ID"].Value;

                var userToDelete = _context.Users.FirstOrDefault(u => u.ID == userId);
                if (userToDelete != null)
                {
                    var result = MessageBox.Show("Ви впевнені, що хочете видалити цього користувача?", "Підтвердження", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        _context.Users.Remove(userToDelete);
                        _context.SaveChanges();
                        LoadUsers();
                        MessageBox.Show("Користувача видалено.");
                    }
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
