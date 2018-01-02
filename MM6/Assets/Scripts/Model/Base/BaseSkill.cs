using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  技能基类
 */
namespace X.Model
{
    /// <summary>
    /// 技能
    /// </summary>
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
        /// 技能施放单位
        /// </summary>
        public BaseUnit Caster;
        /// <summary>
        /// 技能功效
        /// </summary>
        public List<BaseEffect> Effects;
    }

    /// <summary>
    /// 技能功效
    /// </summary>

    public class BaseEffect
    {
        /// <summary>
        /// 功效
        /// </summary>
        public SkillEffectEnum Effect;
        /// <summary>
        /// 持续时间类型
        /// </summary>
        public EffectKeepTypeEnum KeepType;
        /// <summary>
        /// 持续时间
        /// </summary>
        public float KeepTime;
        /// <summary>
        /// 功效具体数值
        /// </summary>
        public float EffectVal;
    }
}