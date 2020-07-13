using System.Collections.Generic;
using Kbdfans.Models;

namespace Kbdfans.Repository
{
    public interface IKbdfansRepo
    {
        bool SaveChanges();
        IEnumerable<Keyboard> GetAllKeyboards();
        Keyboard GetKeyboardById(int id);
        void AddKeyboard(Keyboard kbd);
        void UpdateKeyboard(Keyboard kbd);
    }
}