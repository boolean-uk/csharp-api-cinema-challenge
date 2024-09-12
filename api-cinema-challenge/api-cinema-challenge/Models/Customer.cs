using System.Text.RegularExpressions;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        private readonly int _id;
        private string _name;
        private string _email;
        private string _phone;
        private readonly DateTime _created;
        private DateTime _updated;

        internal Customer(string name, string email, string phone)
        {
            //Added only one check to demonstarate
            if (!Validation.IsValidEmail(email))
            {
                    throw new ArgumentException("Email not valid");
            }
            Random rnd = new Random();
            this._id = rnd.Next(100000, 999999);
            this._name = name;
            this._email = email;
            this._phone = phone;
            _created = DateTime.Now;
        }


        internal int Id { get { return _id; } }
        internal string Name { get { return _name; } set { this._name = Name; this._updated = DateTime.Now; } }
        internal string Email { get { return _email; } set { this._email = Email; this._updated = DateTime.Now; } }
        internal string Phone { get { return _phone; } set { this._phone = Phone; this._updated = DateTime.Now; } }

        internal DateTime Created { get { return _created; } }
        internal DateTime Updated { get { return _updated; } }



    }
}
