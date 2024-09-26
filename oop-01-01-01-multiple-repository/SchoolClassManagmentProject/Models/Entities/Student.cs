using SchoolClassManagmentProject.Models.AppException;

namespace SchoolClassManagmentProject.Models.Entities
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        private bool _gender;
        private string _email;
        private string _phone;

        // Legyen üres konstuktor
        public Student()
        {
            
        }

        // Legyen összes konsturkor
        public Student(string firstName, string lastName, DateTime birthdate, bool gender, string phonenumber, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthdate;
            _gender = gender;
            _phone = phonenumber;
            _email = email;
        }

        // Lehessen könnyedén email és telefon számot változtatni, a többit csak nehezen (módosításkor az új email cím nem egyezhet meg a régi emailcimmel)
        public string FirstName { get => _firstName; private set => _firstName = value; }
        public string LastName { get => _lastName; private set => _lastName = value; }
        public DateTime BirthDate { get => _birthDate; private set => _birthDate = value; }
        public bool Gender { get => _gender; private set => _gender = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public void SetEmail(string newemail)
        {
            if (newemail != _email) 
                _email = newemail;
        }

        public void SetPhonenumber(string newphonenumber)
        {
            if (newphonenumber != _phone)
                _phone = newphonenumber;
        }

        // Legyen a diák angol és magyar teljes neve
        public string HungarianName => $"{_lastName} {_firstName}";
        public string EnglishName => $"{_firstName} {_lastName}";


        // Meg lehessen tudni a diák életkorát
        public int GetAge(Student student)
        {
            return DateTime.Now.Year-student.BirthDate.Year;
        }

        // Lekérdezhető legyen hogy van-e email címe a diáknak
        public bool HasEmailAddress(Student student)
        {
            if(student.Email != null)
                return true;
            else
                return false;
                
        }

        // Lekérdezhető legyen hogy van-e telefon száma a diáknak
        public bool HasPhonenumber(Student student)
        {
            if (student.Phone != null)
                return true;
            else
                return false;

        }

    }
}
