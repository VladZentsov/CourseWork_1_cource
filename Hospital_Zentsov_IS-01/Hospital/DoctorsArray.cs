using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    [Serializable]
    public class DoctorsArray
    {
        private List<Doctor> _doctors;
        private int _numberOfDoctors;
        public DoctorsArray()
        {
            _doctors = new List<Doctor>();
            _numberOfDoctors = 0;
        }
        public DoctorsArray(Doctor[] doctors)
        {
            if(doctors!=null)
            {
                _doctors = new List<Doctor>(doctors);
                _numberOfDoctors = doctors.Length;
            }
            else
            {
                _doctors = new List<Doctor>();
                _numberOfDoctors = 0;
            }
        }
        public Doctor SearchDoctor(string name, string surname)
        {
            if(name==null||surname==null)
                throw new ArgumentNullException("Name or surname cannot be null");
            else
            {
                for (int i = 0; i < _numberOfDoctors; i++)
                {
                    if (_doctors[i].Person.Name == name && _doctors[i].Person.Surname == surname)
                    {
                        return _doctors[i];
                    }
                }
                return null;
            }
        }
        public int NumberOfDoctors{get{return _numberOfDoctors;}}
        public void AddDoctor(Doctor newDoctor)
        {
            if(newDoctor!=null)
                _doctors.Add(newDoctor);
            else
                throw new ArgumentNullException("Doctor cannot be null");
        }
        public void DeleteDoctor(Doctor deleteDoctor)
        {
            if(deleteDoctor!=null)
            {
                if (_doctors.Contains(deleteDoctor))
                    _doctors.Remove(deleteDoctor);
            }
            else
                throw new ArgumentNullException("Doctor cannot be null");
        }
        public Doctor this[int index]
        {
            get
            {
                if ((index >= 0) && (index < _numberOfDoctors))
                {
                    return _doctors.ElementAt(index);
                }
                else
                {
                    throw new IndexOutOfRangeException("Index outside the array");
                }

            }
        }
        public Doctor SearchDoctorByLogDetails(string username, string password)
        {
            if(username==null||password==null)
                throw new ArgumentNullException("Username or password cannot be null");
            else
            {
                for (int i = 0; i < _numberOfDoctors; i++)
                {
                    if (_doctors[i].LoginDetails == new LoginDetails(username, password))
                    {
                        return _doctors[i];
                    }
                }
                return null;
            }
        }
        public int IndexOf(Person person)
        {
            for (int i = 0; i < _numberOfDoctors; i++)
            {
                if (_doctors[i].Person == person)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
