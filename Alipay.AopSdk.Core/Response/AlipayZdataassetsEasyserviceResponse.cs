using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdataassetsEasyserviceResponse.
	/// </summary>
	public class AlipayZdataassetsEasyserviceResponse : AopResponse
	{
		/// <summary>
		///     θΏεη»ζ
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}