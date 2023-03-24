using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Util.ErrorCode
{
	/// <summary>
	/// 错误码实例
	/// </summary>
	public class Entity
	{
		public Entity(int Code, string Info, Status Status = Status.NoDefine)
		{
			this.Code = Code;
			this.Info = Info;
			this.Status = Status;
		}


		public int Code { get; set; }

		public string Info { get; set; }

		public Status Status { get; set; }
	}


	/// <summary>
	/// 状态类型
	/// </summary>
	public enum Status
	{
		NoDefine,
		Success,
		Error,
	}
}
