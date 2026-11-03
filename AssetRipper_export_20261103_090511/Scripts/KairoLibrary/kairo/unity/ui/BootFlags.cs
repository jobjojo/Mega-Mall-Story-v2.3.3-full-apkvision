using System;

namespace kairo.unity.ui;

[Flags]
public enum BootFlags
{
	Default = 1,
	Trial = 2,
	AdMob = 4,
	OpenAppliPurchasing = 8,
	OpenPointPurchasing = 0x10,
	BackToRoot = 0x20,
	OpenMonthlyPurchasing = 0x40
}
