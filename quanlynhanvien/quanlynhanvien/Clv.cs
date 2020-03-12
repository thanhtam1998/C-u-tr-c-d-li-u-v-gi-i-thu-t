/*
 * Created by SharpDevelop.
 * User: tamng
 * Date: 3/12/2020
 * Time: 3:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
namespace quanlynhanvien
{
public class Clv
	{
		private string name;
		private int day, month, year;
		public Clv()
		{
			
		}
		public Clv(string name, int day, int month, int year){
			this.name = name;
			this.day = day;
			this.month = month;
			this.year = year;
		}
		
		public Clv(Clv employee){
			name = employee.Name;
			day = employee.Day;
			month = employee.Month;
			year = employee.Year;
		}
		
		public void InputInfor(){
			Console.WriteLine("Employee's name: ");
			name = Console.ReadLine();
			Console.WriteLine("Input day of the birth:");
			day = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Input day of the month:");
			month = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Input day of the year:");
			year = Int32.Parse(Console.ReadLine());
		}
		
		
		public string Name{
			get{
				return name;
			}
			set{
				name = value;
			}
		}
		public int Day{
			get{
				return day;
			}
			set{
				day = value;
			}
		}
		public int Month{
			get{
				return month;
			}
			set{
				month = value;
			}
		}
		public int Year{
			get{
				return year;
			}
			set{
				year = value;
			}
		}
	}
}
