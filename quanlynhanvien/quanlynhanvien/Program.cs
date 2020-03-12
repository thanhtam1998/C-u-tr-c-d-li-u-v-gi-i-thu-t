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
			menu.AddItem("Nhap danh sach nhan vien");
			menu.AddItem("Xoa danh sach nhan vien");
			menu.AddItem("Sua danh sachnhan vien");
			menu.AddItem("Danh sach nhan vien");
			menu.AddItem("Cancle");
			do{
				iLuaChon = menu.DisplayDS();
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
					iDelete = DSEmpl.DisplayDS();
					Console.WriteLine("Xoa danh sach nhan vien: {0}(Co: 1| khong: 0)",ListEmployee[iDelete]);
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
					iEdit = DSEmpl.DisplayDS();
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