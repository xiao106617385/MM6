using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 *  单位基类
 *  单位固有属性
 */ 

public class BaseUnit
{
    public int ID;
    public string Name;
    public int MaxHP;
    public int MaxMP;
    public int HP;
    public int MP;


    public Vector3 MyPosition;
    public List<BaseItem> MyGoods;
    public List<BaseUnit> MyEnemyList;
    public List<BaseUnit> MyFriendList;
}