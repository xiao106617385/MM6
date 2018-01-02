using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using X.Model;

public class GeneralDelegate
{
    static GeneralDelegate _Instance;
    public static GeneralDelegate Instance
    {
        get
        {
            if (_Instance == null)
                _Instance = new GeneralDelegate();
            return _Instance;
        }
    }
    //单位检测代理
    public delegate void UnitCheckMethod();
    public UnitCheckMethod unitCheckMethod;

    //单位buff/debuff检测代理
    public delegate void EffectsCheckMethod();
    public EffectsCheckMethod effectsCheckMethod;
}

public class SceneDataManager
{
    static SceneDataManager _Instance;
    public static SceneDataManager Instance
    {
        get
        {
            if (_Instance == null)
                _Instance = new SceneDataManager();
            return _Instance;
        }
    }

    //当前场景中的所有单位
    public List<BaseUnit> UnitDataList = new List<BaseUnit>();
}