using data_kasa;
using java.io;
using kairo.unity.ui;
using main;

namespace game_kasa;

public class Camera
{
	public bool pursuitHuman;

	public static Vector3D effect_pos;

	public static bool touchNow;

	public static bool resizeNow;

	public static bool resizeNow2;

	public static float dragSpeedX;

	public static float dragSpeedY;

	public static bool dragSlideNow;

	public static float modosuXSpeed;

	public static float modosuYSpeed;

	public static float modosuSpeedDefault;

	public AppData apdat_;

	public Canvas canvas_;

	public PlayerData p_data;

	private static Camera instance;

	public const bool FLG_BOTHCHECKMODE = true;

	public const int CAMERA_MODE_NORMAL = 0;

	public const int CAMERA_MODE_SCOPE_NORMAL = 1;

	public const int CAMERA_MODE_SCOPE_FOLLOW = 2;

	public const int CAMERA_MODE_AUTO_FOCUS = 3;

	public const int CAMERA_MODE_AUTO_FOCUS2 = 4;

	public const int CAMERA_MODE_TENANTCUSTOMER = 5;

	public int camera_mode;

	public Human_K scope_obj;

	public Tenant select_obj;

	public bool select_touch;

	public static Vector3D pos;

	public static Vector3D old_pos;

	public Vector3D v;

	public Vector3D a;

	public Vector3D screen_pos;

	public static int limit_left;

	public static int limit_right;

	public static int limit_top;

	public static int limit_bottom;

	public static int limit_left_camera;

	public static int limit_right_camera;

	public int limit_top_camera;

	public int limit_bottom_camera;

	public const int CURSOR_MOVE_X = 160;

	public const int CURSOR_MOVE_Y_UP = 320;

	public static int CURSOR_MOVE_Y_DOWN;

	public const float MAP_GLOBAL_W = 10000f;

	public const float MAP_GLOBAL_H = 10000f;

	public const float MAP_GLOBAL_LEFT = -5000f;

	public const float MAP_GLOBAL_RIGHT = 5000f;

	public const float MAP_GLOBAL_TOP = 5000f;

	public const float MAP_GLOBAL_BOTTOM = -5000f;

	public const float MAP_GLOBAL_Z_DIS = 96f;

	public const float MAP_GLOBAL_Z_ELEVATOR = 115.2f;

	public static int MAP_SCREEN_W;

	public static int MAP_SCREEN_H;

	public static int MAP_SCREEN_LEFT;

	public static int MAP_SCREEN_RIGHT;

	public static int MAP_SCREEN_TOP;

	public static int MAP_SCREEN_BOTTOM;

	public static int MAP_SCREEN_ADD_Z_ADD_X;

	public static int MAP_SCREEN_ADD_Z_ADD_Y;

	public static int MAP_SCREEN_PASSAGE_LEN;

	public static int MAP_SCREEN_TENANT_W;

	public static int MAP_SCREEN_TENANT_H;

	public static int MAP_SCREEN_TENANT_MA_TOP;

	public static int MAP_SCREEN_TENANT_MA_SIDE;

	public static float DEPART_GLOBAL_W;

	public static float DEPART_GLOBAL_H;

	public static float DEPART_GLOBAL_LEFT;

	public static float DEPART_GLOBAL_RIGHT;

	public static float DEPART_GLOBAL_TOP;

	public static float DEPART_GLOBAL_BOTTOM;

	public static readonly int DEPART_SCREEN_W;

	public static readonly int DEPART_SCREEN_H;

	public static readonly int DEPART_SCREEN_LEFT;

	public static readonly int DEPART_SCREEN_RIGHT;

	public static readonly int DEPART_SCREEN_TOP;

	public static readonly int DEPART_SCREEN_BOTTOM;

	public static float DEPART_GLOBAL_BLOCK_W;

	public static float DEPART_GLOBAL_BLOCK_H;

	public static int HUMAN_GLOBAL_BLOCK_W;

	public static int HUMAN_GLOBAL_BLOCK_H;

	private int cursorPressCnt_;

	public Vector3D cursor_pos;

	public Vector3D old_cursorPos;

	private int[] CURSOR_LIMIT_OFF;

	public int[] cursor_address;

	public int notDisp_cnt;

	public const int NOTDISP_MAX = 60;

	public static int HIT_R;

	public static int FLG_DISP_HITR;

	public Vector3D HITDIS_OFFSET;

	public int cnt_autoFocus;

	public int TIME_AUTOFOCUS;

	public Vector3D limit_pos_lt;

	public Vector3D limit_pos_rb;

	public Vector3D limit_pos_base;

	public static bool firstInit;

	public static bool centerMoveCursorFlag_;

	private int oldScale_;

	private int[] draw_tmp;

	public bool flg_drawCursorNo;

	private static int[] convertScreenToCamera_tmp1;

	public static Vector3D temp;

	private static int[] convertGlobalToScreen_tmp;

	private static int[] convertScreenToCamera2_tmp;

	private Vector3D setAutoFocusMode_tmp;

	public static float modosu_def_x;

	public static float modosu_def_y;

	public static Camera GetInstance()
	{
		return null;
	}

	private Camera()
	{
	}

	public void Init()
	{
	}

	public void UpdateViewRange()
	{
	}

	public void Update_move()
	{
	}

	public void PushSelectKey()
	{
	}

	public void Update()
	{
	}

	public void Update_normal()
	{
	}

	public void Update_scope()
	{
	}

	public void Update_autoFocus()
	{
	}

	public bool Update_autoFocus2()
	{
		return false;
	}

	public void SetCameraRect()
	{
	}

	public void Draw(Graphics g)
	{
	}

	public void SetDrawCusrsorNo()
	{
	}

	public bool GetDrawCursorNo()
	{
		return false;
	}

	public static void ConvertGlobalToScreen(Vector3D global_pos, Vector3D screen_pos)
	{
	}

	public static void ConvertScreenToCamera(Vector3D screen_pos, Vector3D camera_pos)
	{
	}

	public static int[] ConvertScreenToCamera(int[] screen_pos)
	{
		return null;
	}

	public static void ConvertGlobalToCamera(Vector3D global_pos, Vector3D camera_pos)
	{
	}

	public static int[] ConvertGlobalToCamera(Vector3D global_pos, int[] var_out)
	{
		return null;
	}

	public static int[] ConvertGlobalToScreen(Vector3D global_pos)
	{
		return null;
	}

	public static int[] ConvertScreenToCamera(Vector3D global_pos)
	{
		return null;
	}

	public static bool ChDisplayable(int c_x, int c_y, int w, int h)
	{
		return false;
	}

	public static void SetMapPosData()
	{
	}

	public static void UpdateScreenPosData()
	{
	}

	public void SetCameraLimitData()
	{
	}

	public void SetAutoFocusMode(Vector3D goal_screenPos)
	{
	}

	public void SetAutoFocusMode2()
	{
	}

	public void SetScopeMode(int h_id)
	{
	}

	public void Serialize(OutputStream os)
	{
	}

	public void Deserialize(InputStream stream)
	{
	}

	public void ResetOffscreen()
	{
	}

	public static void SetModosuSpeed()
	{
	}

	public static void SetModosuSpeed(float xs, float ys)
	{
	}

	public static void SetModosuSpeed(int xys)
	{
	}

	public static void SetModosuSpeed2()
	{
	}

	public static void AdjustCameraPad()
	{
	}
}
