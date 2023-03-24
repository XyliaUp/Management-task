using System;
using System.Collections.Generic;
using System.Linq;
namespace TMS.DAT
{
	public static class DataAccess
	{
		#region Barcode
		public static LTS.Barcode GetBarcodeItemByID(int? BarcodeID)
		{
			LTS.Barcode barcode = new LTS.Barcode();
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					barcode = access.Barcode.Where(o => o.BarcodeID == BarcodeID).FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
			}
			return barcode;
		}
		public static List<LTS.Barcode> GetBarcode()
		{
			List<LTS.Barcode> barcode = new List<LTS.Barcode>();
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					barcode = access.Barcode.ToList();
				}
			}
			catch (Exception ex)
			{
			}
			return barcode;
		}


		public static long AddBarcode(LTS.Barcode barcode)
		{
			long? BarcodeID = -1;

			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.InsertBarcode(barcode.BarcodeNumber, ref BarcodeID);
				}
			}
			catch (Exception ex)
			{
			}

			return (long)BarcodeID;
		}



		public static bool RemoveBarcode(int BarcodeID)
		{
			bool deleted = false;
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.DeleteBarcode(BarcodeID);
					deleted = true;
				}
			}
			catch (Exception ex)
			{
			}
			return deleted;
		}
		public static bool UpdateBarcode(LTS.Barcode barcode)
		{
			bool completed = false;
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.UpdateBarcode(barcode.BarcodeNumber, barcode.BarcodeID);
					completed = true;
				}

			}
			catch (Exception ex)
			{
				completed = false;
			}
			return completed;
		}
		#endregion;

		#region Item
		public static LTS.Item GetItemItemByID(int? ItemID)
		{
			LTS.Item item = new LTS.Item();
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					item = access.Item.Where(o => o.ItemID == ItemID).FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
			}
			return item;
		}
		public static List<LTS.Item> GetItem()
		{
			List<LTS.Item> item = new List<LTS.Item>();
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					item = access.Item.ToList();
				}
			}
			catch (Exception ex)
			{
			}
			return item;
		}

		public static bool RemoveItem(int ItemID)
		{
			bool deleted = false;
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.DeleteItem(ItemID);
					deleted = true;
				}
			}
			catch (Exception ex)
			{
			}
			return deleted;
		}

		#endregion;


		#region User
		public static LTS.User GetUserItemByID(int? UserID)
		{
			LTS.User user = new LTS.User();
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					user = access.User.Where(o => o.UserID == UserID).FirstOrDefault();
				}
			}
			catch (Exception ex)
			{
			}
			return user;
		}



		public static List<LTS.User> GetUser()
		{
			List<LTS.User> user = new List<LTS.User>();
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					user = access.User.ToList();
				}
			}
			catch (Exception ex)
			{
			}
			return user;
		}

		public static long AddUser(LTS.User user)
		{
			long? UserID = -1;

			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.InsertUser(
						user.UserName,
						user.UserEmail,
						user.UserPassword,

						user.UserAdmin,
						user.UserActivated,

						ref UserID);
				}
			}
			catch (Exception ex)
			{
			}

			return UserID.Value;
		}

		public static bool RemoveUser(int UserID)
		{
			bool deleted = false;
			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.DeleteUser(UserID);
					deleted = true;
				}
			}
			catch (Exception ex)
			{
			}
			return deleted;
		}



		public static bool UpdateUser(LTS.User user)
		{
			try
			{
				using (TMS.LTS.LTSBase access = new LTS.LTSDC())
				{
					access.UpdateUser(
						user.UserName,
						user.UserEmail,
						user.UserPassword,
						user.UserAdmin,
						user.UserActivated,
						user.UserID);
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return false;
		}
		#endregion;




		#region Vehicle
		/// <summary>
		/// 获得车辆数据
		/// </summary>
		/// <returns></returns>
		public static List<LTS.Vehicle> GetVehicle()
		{
			try
			{
				using (LTS.LTSDC access = new LTS.LTSDC())
				{
					return access.Vehicle.ToList();
				}
			}
			catch { }

			return new List<LTS.Vehicle>();
		}


		/// <summary>
		/// 增加车辆
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public static long AddVehicle(LTS.Vehicle Vehicle)
		{
			long? NewId = -1;

			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.InsertVehicle(Vehicle.Platenum, Vehicle.Status, Vehicle.Type, Vehicle.Capacity, Vehicle.Name, Vehicle.Driver, Vehicle.Address, Vehicle.Register, ref NewId);
				}
			}
			catch (Exception ex)
			{

			}

			return NewId.Value;
		}


		public static bool UpdateVehicle(LTS.Vehicle Vehicle)
		{
			try
			{
				using (TMS.LTS.LTSBase access = new LTS.LTSDC())
				{
					access.UpdateVehicle(Vehicle.Platenum, Vehicle.Status, Vehicle.Type, Vehicle.Capacity, Vehicle.Name, Vehicle.Driver, Vehicle.Address, Vehicle.Register, Vehicle.VehicleID);
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return false;
		}
		#endregion


		#region Driver
		/// <summary>
		/// 获得司机数据
		/// </summary>
		/// <returns></returns>
		public static List<LTS.Driver> GetDriver()
		{
			try
			{
				using (LTS.LTSDC access = new LTS.LTSDC())
				{
					return access.Driver.ToList();
				}
			}
			catch { }

			return new List<LTS.Driver>();
		}


		/// <summary>
		/// 增加车辆
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public static long AddDriver(LTS.Driver Driver)
		{
			long? NewId = -1;

			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.InsertDriver(Driver.Name, Driver.DriverNum, Driver.License, Driver.Sex, Driver.Register, ref NewId);
				}
			}
			catch (Exception ex)
			{

			}

			return NewId.Value;
		}


		public static bool UpdateDriver(LTS.Driver Driver)
		{
			try
			{
				using (TMS.LTS.LTSBase access = new LTS.LTSDC())
				{
					access.UpdateDriver(Driver.Name, Driver.DriverNum, Driver.License, Driver.Sex, Driver.Register, Driver.DriverID);
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return false;
		}
		#endregion


		#region Custom
		/// <summary>
		/// 获得客户数据
		/// </summary>
		/// <returns></returns>
		public static List<LTS.Custom> GetCustom()
		{
			try
			{
				using (LTS.LTSDC access = new LTS.LTSDC())
				{
					return access.Custom.ToList();
				}
			}
			catch { }

			return new List<LTS.Custom>();
		}


		/// <summary>
		/// 增加用户
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public static long AddCustom(LTS.Custom Custom)
		{
			long? NewId = -1;

			try
			{
				using (LTS.LTSBase access = new LTS.LTSDC())
				{
					access.InsertCustom(Custom.Register, Custom.Name, Custom.Phone, Custom.Password, ref NewId);
				}
			}
			catch (Exception ex)
			{

			}

			return NewId.Value;
		}


		public static bool UpdateCustom(LTS.Custom Custom)
		{
			try
			{
				using (TMS.LTS.LTSBase access = new LTS.LTSDC())
				{
					access.UpdateCustom(Custom.Register, Custom.Name, Custom.Phone, Custom.Password, Custom.CustomID);
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return false;
		}
		#endregion




		#region VehicleSchedule
		/// <summary>
		/// 获得车辆数据
		/// </summary>
		/// <returns></returns>
		public static List<LTS.VehicleSchedule> GetVehicleSchedule()
		{
			try
			{
				using (LTS.LTSDC access = new LTS.LTSDC())
				{
					return access.VehicleSchedule.ToList();
				}
			}
			catch { }

			return new List<LTS.VehicleSchedule>();
		}


		/// <summary>
		/// 增加车辆
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public static long AddVehicleSchedule(LTS.VehicleSchedule VehicleSchedule)
		{
			long? NewId = -1;

			using (LTS.LTSBase access = new LTS.LTSDC())
			{
				access.InsertVehicleSchedule(VehicleSchedule.ScheduleID, VehicleSchedule.StartTime, VehicleSchedule.EndTime, VehicleSchedule.Vehicle, VehicleSchedule.Driver, VehicleSchedule.User, ref NewId);
			}

			return NewId.Value;
		}


		public static bool UpdateVehicleSchedule(LTS.VehicleSchedule VehicleSchedule)
		{
			try
			{
				using (TMS.LTS.LTSBase access = new LTS.LTSDC())
				{
					access.UpdateVehicleSchedule(VehicleSchedule.ScheduleID, VehicleSchedule.StartTime, VehicleSchedule.EndTime, VehicleSchedule.Vehicle, VehicleSchedule.Driver, VehicleSchedule.User);
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			return false;
		}
		#endregion
	}
}
