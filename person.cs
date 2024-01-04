public class Person
{
    private string _familyName;
    private string _firstName;
    private DateTime _birthday;

    public string FamilyName {
        set {
    
                _familyName = value;
        }

        get {
            if (_familyName == null)
            {
                throw new ArgumentException("Incorrect data for FamilyName");

            }

            if (_familyName.Trim().Length < 2)
            {
                throw new ArgumentException("Incorrect data for FamilyName");

            }

            if (_familyName.Trim("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrsśtuvwxyz ".ToCharArray()).Length  > 1)
            {
                throw new ArgumentException("Incorrect data for FamilyName");

            }


            if (_familyName.Contains("."))
            {
                throw new ArgumentException("Incorrect data for FamilyName");

            } 

            if (_familyName == "")
            {
                throw new ArgumentException("Incorrect data for FamilyName");
            }
            else
            {
                return _familyName.Trim() ;
            }


        }

    }
    public string FirstName {

        set { _firstName = value; }

        get
        {

            if (_firstName.Contains("."))
            {

                throw new ArgumentException("Incorrect data for FirstName");

            }

            if (_firstName == null)
            {
                throw new ArgumentException("Incorrect data for FirstName");

            }

            if (_firstName.Length < 2)
            {
                throw new ArgumentException("Incorrect data for FirstName");

            }

            if(_firstName.Trim().Length < 2)
            {

                throw new ArgumentException("Incorrect data for FirstName");
            }

            else
            {

                return _firstName.Trim();
            }

            


        }

    }
        
    public DateTime Birthday
    {

        set { _birthday = value; }

        get
        {

            if(DateTime.Now < _birthday)
            {
                throw new ArgumentException("Incorrect data for Birthday");

            }
            else
            {

                return _birthday;
            }


        }


    } 

    public Person(string familyName, string firstName, DateTime birthday)
    {
        this.FamilyName = familyName;
        this.FirstName= firstName;
        this.Birthday = birthday;
    }



    public override string ToString()
    {
            return FirstName +" "+ FamilyName +" "+ $"({Birthday.ToString("yyyy-MM-dd")})";
    }

    

}
