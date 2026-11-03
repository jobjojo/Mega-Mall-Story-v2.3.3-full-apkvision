using form;
using kairo.unity.ui;

namespace system.form;

public class NewsForm : MyFormBase
{
	private static NewsForm news_;

	public const int FORMID_NEWS = 913;

	private const string PRE_DIR = "news/";

	private const string FILE_NAME = "news.bin";

	private static string domein_;

	private static string imgPath_;

	private const int IMG_NAME = 0;

	private const int INTRO = 1;

	private const int BNR_INTRO = 2;

	private const int URL = 3;

	private byte[] byteDataList_;

	private string[] imgNameList_;

	private byte[][] byteImgList_;

	private Image[] bnrImgList_;

	private string[] introList_;

	private string[] bnrIntroList_;

	private string[] urlList_;

	public bool active_;

	private const char DELIMITER = '#';

	public override string ToString()
	{
		return null;
	}

	private NewsForm()
		: base(0)
	{
	}

	public static NewsForm GetInstance()
	{
		return null;
	}

	public override bool Init()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
	}

	private string[] GetNewsDataListFrmSrv()
	{
		return null;
	}

	private byte[] GetImgDataFrmSrv(string imgName)
	{
		return null;
	}

	private string[] GetDataFromList(string[] dataList, int type)
	{
		return null;
	}

	private void SetNewsDataToDevice()
	{
	}

	private bool GetNewsDataFrmDevice()
	{
		return false;
	}

	private bool GetNewsDataFrmSrv()
	{
		return false;
	}

	private void PutPreferences(string key, byte[] data)
	{
	}

	private byte[] GetPreferences(string key)
	{
		return null;
	}

	private bool ExistPreferences(string key)
	{
		return false;
	}

	private string GetLangCodeByNews()
	{
		return null;
	}

	public void GetNewsData()
	{
	}

	public Image[] GetBnrImgList()
	{
		return null;
	}

	public string[] GetIntroList()
	{
		return null;
	}

	public string[] GetBnrIntroList()
	{
		return null;
	}

	public string[] GetUrlList()
	{
		return null;
	}

	public bool isNewsActive()
	{
		return false;
	}
}
