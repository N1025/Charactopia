using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Player", menuName = "CreatePlayer")]
public class Player : ScriptableObject
{


    //敵の属性
    [SerializeField]
    private Material zokusei;

    //敵のアイコン
    [SerializeField]
    private Sprite icon;

    //敵の名前
    [SerializeField]
    private string cName;

    [SerializeField]
    private int hp;
    [SerializeField]
    private int atk;
    [SerializeField]
    private int inc;
    [SerializeField]
    private int def;
    [SerializeField]
    private int mtl;
    [SerializeField]
    private int spd;
    [SerializeField]
    private Skill skilla;
    [SerializeField]
    private Skill skillb;
    [SerializeField]
    private Skill skillc;
    [SerializeField]
    private Skill skilld;
    [SerializeField]
    private Skill skille;
    [SerializeField]
    private Skill skillf;
    [SerializeField]
    private Skill skillg;
    [SerializeField]
    private int act=1;

    //敵の情報
    [SerializeField]
    private string information;

    public Material Getzokusei() { return zokusei; }
    public Sprite Geticon() { return icon; }
    public string GetcName() { return cName; }
    public int Gethp() { return hp; }
    public int Getatk() { return atk; }
    public int Getinc() { return inc; }
    public int Getdef() { return def; }
    public int Getmtl() { return mtl; }
    public int Getspd() { return spd; }
    public Skill GetSkilla() { return skilla; }
    public Skill GetSkillb() { return skillb; }
    public Skill GetSkillc() { return skillc; }
    public Skill GetSkilld() { return skilld; }
    public Skill GetSkille() { return skille; }
    public Skill GetSkillf() { return skillf; }
    public Skill GetSkillg() { return skillg; }
    public int Getact() { return act; }
}
