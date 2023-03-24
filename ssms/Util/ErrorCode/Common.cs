using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Util.ErrorCode
{
	public static class Common
	{
		public static List<Entity> ErrorCodes { get; set; } = new List<Entity>()
		{
		   new Entity(100,"非常抱歉，由于系统发生错误，操作并没有完成", Status.Error),
		   new Entity(101,"非常抱歉，由于系统发生错误，修改用户信息失败", Status.Error),

		   new Entity(501,"位置不存在!", Status.Error),

		};
	}
}
