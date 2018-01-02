using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 *  单位基类
 */
namespace X.Model
{
    public class BaseUnit
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name;

        #region 单位固有属性

        /// <summary>
        /// 阵营
        /// </summary>
        public GroupTypeEnum Group;
        /// <summary>
        /// 种族
        /// </summary>
        public RaceTypeEnum Race;
        /// <summary>
        /// 职业
        /// </summary>
        public ProfessionEnum Profession;
        /// <summary>
        /// 力量
        /// </summary>
        public int Might;
        /// <summary>
        /// 智力
        /// </summary>
        public int Intellect;
        /// <summary>
        /// 个性
        /// </summary>
        public int Personality;
        /// <summary>
        /// 耐力
        /// </summary>
        public int Endurance;
        /// <summary>
        /// 精确
        /// </summary>
        public int Accuracy;
        /// <summary>
        /// 速度
        /// </summary>
        public int Speed;
        /// <summary>
        /// 最大血量
        /// </summary>
        public int MaxHP;
        /// <summary>
        /// 最大蓝量
        /// </summary>
        public int MaxMP;
        #endregion

        /// <summary>
        /// 战斗中的目标单位
        /// </summary>
        public BaseUnit FightTargetUnit;
        /// <summary>
        /// 当前敌人列表
        /// </summary>
        public List<BaseUnit> MyEnemyList;
        /// <summary>
        /// 当前友军列表
        /// </summary>
        public List<BaseUnit> MyFriendList;
        /// <summary>
        /// 拥有的物品
        /// </summary>
        public List<BaseItem> MyGoods;
        /// <summary>
        /// 是否需要普通检测
        /// </summary>
        public bool NormalkCheck;


        #region 单位即时属性

        /// <summary>
        /// 当前血量
        /// </summary>
        public int HP;
        /// <summary>
        /// 当前蓝量
        /// </summary>
        public int MP;
        /// <summary>
        /// 当前坐标
        /// </summary>
        public Vector3 MyPosition;
        /// <summary>
        /// 最后一次攻击时间
        /// </summary>
        public float LastAttackTime;
        /// <summary>
        /// 攻击CD时间
        /// </summary>
        public float AttackCDTime;
        /// <summary>
        /// 攻击CD
        /// </summary>
        public bool AttackCD;
        /// <summary>
        /// 预备技能
        /// </summary>
        public BaseSkill ReadSkill;
        /// <summary>
        /// 攻击CD的修正时间
        /// </summary>
        public float Correct_AttackTime;
        #endregion

        public void Attack()
        {
            AttackCD = false;
            LastAttackTime = Time.time;
        }
    }
}