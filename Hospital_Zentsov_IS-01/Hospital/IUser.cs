using System;

namespace Hospital
{
    interface IUser
    {
        Person Person { get; }
        UserAdress Adress { get; }
        DateTime BirthDate { get; }
        LoginDetails LoginDetails { get; }
    }
}
