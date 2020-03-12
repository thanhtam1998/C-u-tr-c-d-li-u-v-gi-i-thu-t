/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 3/12/2020
 * Time: 3:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace quanlynhanvien
{
	/// <summary>
	/// Description of DS.
	/// </summary>
	public class DS
	{
		List<string> Items;
        int index;
        public DS()
        {
            Items = new List<string>();
            index = 0;
        }
        public void AddItem(string psItem)
        {
            Items.Add(psItem);
        }
        public int DisplayMenu()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Items is null");
                return -1;
            }
            else
            {
                ConsoleKey key;
                do
                {
                    DisplayItem();
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        index = index - 1;
                        if (index < 0)
                            index = Items.Count - 1;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        index = index + 1;
                        if (index == Items.Count)
                            index = 0;
                    }
                } while (key != ConsoleKey.Enter);
                return index;
            }
        }
        private void DisplayItem()
        {
            Console.Clear();
            for (int i = 0; i < Items.Count; i++)
            {
                if (i == index)
                {
                    Console.WriteLine("* {1}.{0} *", Items[i], i + 1);
                }
                else
                {
                    Console.WriteLine("  {1}.{0}  ", Items[i], i + 1);
                }
            }
        }
	}
}
