﻿using System;
using System.Collections.Generic;

namespace Smart.Extensions
{
    public static class ArrayExtensions
    {
        //--------------------------------------------------------------------------------------------------------------------------

        public static void Do<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection) action(item);
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public static int IndexOf<T>(this T[] array, Func<T, bool> condition)
        {
            for (var i = 0; i < array.Length; i++)
                if (condition(array[i])) return i;
            return -1;
        }

        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
//            for (var i = 0; i < array.Length; i++)
//                if (array[i].Equals(value)) return i;
//            return -1;
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public static T[] Add<T>(this T[] array, T value)
        {
            var new_array = new T[array.Length + 1];
            for (var i = 0; i < array.Length; i++) new_array[i] = array[i];
            new_array[array.Length] = value;
            return new_array;
        }

        public static void Add<T>(ref T[] array, T value)
        {
            array = Add(array, value);
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public static T[] Remove<T>(this T[] array, int index)
        {
            var new_array = new T[array.Length - 1];
            for (var i = 0; i < index; i++) new_array[i] = array[i];
            for (var i = index; i < new_array.Length; i++) new_array[i] = array[i + 1];
            return new_array;
        }

        public static void Remove<T>(ref T[] array, int index)
        {
            array = Remove(array, index);
        }

        public static T[] Remove<T>(this T[] array, T value)
        {
            var indx = Array.IndexOf(array, value);
            return (indx < 0) ? array : Remove(array, indx);
        }

        public static void Remove<T>(ref T[] array, T value)
        {
            var indx = Array.IndexOf(array, value);
            if (indx < 0) array = Remove(array, indx);
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public static void MoveBack<T>(this T[] array, T value)
        {
            var indx = Array.IndexOf(array, value);
            if (indx > 0)
            {
                var oldValue = array[indx - 1];
                array[indx - 1] = value;
                array[indx] = oldValue;
            }
        }

        public static void MoveForw<T>(this T[] array, T value)
        {
            var indx = Array.IndexOf(array, value);
            if (indx < array.Length - 1 && indx >= 0)
            {
                var oldValue = array[indx + 1];
                array[indx + 1] = value;
                array[indx] = oldValue;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------

        public static bool CanMoveBack<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value) > 0;
        }

        public static bool CanMoveForw<T>(this T[] array, T value)
        {
            var indx = Array.IndexOf(array, value);
            return indx < array.Length - 1 && indx >= 0;
        }

        //--------------------------------------------------------------------------------------------------------------------------
    }
}