using System;
using System.Collections.Generic;
using System.Linq;
using Kbdfans.Models;

namespace Kbdfans.Repository
{
    public class PsqlKbdfansRepo : IKbdfansRepo
    {
        private readonly KbdfansContext _context;

        //PsqlKbdfansRepo Constructor with DbContext
        public PsqlKbdfansRepo(KbdfansContext context)
        {
            _context = context;
        }

        public void AddKeyboard(Keyboard kbd)
        {
            if (kbd == null)
            {
                throw new ArgumentNullException(nameof(kbd));
            }

            _context.Keyboards.Add(kbd);
        }

        public IEnumerable<Keyboard> GetAllKeyboards()
        {
            return _context.Keyboards.ToList();
        }

        public Keyboard GetKeyboardById(int id)
        {
            return _context.Keyboards.FirstOrDefault(keyboard => keyboard.Id == id);
        }

        public bool SaveChanges()
        {
            bool result = (_context.SaveChanges() >= 0);
            return result;
        }

        public void UpdateKeyboard(Keyboard kbd)
        {
            // Doesn't do anything here
            
        }
    }
}