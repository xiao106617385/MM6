using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using X.Model;

public class Test : MonoBehaviour
{
    BaseUnit entity;
    List<BaseUnit> entityList = new List<BaseUnit>();
    UnitAttackThread attackThread;
    float GameTime = 0f;
    // Use this for initialization
    void Start ()
    {
        entityList.Add(new BaseUnit
        {
            ID =9001,Name="男主角", LastAttackTime = Time.time, AttackCDTime = 2, AttackCD = false
        });
        GeneralDelegate.Instance.unitCheckMethod = UnitCheck;
        attackThread = new UnitAttackThread();
        attackThread.Start();

    }

    private void FixedUpdate()
    {
        GameTime = Time.time;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            entityList[0].Attack();
            Debug.Log("捅了一下");
        }
	}

    void UnitCheck()
    {
        for (int i = 0; i < entityList.Count; i++)
        {
            entity = entityList[i];
            if (entity.AttackCD)
                continue;
            entity.AttackCD = GameTime - entity.LastAttackTime >= entity.AttackCDTime;
            if (entity.AttackCD)
            {
                Debug.Log(entity.Name + " 亮了");
            }
        }
    }

    private void OnDestroy()
    {
        if (attackThread != null)
            attackThread.Stop();
    }

    private void OnApplicationQuit()
    {
        if (attackThread != null)
            attackThread.Stop();
    }
}
