/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 3/12/2020
 * Time: 3:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace quanlynhanvien
{
	class Program
	{
		public static void Main(string[] args)
		{
			DS menu = new DS();
			List<Clv> ListEmployee = new List<Clv>();
			int iLuaChon;
			menu.AddItem("Input Employee");//0
			menu.AddItem("Delete Employee");//1
			menu.AddItem("Edit Employee");//2
			menu.AddItem("Watch List Employee");//3
			menu.AddItem("Cancle");//4
			do{
				iLuaChon = menu.DisplayMenu();
				if(iLuaChon == 0){
					Clv employee = new Clv ();
					employee.InputInfor();
					ListEmployee.Add(employee);
				}

				if(iLuaChon == 1){
					DS DSEmpl = new DS();
					foreach(Clv  empl in ListEmployee){
						DSEmpl.AddItem(empl.Name);
					}
					int iDelete = 0;
					iDelete = DSEmpl.DisplayMenu();
					Console.WriteLine("Delete Employee: {0}(Yes: 1| No: 0)",ListEmployee[iDelete]);
					int check = Int32.Parse(Console.ReadLine());
					if(check == 1){
						ListEmployee.Remove(ListEmployee[iDelete]);
					}
				}
				if(iLuaChon == 2){
					DS DSEmpl = new DS();
					foreach(Clv empl in ListEmployee){
						DSEmpl.AddItem(empl.Name);
					}
					int iEdit = 0;
					iEdit = DSEmpl.DisplayMenu();
					Clv employee = new Clv ();
					employee.InputInfor();
					ListEmployee[iEdit] = employee;
				}
				if(iLuaChon == 3){
					Console.WriteLine("{0,-10}|{1,-15}|{2,-15}|{3,-15}|{4,-15}","Number","Name","Day","Month","Year");
					if(ListEmployee.Count < 1){
						Console.WriteLine("List Employee is null");
					}
					else{
						for(int i = 0; i < ListEmployee.Count; i++){
							Clv  employee = ListEmployee[i];
							Console.WriteLine("{0,-10}|{1,-15}|{2,-15}|{3,-15}|{4,-15}",i,employee.Name,employee.Day,employee.Month,employee.Year);
						}	
					}
					Console.ReadKey(true);
				}
			}
			while(iLuaChon != 4);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}