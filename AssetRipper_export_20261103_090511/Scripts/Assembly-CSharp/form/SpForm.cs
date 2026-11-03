using System;
using java.lang;
using java.util;
using kairo.unity.ui;

namespace form;

public class SpForm : MyFormBase, JRunnable
{
	private int frame_;

	private int page_;

	private string text_;

	private string date_;

	private bool succeed_;

	private const int STATE_MAIN = 0;

	private const int STATE_SEND = 1;

	private const int STATE_RECV = 2;

	private int state_;

	private static readonly int[][] softLabels_;

	private Vector commands_;

	private int select_;

	private int send_;

	private string recvDataId_;

	private JThread th_;

	private Vector task_;

	private byte[] recv_;

	private int taskMax_;

	public override string ToString()
	{
		return null;
	}

	public SpForm()
		: base(0)
	{
	}

	public SpForm(Exception th)
		: base(0)
	{
	}

	public override bool Init()
	{
		return false;
	}

	internal void AddCommand(int id, string str)
	{
	}

	public override bool Update()
	{
		return false;
	}

	public override void Draw(Graphics g)
	{
	}

	private void _draw(Graphics g)
	{
	}

	public override bool Resume()
	{
		return false;
	}

	public override bool Finish()
	{
		return false;
	}

	private void ChangeState(int state)
	{
	}

	private void SetSoftLabel()
	{
	}

	internal void ShowDialog(string text, string buttons)
	{
	}

	public void Run()
	{
	}

	internal void MakeSendDataTask()
	{
	}

	public override int GetTouchValue(int type, int index)
	{
		return 0;
	}

	public override void SetTouchValue(int type, int value)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
