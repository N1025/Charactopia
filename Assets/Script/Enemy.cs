using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Enemy", menuName = "CreateEnemy")]
public class Enemy : ScriptableObject
{
    

    //敵の属性
    [SerializeField]
    private Material zokusei;

    //敵のアイコン
    [SerializeField]
    private Sprite icon;

    //敵の名前
    [SerializeField]
    private string enemyName;

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
    private int ai;


    //敵の情報
    [SerializeField]
    private string information;

    public Material Getzokusei() { return zokusei; }
    public Sprite Geticon() { return icon; }
    public string GetEnemyName() { return enemyName; }
    public int Gethp() { return hp; }
    public int Getatk() { return atk; }
    public int Getinc() { return inc; }
    public int Getdef() { return def; }
    public int Getmtl() { return mtl; }
    public int Getspd() { return spd; }
    public int Getai() { return ai; }
}