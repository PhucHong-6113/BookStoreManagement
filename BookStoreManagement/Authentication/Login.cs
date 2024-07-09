using DataAccessObject.Repository;
using PresentationObject;
using PresentationObject.Admin;
using PresentationObject.Publishers;

namespace BookStoreManagement
{
    public partial class Login : Form
    {
        protected readonly UserRepository _userRepository;
        public Login()
        {
            _userRepository = new UserRepository();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userId = textBox1.Text;
            var password = textBox2.Text;
            var resultLogin = _userRepository.GetAll().FirstOrDefault(x => x.UserId == int.Parse(userId) && x.Password == password);
            if (resultLogin != null)
            {
                var form2 = new StaffList(resultLogin.FullName,this);
                var form3 = new MenuScreen(resultLogin.FullName, this);
                if (resultLogin.Role == "Admin" && resultLogin.Status == "Active")
                {
                    form2.Show();
                    this.Hide();
                }
                else if (resultLogin.Role == "Staff" && resultLogin.Status == "Active")
                {
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your account is disabled");
                }
            }
            else
            {
                MessageBox.Show("Incorrect UserId or Password");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            var form4 = new ForgotPassword();
            form4.ShowDialog();
        }
    }
}
