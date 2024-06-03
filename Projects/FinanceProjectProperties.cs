using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp2.Projects
{
    public class FinanceProjectProperties : BasicProperties
    {

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public FinanceProjectProperties(string name, string description, float price, string author)
        {
            Name = name;
            Description = description;
            Price = price;
            Author = author;
        }

    }
}
