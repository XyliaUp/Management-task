
using System.Collections.Generic;

using suc.calc.distance;

namespace TMS.MapView
{
	public class MapHelper
	{
		/// <summary>
		/// 获得经纬度信息
		/// </summary>
		/// <param name="Address"></param>
		/// <returns></returns>
		public static Geocoder GeoCoder(string Address) => JsonHelper.JsonDeserialize<Geocoder>(BaiduMap.Geocoder(Address));

		/// <summary>
		/// 获得路线
		/// </summary>
		/// <param name="Address"></param>
		/// <returns></returns>
		public static SiteDistance Route(string Address1, string Address2)
		{
			BaiduMap.apiKey = "CjcduvmMuUO1Ow2oaj0G2mOGtcq8G79O";

			Geocoder geocoder1 = JsonHelper.JsonDeserialize<Geocoder>(BaiduMap.Geocoder(Address1));
			Geocoder geocoder2 = JsonHelper.JsonDeserialize<Geocoder>(BaiduMap.Geocoder(Address2));


			SiteDistance item = new SiteDistance();
			item.startCode = null;
			item.startName = null;
			item.startAddress = Address1;
			item.startlat = geocoder1.result.location.lat;
			item.startlng = geocoder1.result.location.lng;
			item.endCode = null;
			item.endName = null;
			item.endAddress = Address2;
			item.endlat = geocoder2.result.location.lat;
			item.endlng = geocoder2.result.location.lng;


	
			Geocoder result = JsonHelper.JsonDeserialize<Geocoder>(BaiduMap.Driving(item.startlat.ToString() + "," + item.startlng.ToString(), item.endlat.ToString() + "," + item.endlng.ToString()));
			if (result != null && result.result != null && result.result.routes != null && result.result.routes.Count > 0)
			{
				item.distance = result.result.routes[0].distance;
				item.runTime = result.result.routes[0].duration / 60;
				item.steps = GetSteps(result.result.routes[0].steps);
			}
			else throw new System.Exception();


			return item;
		}


		private static string GetSteps(List<Step> lstStep)
		{
			string s = string.Empty;
			foreach (var item in lstStep)
			{
				s += item.road_name + "->";
			}
			return s;
		}
	}
}