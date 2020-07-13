using System.Collections.Generic;
using Kbdfans.Models;

namespace Kbdfans.Repository
{
    public class ExKeyboardRepo : IKbdfansRepo
    {
        public void AddKeyboard(Keyboard kbd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Keyboard> GetAllKeyboards()
        {
            var keyboards = new List<Keyboard>
            {
                new Keyboard{Id=0, Name="HappyHacking", Type="EC", Manufacturer="Fujitsu", Price=300000},
                new Keyboard{Id=1, Name="Leopold 650", Type="Chery MX Red", Manufacturer="Leopold", Price=150000},
                new Keyboard{Id=2, Name="Realforce", Type="EC", Manufacturer="Fujitsu", Price=320000}
            };
            return keyboards;
        }

        public Keyboard GetKeyboardById(int id)
        {
            return new Keyboard{Id=0, Name="HappyHacking", Type="EC", Manufacturer="Fujitsu", Price=300000};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateKeyboard(Keyboard kbd)
        {
            throw new System.NotImplementedException();
        }
    }
}