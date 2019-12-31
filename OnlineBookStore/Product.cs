using System;
using System.Drawing;

/**
* @file Product.cs
* @author Mehmet CELIKHAN
* @brief Product class
*/

namespace OnlineBookStore
{
    /**
    *\brief An abstract class for products
    */
    abstract class Product
    {
        /**
        *\brief Id of the product
        */
        private int id;

        /**
        *\brief Name of the product
        */
        private string name;

        /**
        *\brief Price of the product
        */
        private double price;

        /**
        *\brief Picture of the product
        */
        private Image picture;

        /**
        *\brief Constructor of Product class
        *\param id: Id of the product
        *\param name: Name of the product
        *\param price: Price of the product
        */
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Product name must be entered!");
                else
                    name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Product id must be positive!");
                else
                    id = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Price can not be negative!");
                else
                    price = value;
            }
        }

        // Picture can be null
        public Image Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }

        /**
        *\brief An abstract function to be implemented in Book, Magazine and MusicCD classes 
        */
        public abstract void PrintProperties();
    }
}