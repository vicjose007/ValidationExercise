namespace ValidationEx
{
    public class Validator
    {

        public Validator()
        {
            string name = "Victor";
            string lastname = "Matos";
            int age = 18;
        }

        public bool validateName(string name)
        {
            if (name != "Victor" && name.Length < 2 && name.Length > 64)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validateLastName(string lastname)
        {
            if (lastname != "Matos" && lastname.Length < 2 && lastname.Length > 128)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validateAge(int age)
        {
            if (age < 1 && age > 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}