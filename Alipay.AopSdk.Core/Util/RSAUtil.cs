namespace Alipay.AopSdk.Core.Util
{
	/// <summary>
	///     RSA签名工具类。
	/// </summary>
	public class RSAUtil
	{
		/// <summary>
		///     建议直接使用<code>AlipaySignature.RSASign(data, privateKeyPem)</code>
		/// </summary>
		/// <param name="data"></param>
		/// <param name="privateKeyPem"></param>
		/// <returns></returns>
		public static string RSASign(string data, string privateKeyPem, string charset)
		{
			return AlipaySignature.RSASign(data, privateKeyPem, charset, "RSA");
		}
	}
}