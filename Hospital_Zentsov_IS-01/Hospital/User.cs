using System;

namespace Hospital
{
    [Serializable]
    public abstract class User:IUser
    {
        protected Person _person;
        protected UserAdress _adress;
        protected DateTime _birthDate;
        protected LoginDetails _loginDetails;
        public virtual Person Person { get { return _person; } }
        public virtual UserAdress Adress { get { return _adress; } }
        public virtual DateTime BirthDate { get { return _birthDate; } }
        public virtual LoginDetails LoginDetails { get { return _loginDetails; } }
    }
}
