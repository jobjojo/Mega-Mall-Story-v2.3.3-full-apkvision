using System;

namespace kairo.unity.util;

public class SafetyNetException : KairoException
{
	public enum ErrorCode
	{
		Error = 100,
		ErrorCommunication = 101,
		ErrorCheckEnabledCommunication = 102,
		ErrorGooglePlayServicesCommunication = 103,
		ErrorGetNonceCommunication = 104,
		ErrorSafetyNetCommunication = 105,
		ErrorJwsValidationCommunication = 106,
		ErrorCheckEnabledPackageNameUndefined = 107,
		ActionNotSupported = 110,
		PostJwsNone = 120,
		AppliVersion = 130,
		PackageName = 140,
		PackageNameDefinition = 150,
		AppliVersionDefinition = 160,
		InvalidNonce = 170,
		InvalidTimestamp = 180,
		InvalidPackageName = 190,
		InvalidApkCertificateDigest = 200,
		InvalidApkDigest = 210,
		InvalidCtsProfileMatchIsFalse = 220,
		InvalidBasicIntegrityIsFalse = 230,
		PidDefinition = 240
	}

	private ErrorCode errorCode_;

	public ErrorCode Error { get; private set; }

	public SafetyNetException(ErrorCode errorCode, string message = "", Exception exception = null)
		: base(null)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
