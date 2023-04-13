using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj2HomeWorkLibrarySystem
{
    // Represents a collection of book copies, each with a unique ID
    public class BookCopy
    {
        // A list of unique copy IDs for each book copy
        public List<int> CopyID { get; set; } = new List<int>();


        // The total number of book copies
        public int TotalCopyAmount { get; set; }

        // Creates a new instance of the BookCopy class with the specified total number of copies
        public BookCopy(int totalCopyAmount)
        {
            // Sets the total number of copies
            TotalCopyAmount = totalCopyAmount;

            // Populates the CopyID list with unique IDs for each book copy
            CopyID = new List<int>();
            for (int index = 1; index <= totalCopyAmount; index++)
            {
                CopyID.Add(index);
            }
        }
    }
}


/* 
 
Diagram
*********
+---------------------+             
            |    BookCopy object   |             
            +---------------------+             
            | - CopyID : List<int> |             
            | - TotalCopyAmount : int |             
            +---------------------+             
                     /\                        
                     ||                         
          Constructor ||                         
                     ||                         
                     \/                         
            +-----------------------+             
            |     For loop (index)   |             
            +-----------------------+             
            | - index : int          |             
            +-----------------------+             
                     /\                        
                     ||                         
        Adds index to CopyID list                
                     ||                         
                     \/                         
            +----------------------+             
            |   Creates new BookCopy |             
            +----------------------+             


The diagram represents the BookCopy class in the Obj2HomeWorkLibrarySystem namespace.

The class has two properties:

CopyID, which is a list of integers representing unique copy IDs for each book copy.
TotalCopyAmount, which is an integer representing the total number of book copies.
The class has one constructor that takes in an integer parameter totalCopyAmount to initialize the TotalCopyAmount property.

The constructor initializes the TotalCopyAmount property with the value of the totalCopyAmount parameter.

It also initializes the CopyID property with a new instance of a list of integers.

The for loop then iterates from 1 to totalCopyAmount, and for each iteration, adds the current integer to the CopyID list using the Add() method. This populates the CopyID property with a list of unique copy IDs for each book copy.

The diagram helps to visualize the relationship between the properties, constructor, and the for loop in the BookCopy class.

 
class BookCopy
{
    // Properties
    List<int> CopyID
    int TotalCopyAmount

    // Constructor
    BookCopy(int totalCopyAmount)
    {
        TotalCopyAmount = totalCopyAmount

        CopyID = new List<int>()
        for index from 1 to totalCopyAmount
        {
            CopyID.Add(index)
        }
    }
}

 
 */

