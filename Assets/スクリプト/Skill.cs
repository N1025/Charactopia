using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Skill", menuName = "CreateSkill")]
public class Skill : ScriptableObject
{
    public enum KindOfSkill
    {
        パッシブ,
        オート,
        アクション

    }
    public enum KindOfRes
    {
        コウゲキ,
        カイフク,
        シエン,
        なし

    }
    public enum KindOfDamage
    {
        ブツリ,
        セイシン,
        なし

    }
    public enum Tage
    {
        自分,
        敵単,
        味方単,
        自分以外味方単,
        敵全,
        味方全,
        自分以外味方全,
        自分以外全,
        全体,
        敵乱,
        味方乱,
        自分以外味方乱,
        自分以外乱,
        全体乱,
        属性



    }
    //技の属性
    [SerializeField]
    private Material zokusei;

    //技の種類
    [SerializeField]
    private KindOfSkill kindOfSkill;
    
    //技の種類2
    [SerializeField]
    private KindOfRes kindOfRes;

    //ダメージの参照
    [SerializeField]
    private KindOfDamage kindOfDamage;

    //技の種類
    [SerializeField]
    private Tage tage;

    //技のアイコン
    [SerializeField]
    private Sprite icon;

    //技の名前
    [SerializeField]
    private string sName;

    [SerializeField]
    private　float pow;
    [SerializeField]
    private int cp;
    


    //技の情報
    [SerializeField]
    private string information;

    public Material Getzokusei() { return zokusei; }
    public KindOfSkill GetKindOfSkill() { return kindOfSkill; }
    public KindOfRes GetKindOfRes() { return kindOfRes; }
    public KindOfDamage GetKindOfDamage() { return kindOfDamage; }
    public Tage Gettage() { return tage; }
    public Sprite Geticon() { return icon; }
    public string GetsName() { return sName; }
    public float Getpow() { return pow; }
    public int Getcp() { return cp; }
    
    public string Getinf() { return information; }
}

