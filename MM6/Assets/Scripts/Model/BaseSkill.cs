using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  技能基类
 */

public class BaseSkill
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
    /// 花费
    /// </summary>
    public int Cost;
    /// <summary>
    /// 技能功效
    /// </summary>
    public List<GeneralData<SkillEffect, int>> SkillEffects;
}