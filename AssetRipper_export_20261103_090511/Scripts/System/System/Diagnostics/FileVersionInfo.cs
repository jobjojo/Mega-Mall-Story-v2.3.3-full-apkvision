using System.Text;

namespace System.Diagnostics;

public sealed class FileVersionInfo
{
	private string comments;

	private string companyname;

	private string filedescription;

	private string filename;

	private string fileversion;

	private string internalname;

	private string language;

	private string legalcopyright;

	private string legaltrademarks;

	private string originalfilename;

	private string privatebuild;

	private string productname;

	private string productversion;

	private string specialbuild;

	private bool isdebug;

	private bool ispatched;

	private bool isprerelease;

	private bool isprivatebuild;

	private bool isspecialbuild;

	private int filemajorpart;

	private int fileminorpart;

	private int filebuildpart;

	private int fileprivatepart;

	private int productmajorpart;

	private int productminorpart;

	private int productbuildpart;

	private int productprivatepart;

	public string FileName => null;

	private FileVersionInfo()
	{
	}

	private static void AppendFormat(StringBuilder sb, string format, params object[] args)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
