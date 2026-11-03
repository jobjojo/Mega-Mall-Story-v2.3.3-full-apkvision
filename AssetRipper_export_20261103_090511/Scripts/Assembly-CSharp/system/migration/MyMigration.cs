using system.migration.ui;

namespace system.migration;

public class MyMigration : Migration
{
	private MyMigration()
	{
	}

	public new static MyMigration GetInstance()
	{
		return null;
	}

	public override void Init()
	{
	}
}
