using System.Collections.Generic;
using System.Reflection;
using java.io;
using kairo.unity.util;

namespace kairo.unity.ui;

public class ResourceManager
{
	private struct JarCache(int rsId, int rcId, JarInflater jar)
	{
		public int RsId = 0;

		public int RcId = 0;

		public JarInflater Jar = null;
	}

	private delegate bool AsyncProcessMethod(int index);

	private static List<ResourceManager> all_;

	public const int RES_IMAGE = 0;

	public const int RES_SEB = 1;

	public const int RES_SOUND = 2;

	public const int RES_FIGURE = 3;

	public const int RES_ACT_TABLE = 4;

	public const int RES_TEXTURE = 5;

	public const int RES_GROUP = 6;

	private const int SOUND_MLD = 0;

	private const int SOUND_MMF = 1;

	private const int SOUND_SPF = 2;

	private const int SOUND_MIDI = 3;

	private const int SOUND_WAVE = 4;

	private const int SOUND_JET = 5;

	private const int SOUND_OGG = 6;

	private static readonly string[] SOUND_EXT;

	public Image[] img;

	public Seb[] seb;

	public SoundBase[] sound;

	public string[][] list_;

	private static readonly string[] LIST_FILE;

	protected string[] listFile_;

	protected string directory_;

	protected string folderName_;

	protected int rsId_;

	protected int rcId_;

	protected int loadNum_;

	protected int loadCnt_;

	protected bool loaded_;

	protected int recordNameBits_;

	private static List<JarCache> jarCache_;

	private static int yieldTime_;

	internal static List<ResourceManager> All => null;

	public static int YieldTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Dictionary<int, Image> CustomImages { get; private set; }

	public static Image LoadImage(byte[] src, Image.Format format = Image.Format.Default, Image.Filter filterMode = Image.Filter.Default)
	{
		return null;
	}

	public static Image LoadImage(InputStream stream, Image.Format format = Image.Format.Default, Image.Filter filterMode = Image.Filter.Default)
	{
		return null;
	}

	public static Seb LoadSeb(byte[] src)
	{
		return null;
	}

	public static Seb LoadSeb(InputStream stream)
	{
		return null;
	}

	public static SoundBase LoadSound(byte[] src, int format)
	{
		return null;
	}

	public static SoundBase LoadSound(InputStream stream, int format)
	{
		return null;
	}

	public static SoundBase LoadSound(string file, int format)
	{
		return null;
	}

	public ResourceManager(string imgList = null, string sebList = null, string sndList = null, string figList = null, string actList = null, string texList = null, string grpList = null)
	{
	}

	protected void _init()
	{
	}

	protected void _init(bool keepFileList)
	{
	}

	public void Load(byte[] data, int m3dVer = 3)
	{
	}

	public void Load(JarInflater jar, int m3dVer = 3)
	{
	}

	public void Load(string directory, int m3dVer = 3)
	{
	}

	public void Load(int rsId, int rcId, int m3dVer = 3)
	{
	}

	public void Load(Assembly assembly, string name)
	{
	}

	public void LoadReady(byte[] data)
	{
	}

	public void LoadReady(JarInflater jar)
	{
	}

	public void LoadStart(byte[] data, int m3dVer = 3)
	{
	}

	public void LoadStart(JarInflater jar, int m3dVer = 3)
	{
	}

	private bool CheckFileEffective(string file)
	{
		return false;
	}

	private string GetFileName(string file)
	{
		return null;
	}

	public void Dispose()
	{
	}

	public void Dispose(bool keepFileList)
	{
	}

	public int GetProgTotal()
	{
		return 0;
	}

	public int GetProgNow()
	{
		return 0;
	}

	public int GetProgLevel()
	{
		return 0;
	}

	public void RenderSeb(Graphics g, float x, float y, float depth, int seb)
	{
	}

	public void RenderSeb(Graphics g, float x, float y, float depth, int seb, int frame)
	{
	}

	public void RenderSeb(Graphics g, float x, float y, float depth, int seb, int frame, int layer)
	{
	}

	public void RenderSebAnchor(Graphics g, float x, float y, float depth, int seb, int anchor)
	{
	}

	public void RenderSebAnchor(Graphics g, float x, float y, float depth, int seb, int frame, int anchor)
	{
	}

	public void RenderSebAnchor(Graphics g, float x, float y, float depth, int seb, int frame, int layer, int anchor)
	{
	}

	public void DrawSeb(Graphics g, float x, float y, int seb)
	{
	}

	public void DrawSeb(Graphics g, float x, float y, int seb, int frame)
	{
	}

	public void DrawSeb(Graphics g, float x, float y, int seb, int frame, int layer)
	{
	}

	public void DrawSebAnchor(Graphics g, float x, float y, int seb, int anchor)
	{
	}

	public void DrawSebAnchor(Graphics g, float x, float y, int seb, int frame, int anchor)
	{
	}

	public void DrawSebAnchor(Graphics g, float x, float y, int seb, int frame, int layer, int anchor)
	{
	}

	protected float[] GetSebAnchorPosition(float x, float y, int seb, int frame, int anchor)
	{
		return null;
	}

	protected float[] GetSebAnchorPositionF(float x, float y, int seb, int frame, int anchor)
	{
		return null;
	}

	public void SetLoadFileList(int type, string[] list)
	{
	}

	public ResourceManager SetRecordNameBits(int bits)
	{
		return null;
	}

	public int GetRecordNameBits()
	{
		return 0;
	}

	public void UseAllImages()
	{
	}

	public void UnuseAllImages()
	{
	}

	public void LoadJarImages()
	{
	}

	public void DisposeJarImages()
	{
	}

	internal static JarInflater OpenJarCache(int rsId, int rcId)
	{
		return null;
	}

	internal static void CloseJarCache()
	{
	}

	private void StartAsyncTask(long yieldTime, AsyncProcessMethod method)
	{
	}

	internal Image GetImage(int texId)
	{
		return null;
	}

	public void SetFolderName(string folderName)
	{
	}

	public string GetFolderName()
	{
		return null;
	}
}
