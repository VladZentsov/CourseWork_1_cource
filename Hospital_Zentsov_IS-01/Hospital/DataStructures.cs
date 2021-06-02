using System;


namespace Hospital
{
    [Serializable]
    public struct Person
    {
        public string Name;
        public string Surname;
        public bool Sex;
        public Person(string name, string surname, bool sex)
        {
            if(name!=null&&surname!=null)
            {
                Name = name;
                Surname = surname;
                Sex = sex;
            }
            else
                throw new ArgumentNullException("Name and surname cannot be null");
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
    }
    [Serializable]
    public struct UserAdress
    {
        public int _index;
        public string _street;
        public int _houseNumber;
        public int _apartmentNumber;
        public UserAdress(int index, string street, int houseNumber, int apartmentNumber)
        {
            if(street!=null)
            {
                _index = index;
                _street = street;
                _houseNumber = houseNumber;
                _apartmentNumber = apartmentNumber;
            }
            else
                throw new ArgumentNullException("Street cannot be null");
        }
    }
    [Serializable]
    public struct LoginDetails
    {
        public string Username;
        public string Password;
        public LoginDetails(string username, string password)
        {
            if (username != null && password != null)
            {
                Username = username;
                Password = password;
            }
            else
                throw new ArgumentNullException("Username and password cannot be null");
        }
        public static bool operator ==(LoginDetails l1, LoginDetails l2)
        {
            return l1.Equals(l2);
        }

        public static bool operator !=(LoginDetails l1, LoginDetails l2)
        {
            return !l1.Equals(l2);
        }
    }
    [Serializable]
    public struct Appointment
    {
        public int DayNumber;
        public int AppNumber;
        public bool isMadeAppoinment;
        public Doctor Doctor;
        public Appointment(int dayNumber, int appNumber, Doctor doctor)
        {
            if (doctor != null)
            {
                DayNumber = dayNumber;
                AppNumber = appNumber;
                isMadeAppoinment = true;
                Doctor = doctor;
            }
            else
                throw new ArgumentNullException("Doctor cannot be null");
        }
    }
    [Serializable]
    public struct MedicalHistory
    {
        public DateTime Time { get; private set; }
        public string Diagnosis { get; private set; }
        public Person Doctor { get; private set; }
        public MedicalHistory(DateTime time, string diagnosis, Person doctor)
        {
            if (diagnosis != null)
            {
                Time = time;
                Diagnosis = diagnosis;
                Doctor = doctor;
            }
            else
                throw new ArgumentNullException("Diagnosis cannot be null");
        }
    }

}
