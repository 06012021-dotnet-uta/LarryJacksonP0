using System;
namespace RockPaperScissors
{
    public class UserName 
    {
        private string _fname;
        public string Fname
        { /* get and set the value for the fname field */
            get {return _fname;}
            set {
                if (value.Length > 20 || value.Length < 1) /* Check for the valid name */
                {
                    throw new InvalidOperationException("that fname is invalid");
                }
                _fname = value;
            }
        }

        /* this override constructor will be called with you instantiate the class 
        instance and provide the fname at the same time. */
         public UserName(string fname)
        {
            this.Fname = fname;
        }

    }
}