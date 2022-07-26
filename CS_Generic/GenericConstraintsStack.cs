﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Generic
{
    /// <summary>
    /// Lets apply COnstraints
    /// T will be either staff or derived types of Staff
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConstraintsStack<T> where T : Staff
    {
        int top = 0;

        // define a generic Member
        T[] arr = new T[5];
        //Generic Method
        public void Push(T Item)
        {
            arr[top++] = Item;
        }
        public T Pop()
        {
            return arr[--top];
        }

        public T[] GetMembers()
        {
            return arr;
        }
    }
}
