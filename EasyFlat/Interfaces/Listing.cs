using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EasyFlat.Classes;
namespace EasyFlat.Interfaces
{
    public interface IListing // метод для роботи з оголошеннями
    {
        void AddReview(Listing listing);  
    }
}