using System;
using System.Runtime.InteropServices;
using System.Text;

public class MP3Player
{
    private string _command;
    private bool isOpen;

    public void Close()
    {
        this._command = "close MediaFile";
        mciSendString(this._command, null, 0, IntPtr.Zero);
        this.isOpen = false;
    }

    [DllImport("winmm.dll")]
    private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
    public void Open(string sFileName)
    {
        this._command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
        mciSendString(this._command, null, 0, IntPtr.Zero);
        this.isOpen = true;
    }

    public void Play(bool loop)
    {
        if (this.isOpen)
        {
            this._command = "play MediaFile";
            if (loop)
            {
                this._command = this._command + " REPEAT";
            }
            mciSendString(this._command, null, 0, IntPtr.Zero);
        }
    }
}

