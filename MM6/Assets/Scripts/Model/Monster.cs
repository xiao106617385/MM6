using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  怪物
 */ 

namespace X.Model
{
    public class Monster : BaseUnit
    {
        /// <summary>
        /// 技能列表
        /// </summary>
        public List<BaseSkill> SkillList;
        /// <summary>
        /// 掉落物品列表
        /// </summary>
        public List<BaseItem> DropoutItemList;

    }
}
