using BusinessObject.Repository;
using PresentationObject;
using PresentationObject.Admin;
using PresentationObject.Publishers;

namespace BookStoreManagement
{
    public partial class Login : Form
    {
        protected readonly UserRepository userRepository;
        public Login()
        {
            userRepository = new UserRepository();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userId = textBox1.Text;
            var password = textBox2.Text;
            var resultLogin = userRepository.GetAll().FirstOrDefault(x => x.UserId == int.Parse(userId) && x.Password == password);
            if (resultLogin != null)
            {
                var form2 = new Library();
                var form3 = new MenuScreen();
                if (resultLogin.Role == "Admin" && resultLogin.Status == "Active")
                {
                    form2.ShowDialog();
                }
                else if (resultLogin.Role == "Staff" && resultLogin.Status == "Active")
                {
                    form3.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var form4 = new ForgotPassword();
            form4.ShowDialog();
        }
    }
}
