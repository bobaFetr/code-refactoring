using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalDetails.Models
{
    
    public class AnimalDetails
    {
        public int id;
        public string Names = string.Empty;
        public string Owner = string.Empty;
        public int Age;
        public string Type = string.Empty;
        public bool SickOrNot = false;
        public string Notes = "";

        public AnimalDetails(int id, string names, string owner, int age, string type, bool sickOrNot, string notes)
        {
            this.id = id;
            this.Names = names;
            this.Owner = owner;
            this.Age = age;
            this.Type = type;
            this.SickOrNot = sickOrNot;
            this.Notes = notes;
        }    
    }

    
}