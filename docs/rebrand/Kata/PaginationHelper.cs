using System;
using System.Collections.Generic;

public class PaginationHelper<T>
{
  // TODO: Complete this class
  
  IList<T> lst;
  int itemsPerPage;
  
  /// <summary>
  /// Constructor, takes in a list of items and the number of items that fit within a single page
  /// </summary>
  /// <param name="collection">A list of items</param>
  /// <param name="itemsPerPage">The number of items that fit within a single page</param>
  public PaginationHelper(IList<T> collection, int itemsPerPage)
  {
    lst = collection;
    this.itemsPerPage = itemsPerPage;
  }

  /// <summary>
  /// The number of items within the collection
  /// </summary>
  public int ItemCount
  {
    get
    {
      return lst.Count;
    }
  }

  /// <summary>
  /// The number of pages
  /// </summary>
  public int PageCount
  {
    get
    {
      return  Convert.ToInt32(Math.Ceiling((decimal)ItemCount / itemsPerPage));
    }
  }

  /// <summary>
  /// Returns the number of items in the page at the given page index 
  /// </summary>
  /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
  /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
  public int PageItemCount(int pageIndex)
  {
    if (pageIndex < 0 || ItemCount == 0) {
      return -1;
    }
    int pgs = PageCount;
    if (pgs > 0) pgs--;
    
    if (pageIndex > pgs){
      return -1;
    }
    int m = ItemCount % itemsPerPage;
    if (m == 0) {
      m = itemsPerPage;
    }
    
    return pageIndex == pgs ? m : itemsPerPage;
  }
  
  /// <summary>
  /// Returns the page index of the page containing the item at the given item index.
  /// </summary>
  /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
  /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
  public int PageIndex(int itemIndex)
  {
    int its = ItemCount;
    if (itemIndex < 0 || its == 0) {
      return -1;
    }
    if (its > 0) its--;
    
    if (itemIndex > its){
      return -1;
    }
    return Convert.ToInt32(Math.Floor((decimal)itemIndex / itemsPerPage));
  }
}