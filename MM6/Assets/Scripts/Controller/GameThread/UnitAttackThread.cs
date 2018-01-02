using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

/*
 *  游戏中单位攻击检测线程
 */ 
public class UnitAttackThread
{
    Thread unitCheckThread = null;
    bool isWork = false;
    static object locker = new object();

    public void Start()
    {
        if (GeneralDelegate.Instance.unitCheckMethod == null)
            return;
        if (unitCheckThread != null)
        {
            isWork = false;
            Thread.Sleep(5);
            try { unitCheckThread.Abort(); }
            catch { unitCheckThread.Resume(); }
            finally { unitCheckThread = null; }
        }
        isWork = true;
        unitCheckThread = new Thread(new ThreadStart(CheckMethod));
        unitCheckThread.Priority = System.Threading.ThreadPriority.Normal;
        unitCheckThread.IsBackground = true;
        unitCheckThread.Start();
    }

    void CheckMethod()
    {
        while (isWork)
        {
            lock (locker)
            {
                GeneralDelegate.Instance.unitCheckMethod();
            }
            Thread.Sleep(5);
        }
    }

    public void Stop()
    {
        if (unitCheckThread != null)
        {
            isWork = false;
            Thread.Sleep(5);
            try { unitCheckThread.Abort(); }
            catch { unitCheckThread.Resume(); }
            finally { unitCheckThread = null; }
        }
        GeneralDelegate.Instance.unitCheckMethod = null;
    }
}