using System;
using System.Collections.Generic;


namespace Hospital
{
   
    [Serializable]
    public class RegisteredUser : User
    {

        private Appointment _appointment;
        private List<MedicalHistory> _medicalHistory;
        public RegisteredUser(Person person, DateTime birthDate, UserAdress adress, LoginDetails loginDetails)
        {
            _medicalHistory = new List<MedicalHistory>();
            _person = person;
            _birthDate = birthDate;
            _adress = adress;
            _loginDetails = loginDetails;
        }
        public void MakeAppoinment(int dayNumber, int appNumber,Doctor doctor)
        {
            if(doctor!=null)
                _appointment = new Appointment(dayNumber, appNumber, doctor);
            else
                throw new ArgumentNullException("Doctor cannot be null");
        }
        public bool IsMadeAppoinment
        {
            get
            {
                return _appointment.isMadeAppoinment;
            }
        }
        public void AddMedicalHistory(string diagnosis,Person doctor)
        {
            if(diagnosis!=null)
                _medicalHistory.Add(new MedicalHistory(DateTime.Now, diagnosis, doctor));
            else
                throw new ArgumentNullException("Diagnosis cannot be null");
        }
        public MedicalHistory[] GetMedicalHistory
        {
            get
            {
                if (_medicalHistory != null)
                    return _medicalHistory.ToArray();
                else
                    return null;
            }
        }
        public Appointment Appointment
        {
            get { return _appointment; }
        }
        public void DeleteAppoinmrnt()
        {
            _appointment = new Appointment();
        }
    }
}
