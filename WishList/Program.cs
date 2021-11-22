﻿using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffee machine");
            myWishList.Add("socks");
            myWishList.Add("chocolate");
            myWishList.Add("pillow");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
