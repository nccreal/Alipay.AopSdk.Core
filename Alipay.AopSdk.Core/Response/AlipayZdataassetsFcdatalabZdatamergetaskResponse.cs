using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdataassetsFcdatalabZdatamergetaskResponse.
	/// </summary>
	public class AlipayZdataassetsFcdatalabZdatamergetaskResponse : AopResponse
	{
		/// <summary>
		///     θΏεη»ζ
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}