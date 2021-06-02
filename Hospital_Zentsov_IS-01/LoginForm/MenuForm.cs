using System;
using System.Windows.Forms;
using Hospital;

namespace LoginForm
{
    public partial class MenuForm : Form
    {
        public RegisteredUser _user;
        public MenuForm(RegisteredUser user)
        {
            InitializeComponent();
            _user = user;
        }
        public MenuForm()
        {
            InitializeComponent();
            ShowPersonalCard.Visible = false;
            DeleteButton.Visible = false;
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            if(_user!=null)
            {

                Schedule ScheduleForm = new Schedule(_user);
                ScheduleForm.Show();
            }
            else
            {

                Schedule ScheduleForm = new Schedule();
                ScheduleForm.Show();
            }
        }

        private void ShoePersonalCard_Click(object sender, EventArgs e)
        {
            PersonalCardForm PersonalCardForm = new PersonalCardForm(_user);
            PersonalCardForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisteredUserArray registeredUserArray = Data.GetRegUsers();
            registeredUserArray.DeleteRegisteredUser(_user);
            Data.UpdateRegUsers(registeredUserArray);
            this.Close();
        }
    }
}
