﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_3
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }

        List<object> cart_items = new List<object>();

        public void Add(CartItem cartItem)
        {
            cart_items.Add(cartItem);
        }

        public List<object> GetCart_items()
        {
            return cart_items;
        }

        public void Remove(int id)
        {
            CartItem deleteCart = null;
            foreach (CartItem product in cart_items)
            {
                if (product.CartId == id)
                    deleteCart = product;
            }
            if (deleteCart == null)
            {
                throw new ArgumentNullException(nameof(CartItem));
            }
            cart_items.Remove(deleteCart);
        }
        public int GetBalance()
        {
            int total = 0;
            foreach (CartItem s in cart_items)
            {
                int temp = s.Product.Price;
                total += s.Quantity * temp;
            }

            return total;
        }

        public void GetList()
        {
            foreach(CartItem cI in cart_items)
            {
                Console.WriteLine(cI);
            }
        }

    }
}
