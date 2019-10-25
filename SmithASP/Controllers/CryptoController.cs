using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmithASP.Models;
using SmithASP.ViewModels;

namespace SmithASP.Controllers
{
    public class CryptoController : Controller
    {

        private readonly CryptogramDbContext _context;

        public CryptoController(CryptogramDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            EncryptionMethodViewModel e = new EncryptionMethodViewModel();
            //Select list for dropdown
            SelectList methods = new SelectList(_context.EncryptionMethods.OrderBy(x => x.EncryptionMethodId),
                "EncryptionMethodId", "Name");
            e.MyMethods = methods;
            return View(e);
        }

        public IActionResult Select_type(String type)
        {
            EncryptionMethod e = _context.EncryptionMethods.Find(Convert.ToInt32(type));
            //opens up a view with the same name as the cipher type. i.e Caesar, Transposition
            return View(e.Name);
        }

        [HttpPost]
        public IActionResult Caesar_Output(Cryptogram cryptogram)
        {
            if (ModelState["message"].Errors.Count == 0 && ModelState["key"].Errors.Count == 0)
            {
                String symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!?. ";
                String translatedMessage = "";
                int symbolIndex;
                int key = Convert.ToInt32(cryptogram.key);

                //loop through each character in the message
                foreach (char s in cryptogram.message)
                {
                    //if the character is in the symbols proceed
                    if (symbols.Contains(s))
                    {
                        symbolIndex = symbols.IndexOf(s) + key;
                        if (symbolIndex >= symbols.Length)
                        {
                            symbolIndex = symbolIndex - symbols.Length;
                        }
                        else if (symbolIndex < 0)
                        {
                            symbolIndex = symbolIndex + symbols.Length;
                        }
                        translatedMessage += symbols[symbolIndex];
                    }
                }
                cryptogram.result = translatedMessage;
                return View("Details", cryptogram);
            }
            return View("Caesar");
        }
    }
}