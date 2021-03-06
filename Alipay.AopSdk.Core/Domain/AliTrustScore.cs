using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AliTrustScore Data Structure.
	/// </summary>
	[Serializable]
	public class AliTrustScore : AopObject
	{
		/// <summary>
		///     ่้บปๅ
		/// </summary>
		[JsonProperty("score")]
		public long Score { get; set; }
	}
}