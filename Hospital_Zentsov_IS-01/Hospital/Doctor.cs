using System;
using System.Linq;

namespace Hospital
{
    [Serializable]
    public class Doctor : User
    {
        private RegisteredUser[,] _regidteredUsersTable;
        private int[] _workDays;
        public Doctor(Person person, DateTime birthDate, UserAdress adress,LoginDetails loginDetails, int[] workDays)
        {
            if (workDays != null)
            {
                _person = person;
                _birthDate = birthDate;
                _adress = adress;
                _loginDetails = loginDetails;
                Array.Sort(workDays);
                _workDays = workDays;
                for (int i = 0; i < _workDays.Length; i++)
                {
                    _workDays[i]--;
                }
                for (int i = 0; i < workDays.Length; i++)
                {
                    if (workDays[i] >= 0 && workDays[i] <= 6)
                    {
                        _regidteredUsersTable = new RegisteredUser[5, 12];
                    }
                    else
                    {
                        throw new ArgumentException("working days must be between 0 and 6");
                    }
                }
            }
            else
                throw new ArgumentException("Work day can not be null");
           
        }
        public void MakeAppointment(int day, int appointmentNumber, RegisteredUser registeredUser)
        {
            if (_workDays.Contains(day)==false)
                throw new ArgumentOutOfRangeException("There is no such day number");
            else if(registeredUser==null)
                throw new ArgumentNullException("Registered user cannot be null");
            else if (appointmentNumber >= 0 && appointmentNumber < 12)
            {
                _regidteredUsersTable[day, appointmentNumber] = registeredUser;
            }
            else
            {
                throw new ArgumentOutOfRangeException("There is no such appointment number");
            }
        }
        public void DeleteAppointment(RegisteredUser registeredUser)
        {
            if(registeredUser!=null)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (_regidteredUsersTable[i, j] != null && _regidteredUsersTable[i, j].Person == registeredUser.Person)
                        {
                            _regidteredUsersTable[i, j] = null;
                        }
                    }
                }
            }
            else
                throw new ArgumentNullException("Registered user cannot be null");

        }
        public RegisteredUser[,] GetUsersSchedule { get { return _regidteredUsersTable; } }
        public bool[,] GetAnonimSchedule
        {
            get
            {
                bool[,] anonimSchedule = new bool[5, 12];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        if (_regidteredUsersTable[i, j] != null)
                            anonimSchedule[i, j] = true;
                        else
                            anonimSchedule[i, j] = false;
                    }
                }
                return anonimSchedule;
            }
        } 
        public int[] WorkDays {get { return _workDays; } }

    }
}
