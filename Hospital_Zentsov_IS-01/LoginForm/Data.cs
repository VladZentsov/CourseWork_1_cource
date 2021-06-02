using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LoginForm
{
    class Data
    {
        public static void UpdateRegUsers(RegisteredUserArray registeredUserArray)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("UsersData.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, registeredUserArray);
            }
        }
        public static void UpdateDoctors(DoctorsArray doctorsArray)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("DoctorsData.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, doctorsArray);
            }
        }
        public static RegisteredUserArray GetRegUsers()
        {
            RegisteredUserArray registeredUserArray;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("UsersData.dat", FileMode.OpenOrCreate))
            {
                registeredUserArray = (RegisteredUserArray)formatter.Deserialize(fs);
            }
            return registeredUserArray;
        }
        public static DoctorsArray GetDoctors()
        {

            DoctorsArray doctorsArray;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("DoctorsData.dat", FileMode.OpenOrCreate))
            {
                doctorsArray = (DoctorsArray)formatter.Deserialize(fs);
            }
            return doctorsArray;
        }
    }
}
