using System;
using System.Windows.Forms;
using Hospital;

namespace LoginForm
{
    public partial class MenuDoctorsForm : Form
    {
        private Doctor _doctor;
        public MenuDoctorsForm(Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Schedule ScheduleForm = new Schedule(_doctor);
            ScheduleForm.Show();
        }

        private void DiagnosisButton_Click(object sender, EventArgs e)
        {
            WriteDiagnosisForm writeDiagnosisForm = new WriteDiagnosisForm(_doctor);
            writeDiagnosisForm.Show();
            
        }
    }
}
