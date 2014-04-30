using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
namespace VectorLandMesh.Data
{
    class ListHandler<Type>
    {
        /// <summary>
        /// Get an object from an List based on an index. If the index is out of bounds the last index in the array will be  returned.
        /// </summary>
        /// <param name="list">The list object to be checked</param>
        /// <param name="index">The index that is to be checked</param>
        static public Type getFromTrimedIndex(List<Type> list,int index)
        {
            //if the index is within the List return that ellement, else return the last index in the array
            return ((index >= list.Count-1) ? list[list.Count - 1] : list[index]);
        }
        /// <summary>
        /// Get an object from an List based on an index. If the index is out of bounds the last index in the array will be returned.
        /// </summary>
        /// <param name="list">The list object to be checked</param>
        /// <param name="index">The index that is to be checked</param>
        internal static Type getNullIfOutOfRange(List<Type> list, int index)
        {
            //  The object to be retuned set to type default if the object cant be set a null
            Type returnObject = default(Type);
            
            //if the list is not equal to null and and is less then number of object in the list set the "Return Object" to it.
            if (list != null & list.Count !=0 & list.Count > index)
                returnObject = list[index];

            //return the object
            return returnObject;
        }
    }
}
