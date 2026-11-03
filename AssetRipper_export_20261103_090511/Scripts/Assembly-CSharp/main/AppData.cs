using data_kasa;
using form;
using java.io;
using java.util;
using kairo.unity.form;
using kairo.unity.ui;
using kairo.unity.util;

namespace main;

public class AppData
{
	private static AppData instance_;

	private static Canvas canvas_;

	public const int APPLI_VERSION = 233;

	public const int REGIST_WAIT = 1;

	public const int PID = 30;

	public static string CGI_COMMON_QUERY;

	public static string URL;

	public static string HOST;

	public static string URL_CGI;

	public static string URL_DAT;

	public static string SITE_URL;

	public static string VERSIONUP_URL;

	public const int CGI_REGIST = 0;

	public const int CGI_RANKING = 1;

	public const int CGI_REGIST_SCORE = 2;

	public const int CGI_GET_SCORE = 3;

	public static string[] CGI;

	public BootForm frmBoot_;

	public TitleForm frmTitle_;

	public TestForm frmTest_;

	public const int FORMID_BOOT = 0;

	public const int FORMID_TITLE = 1;

	public const int FORMID_GAME = 2;

	public const int FORMID_RANK = 3;

	public const int FORMID_SUB = 4;

	public const int FORMID_DEBUG = 5;

	public const int FORMID_TEST = 6;

	public const int RES_XLS = 0;

	public const int RES_COM = 1;

	public const int RES_TITLE = 2;

	public const int RES_EVENT = 3;

	public const int RES_SOUND = 4;

	public const int RES_RESIDENT = 5;

	public const int RES_LOCATION = 6;

	public const int RES_CHIP = 7;

	public const int RES_SEASON_CHIP = 8;

	public const int RES_GAME = 9;

	public const int RES_MAP = 10;

	public const int RES_BODY = 11;

	public const int RES_HEAD = 12;

	public const int RES_END = 13;

	public int[] addrSC_;

	public static string[] strDatFileName_;

	public static int[] dateFileHead_;

	public const int RS_SYSTEM = 0;

	public const int RS_RESOURCE = 1;

	public const int RSSYS_SYSSAVE = 0;

	public const int RSSYS_SAVE1 = 1;

	public const int RSSYS_SAVE2 = 2;

	public const int RSSYS_AUTO1 = 3;

	public const int RSSYS_AUTO2 = 4;

	public const int RSRES_XLS = 0;

	public const int RSRES_COM = 1;

	public const int RSRES_COM2 = 2;

	public const int RSRES_HUMAN = 3;

	public const int RSRES_EVENT = 4;

	public const int RSRES_AREA = 5;

	public const int RSRES_SALE = 6;

	public const int RSRES_TITLE = 7;

	public const int RSRES_SOUND = 8;

	public const int RSSYS_SIZE_SYSSAME = 2048;

	public const int RSSYS_SIZE_SAVE1 = 148480;

	public static readonly string[][] RSFILENAMESS;

	public const int RESCOM_IMG_2PANEL00 = 0;

	public const int RESCOM_IMG_2PANEL01 = 1;

	public const int RESCOM_IMG_CURSOR = 2;

	public const int RESCOM_IMG_DEPART_SIDE_L = 3;

	public const int RESCOM_IMG_DEPART_SIDE_R = 4;

	public const int RESCOM_IMG_ELEVATOR = 5;

	public const int RESCOM_IMG_ELEVATOR_DOOR = 6;

	public const int RESCOM_IMG_ESCALATOR = 7;

	public const int RESCOM_IMG_FLOOR00 = 8;

	public const int RESCOM_IMG_GROUND00 = 9;

	public const int RESCOM_IMG_MENUBAR = 10;

	public const int RESCOM_IMG_PANEL00 = 11;

	public const int RESCOM_IMG_PANEL01 = 12;

	public const int RESCOM_IMG_PANEL02 = 13;

	public const int RESCOM_IMG_PANEL03 = 14;

	public const int RESCOM_IMG_PANEL04 = 15;

	public const int RESCOM_IMG_ROOFTOP = 16;

	public const int RESCOM_IMG_STAIR00 = 17;

	public const int RESCOM_IMG_STAIR01 = 18;

	public const int RESCOM_IMG_FRAME = 19;

	public const int RESCOM_IMG_PANEL06 = 20;

	public const int RESCOM_IMG_DEPART_SIDE_L2 = 21;

	public const int RESCOM_IMG_DEPART_SIDE_R2 = 22;

	public const int RESCOM_IMG_DEPART_SIDE_L_ENTRANCE = 23;

	public const int RESCOM_IMG_DEPART_SIDE_R_ENTRANCE = 24;

	public const int RESCOM_IMG_DEPART_SIDE_ENTRANCE_HALF = 25;

	public const int RESCOM_IMG_SKY00 = 26;

	public const int RESCOM_IMG_DEPART_SIDE_L_THIN = 27;

	public const int RESCOM_IMG_DEPART_SIDE_R_THIN = 28;

	public const int RESCOM_IMG_ESCALATOR2 = 29;

	public const int RESCOM_IMG_DEPART_SIDE_L_UNDERG = 30;

	public const int RESCOM_IMG_DEPART_SIDE_R_UNDERG = 31;

	public const int RESCOM_IMG_ROOFTOP_UNDERG = 32;

	public const int RESCOM_IMG_TRAIN_STATION = 33;

	public const int RESCOM_IMG_GROUND_WORK = 34;

	public const int RESCOM_IMG_CURSOR_NO = 35;

	public const int RESCOM_IMG_CONSTRUCTION0 = 36;

	public const int RESCOM_IMG_CONSTRUCTION1 = 37;

	public const int RESCOM_IMG_CONSTRUCTION2 = 38;

	public const int RESCOM_IMG_SERVICE_COUNTER = 39;

	public const int RESCOM_IMG_ELEVATOR2 = 40;

	public const int RESCOM_IMG_FUKIDASHI00 = 41;

	public const int RESCOM_IMG_FUKIDASHI01 = 42;

	public const int RESCOM_IMG_FUKIDASHI02 = 43;

	public const int RESCOM_IMG_FUKIDASHI03 = 44;

	public const int RESCOM_IMG_FUKIDASHI04 = 45;

	public const int RESCOM_IMG_GROUND01 = 46;

	public const int RESCOM_IMG_FLOOR01 = 47;

	public const int RESCOM_IMG_ENTRANCE = 48;

	public const int RESCOM_IMG_PANEL08 = 49;

	public const int RESCOM_IMG_SKY01 = 81;

	public const int RESCOM_IMG_WEATHER = 82;

	public const int RESCOM_IMG_SHUTTER = 83;

	public const int RESCOM_IMG_SKY02 = 122;

	public const int RESCOM_IMG_FRAME2 = 126;

	public const int RESCOM_IMG_FILTER_TOP = 128;

	public const int RESCOM_IMG_FILTER_BOTTOM = 129;

	public const int RESCOM_IMG_GLASS_ICON = 130;

	public const int RESCOM_IMG_BUILD_SET_ICON = 131;

	public const int RESCOM_IMG_BUILD_SET_ICON2 = 132;

	public const int RESCOM_SEB_DEPART_SIDE_ENTRANCE_HALF = 0;

	public const int RESCOM_SEB_ESCALATOR2 = 1;

	public const int RESCOM_SEB_STAIR0 = 2;

	public const int RESCOM_SEB_STAIR1 = 3;

	public const int RESCOM_SEB_ELEVATOR2 = 4;

	public const int RESCOM_SEB_WEATHER = 5;

	public const int RESCOM2_IMG_FINGER = 0;

	public const int RESCOM2_IMG_MENU = 1;

	public const int RESCOM2_IMG_WNDBAR = 2;

	public const int RESCOM2_IMG_GRBAR = 3;

	public const int RESCOM2_IMG_BTMBAR = 4;

	public const int RESCOM2_IMG_NUMBER00 = 5;

	public const int RESCOM2_IMG_SHOPPING_WAGON = 6;

	public const int RESCOM2_IMG_SHOPPING_BAG = 7;

	public const int RESCOM2_IMG_NUMBER01 = 8;

	public const int RESCOM2_IMG_WNDCORNER = 9;

	public const int RESCOM2_IMG_HISHO_TALK = 10;

	public const int RESCOM2_IMG_BTM_NUMCUSTOMER = 11;

	public const int RESCOM2_IMG_TIP_TALKWINDOW = 12;

	public const int RESCOM2_IMG_ARROW = 13;

	public const int RESCOM2_IMG_HEARTBAR = 14;

	public const int RESCOM2_IMG_EQUIPITEM = 15;

	public const int RESCOM2_IMG_EQUIPITEM_NUM = 16;

	public const int RESCOM2_IMG_LV = 17;

	public const int RESCOM2_IMG_STAR = 18;

	public const int RESCOM2_IMG_COMPANY = 19;

	public const int RESCOM2_IMG_GAGE_HAPPY = 20;

	public const int RESCOM2_IMG_HEART = 21;

	public const int RESCOM2_IMG_INCOME_GRAPH00 = 22;

	public const int RESCOM2_IMG_INCOME_GRAPH01 = 23;

	public const int RESCOM2_IMG_ICON_ITEM = 24;

	public const int RESCOM2_IMG_ICON_TENANTMATH = 25;

	public const int RESCOM2_IMG_FINGER_D = 26;

	public const int RESCOM2_IMG_LVUP = 27;

	public const int RESCOM2_IMG_AREA_LVUP = 28;

	public const int RESCOM2_IMG_ICON_POLICY = 29;

	public const int RESCOM2_IMG_YOROKOBI_MINICHARA = 30;

	public const int RESCOM2_IMG_YOROKOBI_BACK = 31;

	public const int RESCOM2_IMG_NUMBER02 = 32;

	public const int RESCOM2_IMG_AREABLOCK_BAR = 33;

	public const int RESCOM2_IMG_NEW = 34;

	public const int RESCOM2_IMG_WNDCORNER2 = 35;

	public const int RESCOM2_IMG_ICON_MENU = 36;

	public const int RESCOM2_IMG_ICON_MENU_SCOPE = 37;

	public const int RESCOM2_IMG_CURSOR_SCOPE = 38;

	public const int RESCOM2_IMG_BAR_STOCK = 39;

	public const int RESCOM2_IMG_TENANTINFO_TIP = 40;

	public const int RESCOM2_IMG_ICON_EXPAND = 41;

	public const int RESCOM2_IMG_NUMBER03 = 42;

	public const int RESCOM2_IMG_NUMBER04 = 43;

	public const int RESCOM2_IMG_TENANT_BONUS = 44;

	public const int RESCOM2_IMG_FUKIDASHI_CLOSE = 45;

	public const int RESCOM2_IMG_SKILL_UPDOWN = 46;

	public const int RESCOM2_IMG_ARROW01 = 47;

	public const int RESCOM2_IMG_NUMBER05 = 48;

	public const int RESCOM2_IMG_TRAIN = 49;

	public const int RESCOM2_IMG_TRAIN_RAIL = 50;

	public const int RESCOM2_IMG_TRAIN_RAIL_BOARD = 51;

	public const int RESCOM2_IMG_TRAIN_RAIL_FOOT = 52;

	public const int RESCOM2_IMG_TRAIN_RAIL_FOOTBASE = 53;

	public const int RESCOM2_IMG_TRAIN_RAIL_UNDERG = 54;

	public const int RESCOM2_IMG_FUKIDASHI = 55;

	public const int RESCOM2_IMG_ICON_SEASON = 56;

	public const int RESCOM2_IMG_BAR_MIDDLEWIN = 57;

	public const int RESCOM2_IMG_NUMBER06 = 58;

	public const int RESCOM2_IMG_ICON_SECRET = 59;

	public const int RESCOM2_IMG_CLERK00 = 60;

	public const int RESCOM2_IMG_CLERK01 = 61;

	public const int RESCOM2_IMG_CLERK02 = 62;

	public const int RESCOM2_IMG_CLERK03 = 63;

	public const int RESCOM2_IMG_CONST00 = 65;

	public const int RESCOM2_IMG_HELI = 66;

	public const int RESCOM2_IMG_SALE = 67;

	public const int RESCOM2_IMG_REGULAR_STAR = 68;

	public const int RESCOM2_IMG_ICON_PROJECT = 69;

	public const int RESCOM2_IMG_FUKIDASHI_NOTRETURN = 70;

	public const int RESCOM2_IMG_TENANT_REGI_ICON = 71;

	public const int RESCOM2_IMG_SHOPPING_TABLE = 73;

	public const int RESCOM2_IMG_SHOPPING_CAGO = 74;

	public const int RESCOM2_IMG_EF_FIREWORK = 75;

	public const int RESCOM2_IMG_EF_REFRESH = 76;

	public const int RESCOM2_IMG_FUKIDASHI00 = 78;

	public const int RESCOM2_IMG_FUKIDASHI00_BACK = 79;

	public const int RESCOM2_IMG_TENANTINFO_TIP2 = 80;

	public const int RESCOM2_IMG_TENANT_SERVICE_ICON = 93;

	public const int RESCOM2_IMG_AREA_NAME = 94;

	public const int RESCOM2_IMG_AREA_SHAREBAR = 95;

	public const int RESCOM2_IMG_ICON_REGULARBONUS00 = 96;

	public const int RESCOM2_IMG_ICON_REGULARBONUS01 = 97;

	public const int RESCOM2_IMG_ICON_REGULARBONUS02 = 98;

	public const int RESCOM2_IMG_ICON_REGULARBONUS03 = 99;

	public const int RESCOM2_IMG_CHARA_PRESIDENT = 100;

	public const int RESCOM2_IMG_CHARA_HISHO = 101;

	public const int RESCOM2_IMG_CHARA_PUMPKIN = 102;

	public const int RESCOM2_IMG_FUKIDASHI_DOKIDOKI = 103;

	public const int RESCOM2_IMG_NEWS_LOGO = 104;

	public const int RESCOM2_IMG_RIVAL_INFOINCOME = 105;

	public const int RESCOM2_IMG_RIVALDEPART_USING = 106;

	public const int RESCOM2_IMG_BUS = 107;

	public const int RESCOM2_IMG_BUS_ROUTE = 108;

	public const int RESCOM2_IMG_ICON_ADVERTISE = 109;

	public const int RESCOM2_IMG_EF_TENANTTOPICUP = 110;

	public const int RESCOM2_IMG_DOLLAR = 111;

	public const int RESCOM2_IMG_SALE_MENU_LEFT = 112;

	public const int RESCOM2_IMG_SALE_MENU_CENTRAL = 113;

	public const int RESCOM2_IMG_SALE_MENU_RIGHT = 114;

	public const int RESCOM2_IMG_MENU_BAR_LEFT = 115;

	public const int RESCOM2_IMG_MENU_BAR_CENTRAL = 116;

	public const int RESCOM2_IMG_MENU_BAR_RIGHT = 117;

	public const int RESCOM2_IMG_PLAYER_CURSOR = 118;

	public const int RESCOM2_IMG_ERE_1 = 119;

	public const int RESCOM2_IMG_ERE_2 = 120;

	public const int RESCOM2_IMG_STA_1 = 121;

	public const int RESCOM2_IMG_STA_2 = 122;

	public const int RESCOM2_SEB_FINGER_L = 0;

	public const int RESCOM2_SEB_FINGER_R = 1;

	public const int RESCOM2_SEB_MENU = 2;

	public const int RESCOM2_SEB_WNDBAR = 3;

	public const int RESCOM2_SEB_GRBAR = 4;

	public const int RESCOM2_SEB_BTMBAR = 5;

	public const int RESCOM2_SEB_NUMBER00 = 6;

	public const int RESCOM2_SEB_SHOPPING_WAGON = 7;

	public const int RESCOM2_SEB_SHOPPING_BAG = 8;

	public const int RESCOM2_SEB_NUMBER01 = 9;

	public const int RESCOM2_SEB_WNDCORNER = 10;

	public const int RESCOM2_SEB_ARROW = 11;

	public const int RESCOM2_SEB_HEART = 12;

	public const int RESCOM2_SEB_AREA_LVUP = 13;

	public const int RESCOM2_SEB_YOROKOBI_MINICHARA = 14;

	public const int RESCOM2_SEB_NUMBER02 = 15;

	public const int RESCOM2_SEB_WNDCORNER2 = 16;

	public const int RESCOM2_SEB_ICON_MENU = 17;

	public const int RESCOM2_SEB_TENANTINFO_TIP = 18;

	public const int RESCOM2_SEB_ICON_EXPAND = 19;

	public const int RESCOM2_SEB_NUMBER03 = 20;

	public const int RESCOM2_SEB_NUMBER04 = 21;

	public const int RESCOM2_SEB_FUKIDASHI_CLOSE = 22;

	public const int RESCOM2_SEB_SKILL_UPDOWN = 23;

	public const int RESCOM2_SEB_ARROW01 = 24;

	public const int RESCOM2_SEB_NUMBER05 = 25;

	public const int RESCOM2_SEB_FUKIDASHI = 26;

	public const int RESCOM2_SEB_ICON_SEASON = 27;

	public const int RESCOM2_SEB_NUMBER06 = 28;

	public const int RESCOM2_SEB_CLERK_WARK_LEFT = 29;

	public const int RESCOM2_SEB_CLERK_WARK_RIGHT = 30;

	public const int RESCOM2_SEB_CLERK_ACT_LEFT = 31;

	public const int RESCOM2_SEB_CLERK_ACT_RIGHT = 32;

	public const int RESCOM2_SEB_CONST00 = 33;

	public const int RESCOM2_SEB_HELI_LEFT = 34;

	public const int RESCOM2_SEB_HELI_RIGHT = 35;

	public const int RESCOM2_SEB_SALE = 36;

	public const int RESCOM2_SEB_ICON_PROJECT = 37;

	public const int RESCOM2_SEB_SHOPPING_CAGO = 38;

	public const int RESCOM2_SEB_EF_FIREWORK = 39;

	public const int RESCOM2_SEB_EF_REFRESH = 40;

	public const int RESCOM2_SEB_FUKIDASHI00 = 41;

	public const int RESCOM2_SEB_TENANTINFO_TIP2 = 42;

	public const int RESCOM2_SEB_AREA_NAME = 43;

	public const int RESCOM2_SEB_CHARA_PRESIDENT = 44;

	public const int RESCOM2_SEB_CHARA_HISHO = 45;

	public const int RESCOM2_SEB_CHARA_PUMPKIN = 46;

	public const int RESCOM2_SEB_STAR = 47;

	public const int RESCOM2_SEB_ICON_ITEM = 48;

	public const int RESCOM2_SEB_ICON_ADVERTISE = 49;

	public const int RESCOM2_SEB_DOLLAR = 50;

	public const int RESHUMAN_IMG_HUMANNUM = 33;

	public const int RESHUMAN_SEB_WALK_LEFT = 0;

	public const int RESHUMAN_SEB_WALK_RIGHT = 1;

	public const int RESHUMAN_SEB_USE = 4;

	public const int RESHUMAN_SEB_JAMP_L = 6;

	public const int RESHUMAN_SEB_JAMP_R = 8;

	public const int RESHUMAN_SEB_TEA_TIME = 10;

	public const int RESHUMAN_SEB_GET_ITEM = 11;

	public const int RESHUMAN_SEB_GET_ITEM_R = 12;

	public const int RESHUMAN_SEB_ROTATE = 13;

	public const int RESEVENT_IMG_COME_BACK = 0;

	public const int RESEVENT_IMG_COME_FAN = 1;

	public const int RESEVENT_IMG_YOROKOBI_CHARA = 2;

	public const int RESEVENT_IMG_SAD_CHARA = 3;

	public const int RESEVENT_IMG_YOROKOBI_BACK = 4;

	public const int RESEVENT_IMG_SAD_BACK = 5;

	public const int RESEVENT_IMG_FUKIDASHI_YORO = 6;

	public const int RESEVENT_IMG_NEWTENANT_BACK = 7;

	public const int RESEVENT_IMG_RANKUP_PEOPLE = 8;

	public const int RESEVENT_IMG_RANKUP_BACK = 9;

	public const int RESEVENT_IMG_RANKUP_CON = 10;

	public const int RESEVENT_IMG_CLEARPOINT_HSCORE = 11;

	public const int RESEVENT_SEB_RANKUP_PEOPLE = 0;

	public const int RESEVENT_SEB_YOROKOBI_CHARA = 1;

	public const int RESEVENT_SEB_SAD_CHARA = 2;

	public const int RESAREA_IMG_BACK00 = 0;

	public const int RESAREA_IMG_FOREST = 1;

	public const int RESAREA_IMG_CONST = 2;

	public const int RESAREA_IMG_TIP = 3;

	public const int RESAREA_IMG_BUILD_SALE = 4;

	public const int RESAREA_IMG_DEPART00 = 20;

	public const int RESAREA_IMG_DEPART01 = 21;

	public const int RESAREA_IMG_DEPART02 = 22;

	public const int RESAREA_IMG_RIVAL00 = 23;

	public const int RESAREA_IMG_RIVAL01 = 24;

	public const int RESAREA_IMG_RIVAL02 = 25;

	public const int RESAREA_SEB_TIP = 0;

	public const int RESSALE_IMG_BACK00 = 0;

	public const int RESSALE_IMG_BACK01 = 1;

	public const int RESSALE_IMG_BACK02 = 2;

	public const int RESSALE_IMG_FEVER = 3;

	public const int RESSALE_IMG_BAR = 4;

	public const int RESSALE_IMG_MENU00 = 5;

	public const int RESSALE_IMG_STR = 6;

	public const int RESSALE_IMG_MENU01 = 7;

	public const int RESSALE_IMG_BUSINESS = 8;

	public const int RESSALE_SEB_STR = 0;

	public const int RESSALE_SEB_FEVER = 1;

	public const int RESSALE_SEB_BAR = 2;

	public const int RESSALE_SEB_BUSINESS = 3;

	public ResourceManager resCom_;

	public ResourceManager resCom2_;

	public ResourceManager resHuman_;

	public ResourceManager resEvent_;

	public ResourceManager resArea_;

	public ResourceManager resSale_;

	public const int RESSOUND_SND_SE_KANASHIMI = 0;

	public const int RESSOUND_SND_SE_LEVELUP = 1;

	public const int RESSOUND_SND_BGM_MAIN_DOWN = 2;

	public const int RESSOUND_SND_BGM_MAIN_NORMAL = 3;

	public const int RESSOUND_SND_BGM_MAIN_UPPER = 4;

	public const int RESSOUND_SND_BGM_TITLE_MAE = 5;

	public const int RESSOUND_SND_BGM_TITLE_USHIRO = 6;

	public const int RESSOUND_SND_SE_YOROKOBI = 7;

	public const int RESSOUND_SND_SE_TITLE_MAE = 8;

	public const int RESSOUND_SND_SE_00_KIRAN1 = 9;

	public const int RESSOUND_SND_SE_03_SALE = 10;

	public const int RESSOUND_SND_SE_06_POPUP = 11;

	public const int RESSOUND_SND_SE_09_BUILD = 12;

	public ResourceManager resSound_;

	public static readonly int[] BGM;

	public static readonly int[] SE;

	public static readonly int[] SE_YOROKOBI;

	public const int SOFT_NONE = 0;

	public const int SOFT_KETTEI = 1;

	public const int SOFT_SYURYOU = 2;

	public const int SOFT_MODORU = 3;

	public const int SOFT_HAI = 4;

	public const int SOFT_IIE = 5;

	public const int SOFT_KAKUNIN = 6;

	public const int SOFT_SAVE = 7;

	public const int SOFT_MENU = 8;

	public const int SOFT_MAP = 9;

	public const int SOFT_PORT = 10;

	public const int SOFT_CULTIVATION = 11;

	public const int SOFT_NORMAL = 12;

	public const int SOFT_DEPARTURE = 13;

	public const int SOFT_ALL = 14;

	public const int SOFT_KANRYOU = 15;

	public const int SOFT_HELP = 16;

	public const int SOFT_MY = 17;

	public const int SOFT_HIGH_RANK = 18;

	public const int SOFT_SITE = 19;

	public const int SOFT_KAKAKU_ZYUN = 20;

	public const int SOFT_NINKI_ZYUN = 21;

	public const int SOFT_ZAIRYOU_ZYUN = 22;

	public const int SOFT_SEISAN = 23;

	public const int SOFT_KAISHI = 24;

	public const int SOFT_HENSYU = 25;

	public const int SOFT_AISYOU = 26;

	public const int SOFT_KAITEN = 27;

	public const int SOFT_URIBA = 28;

	public const int SOFT_MARKET = 29;

	public const int SOFT_TITLE = 30;

	public const int SOFT_TSUGIE = 31;

	public const int SOFT_KEIEI = 32;

	public const int SOFT_LEFT = 33;

	public const int SOFT_RIGHT = 34;

	public const int SOFT_EXPORT = 35;

	public const int SOFT_AROUND = 36;

	public const int SOFT_DISPATCH = 37;

	public const int SOFT_SCOUT = 38;

	public const int SOFT_AUTO = 39;

	public const int SOFT_HINT = 40;

	public const int SOFT_SORT = 41;

	public const int SOFT_HOSOKU = 42;

	public const int SOFT_INIT = 43;

	public const int SOFT_ESCAPE = 44;

	public const int SOFT_HIGHSPEED = 45;

	public const int SOFT_NORMALSPEED = 46;

	public const int SOFT_KAIZYO = 47;

	public const int SOFT_SALE = 48;

	public const int SOFT_CHANGE = 49;

	public const int SOFT_REMOVE = 50;

	public const int SOFT_EXPLAIN = 51;

	public const int SOFT_INFO = 52;

	public const int SOFT_SCOPE = 53;

	public const int SOFT_CUSTOMER = 54;

	public const int SOFT_TENANT = 55;

	public const int SOFT_ON = 56;

	public const int SOFT_OFF = 57;

	public const int SOFT_HINT_ON = 58;

	public const int SOFT_HINT_OFF = 59;

	public const int SOFT_CANCEL = 60;

	public const int SOFT_PRODUCT = 61;

	public static readonly string[] softLabels_;

	public const int SYSSAVEP_END = 0;

	public static readonly Property[] defSysSaveP_;

	public const int SYSSAVEI_VER = 0;

	public const int SYSSAVEI_FLAG = 1;

	public const int SYSSAVEI_DLCNT = 2;

	public const int SYSSAVEI_BGM_LEVEL = 3;

	public const int SYSSAVEI_SE_LEVEL = 4;

	public const int SYSSAVEI_REGIST_WAIT = 5;

	public const int SYSSAVEI_SAVE1_DATE = 6;

	public const int SYSSAVEI_SAVE2_DATE = 7;

	public const int SYSSAVEI_AUTO1_DATE = 8;

	public const int SYSSAVEI_AUTO2_DATE = 9;

	public const int SYSSAVEI_CURRENT_SAVE = 10;

	public const int SYSSAVEI_OPEN_HIGHSPEED = 11;

	public const int SYSSAVEI_BUILD_HINT = 12;

	public const int SYSSAVEI_SCREEN_ORIENTATION = 13;

	public const int SYSSAVEI_CURRENCY = 14;

	public const int SYSSAVEI_PADMODE = 15;

	public const int SYSSAVEI_KAIROKUN_TWITTED = 16;

	public const int SYSSAVEI_END = 17;

	public static readonly int[] defSysSaveI_;

	public const int SYSSAVEL_HIGHSCORE = 0;

	public const int SYSSAVEL_NET_HIGHSCORE = 1;

	public const int SYSSAVEL_MONEY_HIGHSCORE = 2;

	public const int SYSSAVEL_MONEY_NET_HIGHSCORE = 3;

	public const int SYSSAVEL_END = 4;

	public static readonly long[] defSysSaveL_;

	public const int SYSSAVE_FLAG_RES_DOWNLOADED = 1;

	public const int SYSSAVES_HIGHSCORE_NAME = 0;

	public const int SYSSAVES_MONEY_HIGHSCORE_NAME = 1;

	public const int SYSSAVES_SAVE1_NAME = 2;

	public const int SYSSAVES_SAVE2_NAME = 3;

	public const int SYSSAVES_SAVE1_MONEY = 4;

	public const int SYSSAVES_SAVE2_MONEY = 5;

	public const int SYSSAVES_AUTO1_NAME = 6;

	public const int SYSSAVES_AUTO2_NAME = 7;

	public const int SYSSAVES_AUTO1_MONEY = 8;

	public const int SYSSAVES_AUTO2_MONEY = 9;

	public const int SYSSAVES_ERROR = 10;

	public const int SYSSAVES_END = 11;

	public static readonly string[] defSysSaveS_;

	public const int SYSSAVEB_DISCOVER_TENANT = 0;

	public const int SYSSAVEB_DISCOVER_SPFLOOR = 1;

	public const int SYSSAVEB_VISITORS = 2;

	public const int SYSSAVEB_END = 3;

	public static readonly byte[][] defSysSaveB_;

	public Property sysSave_;

	public const int DATA_CHIP = 0;

	public const int DATA_EVENT = 1;

	public const int DATA_TALK = 2;

	public const int SAVEP_EVENT_NUM = 0;

	public const int SAVEP_END = 1;

	public static readonly Property[] defSaveP_;

	public const int SAVEI_SAVEVER = 0;

	public const int SAVEI_YEAR = 1;

	public const int SAVEI_MONTH = 2;

	public const int SAVEI_WEEK = 3;

	public const int SAVEI_TIME = 4;

	public const int SAVEI_CURSOR_X = 5;

	public const int SAVEI_CURSOR_Y = 6;

	public const int SAVEI_FLAG = 7;

	public const int SAVEI_RIDE_TALK_CHARA = 8;

	public const int SAVEI_MAIN_BGM_GRADE = 9;

	public const int SAVEI_QUALITY = 10;

	public const int SAVEI_GAME_SPEED = 11;

	public const int SAVEI_ENDING = 12;

	public const int SAVEI_SCALE = 13;

	public const int SAVEI_END = 14;

	public static readonly int[] defSaveI_;

	public const int FLAG_BROADCAST = 1;

	public const int FLAG_MERCHANT = 2;

	public const int FLAG_INVEST = 4;

	public const int FLAG_EXPL_BUILD_ROAD = 512;

	public const int FLAG_EXPL_CUSTOMER_FOLLOW = 1024;

	public const int FLAG_EXPL_TENANT_INFO = 4096;

	public const int FLAG_EXPL_HINT = 2048;

	public const int FLAG_EXPL_ROAD = 256;

	public const int SAVEL_MONEY = 0;

	public const int SAVEL_PR = 1;

	public const int SAVEL_VTR = 2;

	public const int SAVEL_END = 3;

	public static readonly long[] defSaveL_;

	public const int SAVES_NAME = 0;

	public const int SAVES_END = 1;

	public static readonly string[] defSaveS_;

	public const int SAVEB_DEPART = 0;

	public const int SAVEB_PLAYERDATA = 1;

	public const int SAVEB_CUSTOMER_OBJ = 2;

	public const int SAVEB_CUSTOMERDATA = 3;

	public const int SAVEB_CAMERA = 4;

	public const int SAVEB_VEHICLE = 5;

	public const int SAVEB_APART = 6;

	public const int SAVEB_DELAY_EVENTS = 7;

	public const int SAVEB_RIVAL = 8;

	public const int SAVEB_END = 9;

	public static readonly byte[][] defSaveB_;

	public Property save_;

	public const int GOBJTYPE_FUKIDASHI = 0;

	public const int GOBJTYPE_HUMAN = 1;

	public const int GOBJTYPE_MAPCHIP = 2;

	public const int GOBJTYPE_GAME = 3;

	public const int GOBJTYPE_COM = 4;

	public const int GOBJTYPE_SATISFACTION = 5;

	public const int GOBJTYPE_LANTERN = 6;

	public const int GOBJTYPE_CAMERA = 7;

	public const int GOBJTYPE_LODGING_NEXT = 8;

	public const int GOBJTYPEBITS_ALL = 65535;

	public const int GOBJP_TYPE = 0;

	public const int GOBJP_ID = 1;

	public const int GOBJP_DEPTH = 2;

	public const int GOBJP_SEB = 3;

	public const int GOBJP_FRAME = 4;

	public const int GOBJP_X = 5;

	public const int GOBJP_Y = 6;

	public const int GOBJP_DARK = 7;

	public const int GOBJP_LAYER = 8;

	public const int GOBJP_END = 9;

	public int gameObjectPoolIndex_;

	public int[][] gameObjectPool_;

	public const int WEEK_SECOND = 10800;

	public static int DAY_SECOND;

	public static int FRAME_TIME;

	public const int ONE_DAY_WEEK = 4;

	public const int POPUP_ASSIST = 0;

	public Vector popupMessages_;

	public static string[] talks_;

	public const int TALK_MSG_ID_GAMESTART = 0;

	public const int TALK_MSG_ID_ED_1 = 1;

	public const int TALK_MSG_ID_ED_HSCORE1 = 2;

	public const int TALK_MSG_ID_ED_HSCORE2 = 3;

	public const int TALK_MSG_ID_ED_2 = 4;

	public const int TALK_MSG_ID_CONST_V = 5;

	public const int TALK_MSG_ID_ITEMSTORE1 = 6;

	public const int TALK_MSG_ID_ITEMSTORE2 = 7;

	public const int TALK_MSG_ID_ITEMSTORE_HALFWAY = 8;

	public const int TALK_MSG_ID_ITEMSTORE_TENANT = 9;

	public const int TALK_MSG_ID_ITEMSTORE_ALLSELL = 10;

	public const int TALK_MSG_ID_ITEMSTORE_NONITEM = 11;

	public const int TALK_MSG_ID_RIVALAPPEAR1 = 12;

	public const int TALK_MSG_ID_RIVALAPPEAR2 = 13;

	public const int TALK_MSG_ID_RIVALESCAPE1 = 14;

	public const int TALK_MSG_ID_RIVALESCAPE2 = 15;

	public const int TALK_MSG_ID_DESTRUCT_TENANT = 16;

	public const int TALK_MSG_ID_INITSALE_SPRING = 17;

	public const int TALK_MSG_ID_INITSALE_SUMMER = 18;

	public const int TALK_MSG_ID_INITSALE_WINTER = 19;

	public const int TALK_MSG_ID_SALE_INITRESULT = 20;

	public const int TALK_MSG_ID_SALE_RESULT = 21;

	public const int TALK_MSG_ID_SALE_GOAL1 = 22;

	public const int TALK_MSG_ID_SALE_GOAL2 = 23;

	public const int TALK_MSG_ID_SALE_EVA = 24;

	public const int TALK_MSG_ID_SALE_AFTERRANKUP = 25;

	public const int TALK_MSG_ID_CLERK_EMPLOY_WIDE = 26;

	public const int TALK_MSG_ID_CLERK_EMPLOY_SP = 31;

	public const int TALK_MSG_ID_CLERK_SACK_WIDE = 36;

	public const int TALK_MSG_ID_CLERK_SACK_SP = 41;

	public const int TALK_MSG_ID_AREA_NOT_CONSTRUCT = 46;

	public const int TALK_MSG_ID_AREA_NOT_CONSTRUCT2 = 47;

	public const int TALK_MSG_ID_AREA_CONSTRUCT_START = 48;

	public const int TALK_MSG_ID_AREA_CONSTRUCT_FINISH = 49;

	public const int TALK_MSG_ID_INIT_BUILD = 50;

	public const int TALK_MSG_ID_INIT_BUILDSTEP = 51;

	public const int TALK_MSG_ID_INIT_BUILDEQUIP = 52;

	public const int TALK_MSG_ID_INIT_BUILDSPECIAL = 53;

	public const int TALK_MSG_ID_INIT_BUSINESS = 54;

	public const int TALK_MSG_ID_INIT_BUYTENANT = 55;

	public const int TALK_MSG_ID_INIT_BUYTENANT2 = 56;

	public const int TALK_MSG_ID_INIT_NONROUTE = 57;

	public const int TALK_MSG_ID_INIT_BADTIME = 58;

	public const int TALK_MSG_ID_INIT_RAIN = 59;

	public const int TALK_MSG_ID_INIT_FEVER = 60;

	public const int TALK_MSG_ID_INIT_REGULARBONUS = 61;

	public const int TALK_MSG_ID_INIT_CLERK = 62;

	public const int TALK_MSG_ID_PROJECT_PLEASE = 63;

	public const int TALK_MSG_ID_FEVER = 64;

	public const int TALK_MSG_ID_OPENMENU_SPECIAL = 65;

	public const int TALK_MSG_ID_INIT_CUSTOMER = 66;

	public const int TALK_MSG_ID_INIT_SALE = 67;

	public const int TALK_MSG_ID_SELECT_NONCLERK = 68;

	public const int TALK_MSG_ID_INIT_REQUEST = 69;

	public const int TALK_MSG_ID_NOTINVEST_RATE = 70;

	public const int TALK_MSG_ID_NOCLERK = 71;

	public const int TALK_MSG_ID_INIT_NOROUTETENANT = 72;

	public const int TALK_MSG_ID_INIT_SCCESSSERVICE = 73;

	public const int TALK_MSG_ID_INIT_UNDERG = 74;

	public const int TALK_MSG_ID_INIT_CLERK_SELECT = 75;

	public const int TALK_MSG_ID_RANKUP_PUMPKIN = 76;

	public const int TALK_MSG_ID_RANK_UNDERPRIRANK = 77;

	public const int TALK_MSG_ID_POSSIBLE_BUYTENANT = 78;

	public const int TALK_MSG_ID_POSSIBLE_SALE = 79;

	public const int TALK_MSG_ID_RANKTOP = 80;

	public const int TALK_MSG_ID_INIT_SDEVELOP = 81;

	public const int TALK_MSG_ID_INIT_FALSE_SERVICE = 82;

	public const int TALK_MSG_ID_INIT_SELECT_OUT = 83;

	public const int TALK_MSG_ID_INIT_LVUP = 84;

	public const int TALK_MSG_ID_INIT_ADVER = 85;

	public const int TALK_MSG_ID_INIT_FALSE_GOAL = 86;

	public const int TALK_MSG_ID_INIT_SPFLOOR_D = 87;

	public const int TALK_MSG_ID_INIT_RANKUP = 88;

	public const int TALK_MSG_ID_INIT_BONUS = 89;

	public const int TALK_MSG_ID_ADVER0 = 90;

	public const int TALK_MSG_ID_PRIRANKING = 91;

	public const int TALK_MSG_ID_BUYSCRET1 = 92;

	public const int TALK_MSG_ID_BUYSCRET2 = 93;

	public const int TALK_MSG_ID_INIT_TBONUS = 94;

	public const int TALK_MSG_ID_5STAR = 95;

	public const int TALK_MSG_ID_CAN_RANKUP = 96;

	public const int TALK_MSG_ID_ACHIEVE_5STAR = 97;

	public const int TALK_MSG_ID_REQUEST_BUS = 98;

	public const int TALK_MSG_ID_REQUEST_ESCALATOR = 99;

	public const int TALK_MSG_ID_REQUEST_ELEVATOR = 100;

	public const int TALK_MSG_ID_CANNOT_RANKUP = 101;

	public const int TALK_MSG_ID_GO_1STAR = 102;

	public const int TALK_MSG_ID_GO_1STAR2 = 103;

	public const int TALK_MSG_ID_NEXTSTAR1 = 104;

	public const int TALK_MSG_ID_NEXTSTAR2 = 105;

	public const int TALK_MSG_ID_REACH_RANK = 106;

	public const int TALK_MSG_ID_NOT_NEXTTERM = 107;

	public const int TALK_MSG_ID_REQUEST_STATION = 108;

	public const int TALK_MSG_ID_REQUEST_HELI = 109;

	public const int TALK_MSG_ID_REQUEST_KAIRO = 110;

	public const int TALK_MSG_ID_REQUEST_ABUFARA = 111;

	public const int TALK_MSG_ID_APPEAR_SOFUKO = 112;

	public const int TALK_MSG_ID_APPEAR_TINPAN = 113;

	public const int TALK_MSG_ID_RANKING = 114;

	public const int TALK_MSG_ID_INIT_RANKING = 115;

	public const int TALK_MSG_ID_5STAR_NOTITEM = 116;

	public const int TALK_MSG_ID_INIT_REGULAR = 117;

	public const int TALK_MSG_ID_INIT_SPFLOOR = 118;

	public const int TALK_MSG_ID_INIT_LOSTITEM = 119;

	public const int TALK_MSG_ID_RBONUS_FREND = 120;

	public const int TALK_MSG_ID_RBONUS_MONEY = 121;

	public const int TALK_MSG_ID_RBONUS_HEART = 122;

	public const int TALK_MSG_ID_RBONUS_TENANT = 123;

	public const int TALK_MSG_ID_TORANKUP_MIN = 124;

	public const int TALK_MSG_ID_CAN_CHANGECLERK = 125;

	public const int TALK_MSG_ID_INIT_CHANGE_T = 126;

	public int[] newsTypes_;

	public string[] newsTitles_;

	public string[] newsTexts_;

	public ChipModel[] chipModels_K_;

	public Service[] service;

	public SpFloor[] spFloor;

	public ApartArea[] apart_area;

	public ApartProject2[] apart_project2;

	public Customer[] customer;

	public CustomerComment[] customer_comment;

	public Clerk[] clerk;

	public RankingEva[] ranking_eva;

	public const int CHIP_KOUZI = 0;

	public const int CHIP_GROUND = 4;

	public const int CHIP_LOBBY_OUTCOUNTER = 38;

	public const int CHIP_LOBBY_CORRIDOR = 39;

	public const int CHIP_LOBBY_INCOUNTER = 40;

	public const int CHIP_LOBBY_ENTRANCE = 41;

	public ResourceManager resChip_;

	public ResourceManager resChipSeason_;

	public int loadedChipResourceSeason_;

	public const int EFF_SURPLUS = 0;

	public const int EFF_SATISFACTION_UP = 1;

	public const int EFF_SATISFACTION_DOWN = 2;

	public const int EFF_ESTIMATION_UP = 3;

	public const int EFF_ESTIMATION_DOWN = 4;

	public const int EFF_POPULARITY_UP = 5;

	public const int EFF_POPULARITY_DOWN = 6;

	public const int EFF_PR = 7;

	public const int EFF_LEVELUP = 8;

	public Vector effect_;

	public Vector destructSmokes_;

	public string[] manualTexts_;

	public int offSeason_;

	public int offYear_;

	public int offMonth_;

	public int offWeek_;

	public long offMoney_;

	public int offFloor_;

	public int offTenant_;

	private int[] tmpInt4_;

	public EventData[] eventData_;

	public int[] eventNum_;

	public Vector delayEvents_;

	public const int EVENT_NEWGAME = 0;

	public const int EVENT_NEWS1 = 1;

	public const int EVENT_GET_STAR1 = 2;

	public const int EVENT_GET_STAR2 = 3;

	public const int EVENT_GET_STAR3 = 4;

	public const int EVENT_GET_STAR4 = 5;

	public const int EVENT_GET_STAR5 = 6;

	public const int EVENT_INIT_SPFLOOR = 7;

	public const int EVENT_INIT_TINCOME_500OVER = 8;

	public const int EVENT_INIT_TINCOME_5000OVER = 9;

	public const int EVENT_CUSTOMER1000 = 10;

	public const int EVENT_BUILD_BUS = 11;

	public const int EVENT_BUILD_STATION = 12;

	public const int EVENT_BUILD_HELI = 13;

	public const int EVENT_LOST_ITEM = 14;

	public const int EVENT_FEVER = 15;

	public const int EVENT_INIT_BADBUSINESS = 16;

	public const int EVENT_INIT_QUALITY100 = 17;

	public const int EVENT_INIT_TOPIC200 = 18;

	public const int EVENT_INIT_REGI100 = 19;

	public const int EVENT_INIT_LV10TENANT = 20;

	public const int EVENT_BUILD_MOVIE = 21;

	public const int EVENT_BUILD_HOSPITAL = 22;

	public const int EVENT_BUILD_AQUARIUM = 23;

	public const int EVENT_BUILD_CAJINO = 24;

	public const int EVENT_BUILD_PURANETA = 25;

	public const int EVENT_BUILD_COVINI = 26;

	public const int EVENT_BUILD_SERVICECOUNTER = 27;

	public const int EVENT_REGULARNUM88 = 28;

	public const int EVENT_RANKING1 = 29;

	public string[] eventMsgs_;

	public const int CTASK_CHARA = 0;

	public const int CTASK_REPEATER = 1;

	public const int CTASK_WAIT = 2;

	public const int CTASK_END = 3;

	public static int currentSaveSlot_;

	public string[] characterSource_;

	public const int CHARA_MINAKO = 0;

	public const int CHARA_REPORTER = 1;

	public const int CHARA_WAITRESS = 2;

	public const int CHARA_ARCHITECT = 3;

	public const int CHARA_CUSTOMER_START = 4;

	public const int NODE_COST = 0;

	public const int NODE_HCOST = 1;

	public const int NODE_X = 2;

	public const int NODE_Y = 3;

	public const int NODE_FROM_X = 4;

	public const int NODE_FROM_Y = 5;

	public const int NODE_FIX = 6;

	public const int NODE_QUEUE = 7;

	public const int NODE_END = 8;

	public string platform_;

	public bool alphaRectPossible_;

	public int scriptArgCharacter_;

	public const int ENDING_YEAR = 15;

	public const int STAY_WEEK = 2;

	public static readonly int[][] DIRECT1;

	public static readonly int[][] DIRECT2;

	public static readonly int[][] DIRECT3;

	public const int EVA_MAX = 1000;

	public const int GAMEEVA_MAX = 100;

	public static int[] shareBlockTenantID;

	public static int FLG_FUKIDASHI_DISP;

	public static int FLG_NYUUKIN;

	public static int FLG_SHOPPING_BAG;

	public static int NUM_MOVESEARCH;

	public static long TIME_MOVESEARCH;

	public static int ROOPCNT_MOVESEARCH;

	public static string STEAM_DEV_URL;

	private const bool enableSaveLog = false;

	private const int SENDSTATE_WAIT = 0;

	private const int SENDSTATE_CONNECTING = 1;

	private int sendState_;

	private int[][] crossPoint2Tmp_;

	private int[] rotatePoint_tmp;

	private Image imgOutline1_;

	private Graphics graOutline1_;

	private Image imgOutline2_;

	private Graphics graOutline2_;

	private int[] drawCommand_tmp;

	private static Balloon tmpBalloon_;

	public const int FUKIDASHI_MANSITSU = 0;

	public const int FUKIDASHI_YOUKOSO = 1;

	public const int FUKIDASHI_YOROSIKU = 2;

	public const int FUKIDASHI_KIGAE = 3;

	public const int FUKIDASHI_KAEROU = 4;

	public const int FUKIDASHI_KANRYOU = 5;

	public const int FUKIDASHI_ONAKASUITA = 6;

	public const int FUKIDASHI_NODOKAWAITA = 7;

	public const int FUKIDASHI_MORECHAU = 8;

	public const int FUKIDASHI_TAIKUTSU = 9;

	public const int FUKIDASHI_UMAI = 10;

	public const int FUKIDASHI_FUTSUU = 11;

	public const int FUKIDASHI_MAZUI = 12;

	public const int FUKIDASHI_TANOSII = 13;

	public const int FUKIDASHI_TSUMARANAI = 14;

	public const int FUKIDASHI_EVALIATION = 15;

	public const int FUKIDASHI_MOOD_UP = 16;

	public const int FUKIDASHI_MOOD_DOWN = 17;

	public const int FUKIDASHI_IIYUDA = 18;

	public const int FUKIDASHI_FOO = 19;

	public const int FUKIDASHI_MOGUMOGU = 20;

	public const int FUKIDASHI_ATSUI = 21;

	public const int FUKIDASHI_SAMUI = 22;

	public const int FUKIDASHI_ATSUI2 = 23;

	public const int FUKIDASHI_SAMUI2 = 24;

	public const int FUKIDASHI_GOKURAKUDA = 25;

	public const int FUKIDASHI_TSURUTSURU = 26;

	public const int FUKIDASHI_TSUKARE_TORERU = 27;

	public const int FUKIDASHI_IYASARERU = 28;

	public const int FUKIDASHI_GENKINI_NATTA = 29;

	public const int FUKIDASHI_MANZOKU1 = 30;

	public const int FUKIDASHI_MANZOKU2 = 31;

	public const int FUKIDASHI_MANZOKU3 = 32;

	public const int FUKIDASHI_MANZOKU4 = 33;

	public const int FUKIDASHI_MANZOKU5 = 34;

	public const int FUKIDASHI_MANZOKU6 = 35;

	public const int FUKIDASHI_IIHUNNIKI = 36;

	public const int FUKIDASHI_OHURO_NAI = 37;

	public const int FUKIDASHI_SUTEKI = 38;

	public const int FUKIDASHI_MATA_KOYOU = 39;

	public const int FUKIDASHI_HAJIMEMASITE = 40;

	public const int FUKIDASHI_AAA = 41;

	public const int FUKIDASHI_UWA = 42;

	public const int FUKIDASHI_KYAA = 43;

	public const int FUKIDASHI_SINJIRARENAI = 44;

	public const int FUKIDASHI_END = 45;

	public static readonly bool[] FUKIDASHIWARNING;

	public static readonly string[] FUKIDASHITEXT;

	private int[] getEvenlyDivisionArea_tmp_;

	public const int STEP_X = 30;

	public const int STEP_Y = 15;

	public const int SIZE_W = 60;

	public const int SIZE_H = 29;

	private int[] drawPopupMessage_heights;

	private int[] draw_helpMessage_tmp1;

	public const int TROPHY_KAIROKUN = 0;

	public const int TROPHY_GAMECLEAR = 1;

	public const int TROPHY_FIVESTAR = 2;

	public const int TROPHY_COMBO25 = 3;

	public const int TROPHY_BESTMALL = 4;

	public const int TROPHY_FIRSTCOMBO = 5;

	public const int TROPHY_RANKMAX_3 = 6;

	public const int TROPHY_RANKMAX_1 = 7;

	public const int TROPHY_MANYFLOOR_15 = 8;

	public const int TROPHY_MANYFLOOR_5 = 9;

	public const int TROPHY_END = 10;

	public const int TROPHY_GET_NONE = 0;

	public const int TROPHY_GET_START = 1;

	public const int TROPHY_GET_ALREADY = 2;

	public static int[] trophyUnlocks_;

	private static Balloon balloon_ => null;

	public static AppData GetInstance()
	{
		return null;
	}

	private void Init()
	{
	}

	private string GetCgiUrl(int cgiId)
	{
		return null;
	}

	public byte[][] PhpDlFile(string dir, string file)
	{
		return null;
	}

	public byte[] CgiRegist(string cm, string r)
	{
		return null;
	}

	public string CgiRegistURL(string cm, string r)
	{
		return null;
	}

	public byte[] CgiRegistScore(string m, string s, string r)
	{
		return null;
	}

	public string CgiRegistScoreURL(string m, string s, string r)
	{
		return null;
	}

	public byte[] CgiGetScore(string m)
	{
		return null;
	}

	public string CgiGetScoreURL(string m)
	{
		return null;
	}

	public byte[] CgiRanking(string m, string r, string p)
	{
		return null;
	}

	public string CgiRankingURL(string m, string r, string p)
	{
		return null;
	}

	public static string MakeQuery(string query, string param)
	{
		return null;
	}

	public bool IsPushSoftLabel(int softlabel)
	{
		return false;
	}

	public bool IsPushSoftLabel(int softlabel, int key)
	{
		return false;
	}

	public static int Clamp(int val, int min, int max)
	{
		return 0;
	}

	public static float Clamp(float val, float min, float max)
	{
		return 0f;
	}

	public static long Clamp(long val, long min, long max)
	{
		return 0L;
	}

	public static int ClampMin(int val, int min)
	{
		return 0;
	}

	public static int ClampMax(int val, int max)
	{
		return 0;
	}

	public static long ClampMin(long val, long min)
	{
		return 0L;
	}

	public static long ClampMax(long val, long max)
	{
		return 0L;
	}

	public static int Max(int v1, int v2)
	{
		return 0;
	}

	public static int Min(int v1, int v2)
	{
		return 0;
	}

	public void InitSystemSaveData()
	{
	}

	public bool LoadSystem()
	{
		return false;
	}

	public void SaveSystem()
	{
	}

	public void NewGame(int slot, string name)
	{
	}

	public void SaveGame()
	{
	}

	public void SaveGame(bool auto)
	{
	}

	public void LoadGame(int slot)
	{
	}

	public void LoadGame(int slot, bool auto)
	{
	}

	public void DrawWindow(Graphics g, int GWidth, int GHeight, int GTop, string T_S)
	{
	}

	public void DrawWindow(Graphics g, int GWidth, int GHeight, int GTop, string T_S, int center)
	{
	}

	public void DrawBox(Graphics g, int BoxX1, int BoxY1, int BoxX2, int BoxY2)
	{
	}

	public void DrawBox(Graphics g, int BoxX1, int BoxY1, int BoxX2, int BoxY2, int head)
	{
	}

	public void DrawBox2(Graphics g, int BoxX1, int BoxY1, int BoxX2, int BoxY2, int head)
	{
	}

	public void DrawArcRect(Graphics g, int x, int y, int w, int h, int r)
	{
	}

	public void FillArcRect(Graphics g, int x, int y, int w, int h, int r)
	{
	}

	public void DrawFillArcRect(Graphics g, int x, int y, int w, int h, int r, int r0, int g0, int b0, int r1, int g1, int b1)
	{
	}

	public void Draw3DBox(Graphics g, int offset_x, int offset_y, int width, int height, int[][] colors)
	{
	}

	public bool IsTopForm(FormBase formBase)
	{
		return false;
	}

	public int DrawSeb(Graphics g, int x, int y, Seb seb, Image[] imgs, int frame, int w1000, int h1000)
	{
		return 0;
	}

	public int DrawSeb(Graphics g, int x, int y, Seb seb, Image[] imgs, int frame, int w1000, int h1000, int maxWidth, int maxHeight)
	{
		return 0;
	}

	public void DrawSeb(Graphics g, int x, int y, Seb seb, Image[] imgs, int frame, int ucnt)
	{
	}

	public void DrawSebV(Graphics g, int x, int y, Seb seb, Image[] imgs, int frame, int vcnt)
	{
	}

	public void DrawSeb(Graphics g, int x, int y, Seb seb, Image img, int frame)
	{
	}

	public void DrawSebScale(Graphics g, int x, int y, Seb seb, int frame, int width, int height)
	{
	}

	public void DrawSebScale(Graphics g, int x, int y, int width, int height, Seb seb, int frame, int sx, int sy, int swidth, int sheight)
	{
	}

	public void DrawSebReverse(Graphics g, int x, int y, Seb seb, int frame, Image[] imgs)
	{
	}

	public static bool ColRect(int x, int y, int left, int top, int right, int bottom)
	{
		return false;
	}

	public static bool ColRect(int left1, int top1, int right1, int bottom1, int left2, int top2, int right2, int bottom2)
	{
		return false;
	}

	public static bool ColRect(float left1, float top1, float right1, float bottom1, float left2, float top2, float right2, float bottom2)
	{
		return false;
	}

	public static string CommaSeparate(long value)
	{
		return null;
	}

	public int[] GetBRectSeb(Seb seb, int x, int y, int frame)
	{
		return null;
	}

	public void DrawVerticalScroll(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange)
	{
	}

	public void DrawVerticalScroll2(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange)
	{
	}

	public void DrawVerticalScroll3(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange)
	{
	}

	public void DrawVerticalScrollPage(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange)
	{
	}

	public void DrawVerticalScrollPage2(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange)
	{
	}

	public void DrawHorizontallScroll(Graphics g, int x, int y, int w, int h, int value, int maximum, int largeChange)
	{
	}

	public void DrawNumImage(Graphics g, int seb, string header, long value, string footer, int x, int y)
	{
	}

	public void DrawNumImage(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding)
	{
	}

	public void DrawNumImage(Graphics g, int seb, long value, int x, int y, int padding, int anchor)
	{
	}

	public void DrawNumImage(Graphics g, int seb, long value, int x, int y)
	{
	}

	public void DrawNumImage(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding, int anchor)
	{
	}

	public void DrawNumImageCoommnma(Graphics g, int seb, long value, int x, int y, int padding, int anchor)
	{
	}

	public void DrawMoneyNumImage(Graphics g, int seb, string header, long value, string footer, int x, int y)
	{
	}

	public void DrawMoneyNumImage(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding)
	{
	}

	public void DrawMoneyNumImage(Graphics g, int seb, long value, int x, int y, int padding, int anchor)
	{
	}

	public void DrawMoneyNumImage(Graphics g, int seb, long value, int x, int y)
	{
	}

	public void DrawMoneyNumImage(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding, int anchor)
	{
	}

	public void DrawMoneyNumImageG(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding, int anchor)
	{
	}

	public void DrawMoneyNumImageCoommnma(Graphics g, int seb, long value, int x, int y, int padding, int anchor)
	{
	}

	public void DrawMoneyNumImage2(Graphics g, int seb, string header, long value, string footer, int x, int y)
	{
	}

	public void DrawMoneyNumImage2(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding)
	{
	}

	public void DrawMoneyNumImage2(Graphics g, int seb, long value, int x, int y, int padding, int anchor)
	{
	}

	public void DrawMoneyNumImage2(Graphics g, int seb, long value, int x, int y)
	{
	}

	public void DrawMoneyNumImage2(Graphics g, int seb, string header, long value, string footer, int x, int y, int padding, int anchor)
	{
	}

	public SubForm ExecuteScript(int[] scr, bool popup, string arg)
	{
		return null;
	}

	public SubForm ExecuteScript(int[] scr, bool popup, string arg, FormBase sub_form)
	{
		return null;
	}

	public int GetDelayId(int[][] script)
	{
		return 0;
	}

	public int[][] GetDelayScript(int delayId)
	{
		return null;
	}

	public bool Push(FormBase form)
	{
		return false;
	}

	public void AddEffectSurplus(int x, int y, int value)
	{
	}

	public void AddEffectSatisfactionUp(int x, int y, int value)
	{
	}

	public void AddEffectSatisfactionDown(int x, int y, int value)
	{
	}

	public void AddEffectEstimationUp(int value, int chara)
	{
	}

	public void AddEffectEstimationDown(int value, int chara)
	{
	}

	public void AddEffectPopularityUp(int value, int chara)
	{
	}

	public void AddEffectPopularityDown(int value, int chara)
	{
	}

	public void AddEffectPRPoint(int x, int y, int value)
	{
	}

	public void AddEffectLevelUp(int x, int y, int wait, int chara)
	{
	}

	public void DrawEffect(Graphics g, int camX, int camY)
	{
	}

	public int GetSeason(int month)
	{
		return 0;
	}

	public int[] IntegerVectorToIntAry(Vector ary)
	{
		return null;
	}

	public void PlayBgm(int bgm)
	{
	}

	public void StopAllBgm()
	{
	}

	public void StopSe(int se)
	{
	}

	public void PlaySe(int se)
	{
	}

	public void PriPlaySe_downBgmVolume(int se)
	{
	}

	public void SetBgmVolume()
	{
	}

	public void PlayJingle(int jingle)
	{
	}

	public string GetHttpErrorText()
	{
		return null;
	}

	public bool ShowNews(int id, string arg)
	{
		return false;
	}

	public long GetHighScore()
	{
		return 0L;
	}

	public void SetHighScore(long score)
	{
	}

	public long GetNetHighScore()
	{
		return 0L;
	}

	public void SetNetHighScore(long score)
	{
	}

	public long GetMoneyHighScore()
	{
		return 0L;
	}

	public void SetMoneyHighScore(long score)
	{
	}

	public long GettMoneyNetHighScore()
	{
		return 0L;
	}

	public void SettMoneyNetHighScore(long score)
	{
	}

	public void SendSaveData(string text)
	{
	}

	public void SendSaveData(string text, bool scratchpad)
	{
	}

	public void SendSaveData(string text, int type)
	{
	}

	private void Draw()
	{
	}

	private void Post(string url, string file, string index, string date, byte[] data)
	{
	}

	public int DateToTime(int year, int month, int day, int time)
	{
		return 0;
	}

	public int DateToDays(int year, int month, int week)
	{
		return 0;
	}

	public void DrawIcon(Graphics g, int x, int y, int icon)
	{
	}

	public long AddMoney(int add)
	{
		return 0L;
	}

	public long SubMoney(int sub)
	{
		return 0L;
	}

	public int[] RotatePoint(int x, int y, int dir)
	{
		return null;
	}

	public void UpdatePassiveScript()
	{
	}

	public bool RemoveAllMenuForms()
	{
		return false;
	}

	public int[] GetNearNeighborNode(int[][][] nodeMap, int x, int y)
	{
		return null;
	}

	public int[] GetNearNeighborNode(int[][][] nodeMap, int x, int y, int[] priority)
	{
		return null;
	}

	public int[][] GetNeighborNodeList(int[][][] nodeMap, int x, int y)
	{
		return null;
	}

	public static int[] GetIntArray(string src)
	{
		return null;
	}

	public static int[][] GetInt2Array(string src)
	{
		return null;
	}

	public byte[] BooleanToByteArray(bool[] bools)
	{
		return null;
	}

	public bool[] SbyteArrayToBoolean(byte[] src)
	{
		return null;
	}

	public bool[] SbyteArrayToBoolean(byte[] src, int size)
	{
		return null;
	}

	public byte[] IntToByteArray(int[] ints)
	{
		return null;
	}

	public int[] SbyteArrayToInt(byte[] src)
	{
		return null;
	}

	public int[] SbyteArrayToInt(byte[] src, int size)
	{
		return null;
	}

	public int FrameToMilliSecond(int frame)
	{
		return 0;
	}

	public void DrawOutline(Graphics g, int x, int y, Seb seb, Image[] images, int frame, int lineWidth, int color)
	{
	}

	public void DrawOutline(Graphics g, int x, int y, Image img, int u, int v, int w, int h, int lineWidth, int color)
	{
	}

	public static bool CheckTimeZone(int time, int start, int end)
	{
		return false;
	}

	public void ResourceReDownload()
	{
	}

	public void DrawMeter(Graphics g, int x, int y, int value, int max, int scaleNum, bool reverse, int anchor)
	{
	}

	public void DrawMeter(Graphics g, int x, int y, int value, int max, int scaleNum, bool reverse, int anchor, int height)
	{
	}

	public int GetAllStock(int itemId)
	{
		return 0;
	}

	public int GetStockTotal(int[] stock)
	{
		return 0;
	}

	public static int SearchInteger(int[] array, int key)
	{
		return 0;
	}

	public int[] DrawCommand(Graphics g, string str, int x, int y, int anchor, bool active, int margin, bool cursor, FormBase form, int frame)
	{
		return null;
	}

	public int[] DrawCommand(Graphics g, string str, int x, int y, int w, int anchor, bool active, bool cursor, FormBase form, int frame)
	{
		return null;
	}

	public int GetMainBGM()
	{
		return 0;
	}

	public static void Gc()
	{
	}

	public static void Sort(int[] list)
	{
	}

	public int GetTime()
	{
		return 0;
	}

	public int GetTime(int week, int time)
	{
		return 0;
	}

	public bool CheckNightTime()
	{
		return false;
	}

	public bool CheckNightTime(int time)
	{
		return false;
	}

	public bool CheckSleepingTime(int time)
	{
		return false;
	}

	internal bool CheckPointInPolygon(int x, int y, int[][] aPoint)
	{
		return false;
	}

	public static void DrawString_NoneFukidasi(Graphics g, string str, float dx, float dy, float dw, float dh, int color, int anchor)
	{
	}

	public static void DrawStringBold_NoneFukidasi(Graphics g, string str, int dx, int dy, int dw, int color1, int color2, int fontSize, int anchor, int outlineQuality = -1, float outlineWidth = float.NaN)
	{
	}

	public void DrawFukidashiWindow(Graphics g, int x, int y, int width)
	{
	}

	public void DrawFukidashi(Graphics g, int x, int y, int fukidashiId)
	{
	}

	public int[] GetEvenlyDivisionArea(int left, int right, int padding, int index, int max)
	{
		return null;
	}

	public void BubbleSort(int[] list)
	{
	}

	public int GetIsometricX(int xi, int yi)
	{
		return 0;
	}

	public int GetIsometricY(int xi, int yi)
	{
		return 0;
	}

	public BaseData[] AdjustDataList(BaseData[] list, int id)
	{
		return null;
	}

	public void SerializeScripts(OutputStream os, Vector scripts)
	{
	}

	public Vector DeserializeScripts(InputStream stream)
	{
		return null;
	}

	public bool CheckAlreadyEvent(int id)
	{
		return false;
	}

	public SubForm ExecuteScript(int[][] script, bool popup, string arg, int line)
	{
		return null;
	}

	public SubForm ExecuteScript(int[][] script, bool popup, string arg, int line, FormBase sub_form)
	{
		return null;
	}

	public bool CheckTermScript(int[][] terms)
	{
		return false;
	}

	public bool CheckTermScript(int[] terms)
	{
		return false;
	}

	public SubForm ExecEvent(int id, string arg)
	{
		return null;
	}

	public SubForm ExecEvent(int id, string arg, FormBase sub_form)
	{
		return null;
	}

	public void ClearPopupMessages()
	{
	}

	public void AddPopupMessage(int id, string msg)
	{
	}

	public void AddPopupMessage(int id, string msg, int wait)
	{
	}

	public void AddPopupMessage(int id, string msg, int start, int length)
	{
	}

	public void AddPopupMessage(int id, string msg, int key, int start, int length, int wait)
	{
	}

	public void RemovePopupMessages(int key)
	{
	}

	public void DrawPopupMessage(Graphics g, int bottom)
	{
	}

	public void UpdatePopupMessage()
	{
	}

	public object[] GetPopupMessage(int key)
	{
		return null;
	}

	public void Draw_helpMessage(Graphics g, string text, int y)
	{
	}

	public void DrawMoneyIcon(Graphics g, int x, int y)
	{
	}

	public void DrawMoneyIconG(Graphics g, int x, int y)
	{
	}

	public static void DrawRect3(Graphics g, float x, float y, float width, float height)
	{
	}

	public bool PopAllSubForms()
	{
		return false;
	}

	public static bool IsSystemLanguage()
	{
		return false;
	}

	public static void JumpFullVersion()
	{
	}

	public bool IsRegularKairoFamily()
	{
		return false;
	}
}
