using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    [Serializable]  
    public class RegisteredUserArray
    {
        private List<RegisteredUser> _registeredUsers;
        private int _numberOfUsers;
        public RegisteredUserArray()
        {
            _registeredUsers = new List<RegisteredUser>();
            _numberOfUsers = 0;
        }
        public RegisteredUserArray(RegisteredUser[] registeredUsers)
        {
            if(registeredUsers!=null)
            {
                _registeredUsers = new List<RegisteredUser>(registeredUsers);
                _numberOfUsers = registeredUsers.Length;
            }
            else
            {
                _registeredUsers = new List<RegisteredUser>();
                _numberOfUsers = 0;
            }
        }
        public void AddUser(RegisteredUser newUser)
        {
            if (newUser != null)
            {
                _registeredUsers.Add(newUser);
                _numberOfUsers++;
            }
            else
                throw new ArgumentNullException("Registered user cannot be null");
        }
        public RegisteredUser SearchUser(string username, string password)
        {
            if(username!=null&&password!=null)
            {
                for (int i = 0; i < _numberOfUsers; i++)
                {
                    if (_registeredUsers[i].LoginDetails == new LoginDetails(username, password))
                    {
                        return _registeredUsers[i];
                    }
                }
                return null;
            }
            else
                throw new ArgumentNullException("Username or password cannot be null");
        }
        public RegisteredUser SearchUser(Person person)
        {
            for (int i = 0; i < _numberOfUsers; i++)
            {
                if (_registeredUsers[i].Person ==person)
                {
                    return _registeredUsers[i];
                }
            }
            return null;
        }
        public RegisteredUser SearchByName(string name,string surname)
        {
            if (name != null && surname != null)
            {
                for (int i = 0; i < _numberOfUsers; i++)
                {
                    if (_registeredUsers[i].Person.Name == name && _registeredUsers[i].Person.Surname == surname)
                    {
                        return _registeredUsers[i];
                    }
                }
                return null;
            }
            else
                throw new ArgumentNullException("Name or surname cannot be null");
        }
        public int IndexOf(Person person)
        {
            for (int i = 0; i < _numberOfUsers; i++)
            {
                if(_registeredUsers[i].Person==person)
                {
                    return i;
                }
            }
            return -1;
        }
        public int NumberOfUsers
        {
            get
            {
                return _numberOfUsers;
            }
        }
        public RegisteredUser this[int index]
        {
            get
            {
                if ((index >= 0) && (index < _numberOfUsers))
                {
                    return _registeredUsers.ElementAt(index);
                }
                else
                {
                    throw new IndexOutOfRangeException("Index outside the array");
                }

            }
        }
        public void DeleteRegisteredUser(RegisteredUser deleteuser)
        {
            if (deleteuser == null)
                throw new ArgumentNullException("Registered user cannot be null");
            else
            {
                int userIndex = IndexOf(deleteuser.Person);
                if(userIndex!=-1)
                {
                    _numberOfUsers--;
                    _registeredUsers.RemoveAt(userIndex);
                }
            }

        }
    }
}
