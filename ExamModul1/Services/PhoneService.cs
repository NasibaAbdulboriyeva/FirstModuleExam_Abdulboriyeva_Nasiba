using ExamModul1.Models;
using System.Numerics;

namespace ExamModul1.Services
{
    public class PhoneService
    {
        List<Phone> phones;
        public PhoneService()
        {
            phones = new List<Phone>();
        }

        public Phone AddPhone(Phone phonenumber)
        {
            phonenumber.Id = Guid.NewGuid();
            phones.Add(phonenumber);
            return phonenumber;
        }
        public Phone GetById(Guid id)
        {
            foreach (Phone phone in phones)
            {
                if (phone.Id == id)
                {
                    return phone;
                }

            }
            return null;
        }

        public bool DeletePhone(Guid PhoneId, Phone phone)
        {
            var result = GetById(phone.Id);
            if (result is null)
            {
                return false;
            }
            phones.Remove(phone);
            return true;
        }
        public bool UpdatePhone(Guid PhoneId, Phone phone)
        {
            var result = GetById(phone.Id);
            if (result is null)
            {
                return false;
            }

            var index = phones.IndexOf(phone);
            phones[index] = phone;
            return true;


        }

        public List<Phone> GetAllPhones()
        {
            return phones;
        }


    }
}
