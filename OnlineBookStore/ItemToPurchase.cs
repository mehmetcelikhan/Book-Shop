using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* @file ItemToPurchase.cs
* @author Mehmet CELIKHAN
* @brief ItemToPurchase class
*/

namespace OnlineBookStore
{
    /**
    *\brief A class for the items to be purchased 
    */
    class ItemToPurchase
    {
        /**
        *\brief The product to be purchased 
        */
        private Product product;

        /**
        *\brief Quantity of the product 
        */
        private int quantity;

        /**
        *\brief Constructor function of ItemToPurchase class
        *\param product: The product to be purchased
        *\param quantity: Quantity of the product
        */
        public ItemToPurchase(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        internal Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Item quantity can not be negative!");
                else
                    quantity = value;
            }
        }
    }
}