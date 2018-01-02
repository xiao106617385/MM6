﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  物品基类
 */ 

public class BaseItem
{
    /// <summary>
    /// ID
    /// </summary>
    public int ID;
    /// <summary>
    /// 名称
    /// </summary>
    public string Name;
    /// <summary>
    /// 描述
    /// </summary>
    public string Description;
    /// <summary>
    /// 最大堆叠数量
    /// </summary>
    public int MaxNumber;
    /// <summary>
    /// 物品功效
    /// </summary>
    public List<GeneralData<ItemEffectEnum, int>> ItemEffects;
}