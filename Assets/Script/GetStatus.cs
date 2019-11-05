using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;

public class GetStatus : MonoBehaviour
{
    [SerializeField]
    private EnemyDataBase enemyDataBase;
    [SerializeField]
    private PlayerDataBase playerDataBase;
    private GameObject e;
    private GameObject p;
    private SpriteRenderer icon;
    private Image zokusei;
    private Slider hpmax;
    private Text text;
    private Material ezokusei1;
    private Sprite eicon1;
    private string eName1;
    private int ehp1;
    private int eatk1;
    private int einc1;
    private int edef1;
    private int emtl1;
    private int espd1;
    private int eai1;
    private Material ezokusei2;
    private Sprite eicon2;
    private string eName2;
    private int ehp2;
    private int eatk2;
    private int einc2;
    private int edef2;
    private int emtl2;
    private int espd2;
    private int eai2;
    private Material ezokusei3;
    private Sprite eicon3;
    private string eName3;
    private int ehp3;
    private int eatk3;
    private int einc3;
    private int edef3;
    private int emtl3;
    private int espd3;
    private int eai3;
    private Material ezokusei4;
    private Sprite eicon4;
    private string eName4;
    private int ehp4;
    private int eatk4;
    private int einc4;
    private int edef4;
    private int emtl4;
    private int espd4;
    private int eai4;
    private Material pzokusei1;
    private Sprite picon1;
    private string pName1;
    private int php1;
    private int patk1;
    private int pinc1;
    private int pdef1;
    private int pmtl1;
    private int pspd1;
    private Skill pskill11;
    private Skill pskill12;
    private Skill pskill13;
    private Skill pskill14;
    private Skill pskill15;
    private Skill pskill16;
    private Skill pskill17;
    private int pact1;
    private Material pzokusei2;
    private Sprite picon2;
    private string pName2;
    private int php2;
    private int patk2;
    private int pinc2;
    private int pdef2;
    private int pmtl2;
    private int pspd2;
    private Skill pskill21;
    private Skill pskill22;
    private Skill pskill23;
    private Skill pskill24;
    private Skill pskill25;
    private Skill pskill26;
    private Skill pskill27;
    private int pact2;
    private Material pzokusei3;
    private Sprite picon3;
    private string pName3;
    private int php3;
    private int patk3;
    private int pinc3;
    private int pdef3;
    private int pmtl3;
    private int pspd3;
    private Skill pskill31;
    private Skill pskill32;
    private Skill pskill33;
    private Skill pskill34;
    private Skill pskill35;
    private Skill pskill36;
    private Skill pskill37;
    private int pact3;
    private Material pzokusei4;
    private Sprite picon4;
    private string pName4;
    private int php4;
    private int patk4;
    private int pinc4;
    private int pdef4;
    private int pmtl4;
    private int pspd4;
    private Skill pskill41;
    private Skill pskill42;
    private Skill pskill43;
    private Skill pskill44;
    private Skill pskill45;
    private Skill pskill46;
    private Skill pskill47;
    private int pact4;
    [SerializeField]
    private int kazu;
    [SerializeField]
    private string enemyName1;
    [SerializeField]
    private string enemyName2;
    [SerializeField]
    private string enemyName3;
    [SerializeField]
    private string enemyName4;
    //
    [SerializeField]
    private string cName1;
    
    public void Start()
    {
        if (kazu == 1)
        {
            for (int num = 2; num <= 4; num++)
            {
                e = GameObject.Find("Enemy" + num);
                GameObject.Destroy(e);
            }
        }
        else if (kazu == 2)
        {
            for (int num = 3; num <= 4; num++)
            {
                e = GameObject.Find("Enemy" + num);
                GameObject.Destroy(e);
            }
            GameObject.Find("Enemy1").gameObject.transform.Translate(-2f, 0f, 0f);
            GameObject.Find("Enemy2").gameObject.transform.Translate(2f, 0f, 0f);
        }
        else if (kazu == 3)
        {
            e = GameObject.Find("Enemy4");
            GameObject.Destroy(e);
            GameObject.Find("Enemy1").gameObject.transform.Translate(-4, 0, 0);
            GameObject.Find("Enemy3").gameObject.transform.Translate(4, 0, 0);
        }
        else if (kazu == 4)
        {
            GameObject.Find("Enemy1").gameObject.transform.Translate(-6, 0, 0);
            GameObject.Find("Enemy2").gameObject.transform.Translate(-2, 0, 0);
            GameObject.Find("Enemy3").gameObject.transform.Translate(2, 0, 0);
            GameObject.Find("Enemy4").gameObject.transform.Translate(6, 0, 0);
        }
        for (int num = 1; num <= kazu; num++)
        {
            e = GameObject.Find("Enemy" + num);
            Debug.Log(e);
            icon = e.GetComponent<SpriteRenderer>();
            e = GameObject.Find("Filleh" + num);
            zokusei = e.GetComponent<Image>();
            e = GameObject.Find("HP enemy" + num);
            hpmax = e.GetComponent<Slider>();
            if (num == 1)
            {
                eicon1 = GetEnemy(enemyName1).Geticon();
                ezokusei1 = GetEnemy(enemyName1).Getzokusei();
                eName1 = GetEnemy(enemyName1).GetEnemyName();
                ehp1 = GetEnemy(enemyName1).Gethp();
                eatk1 = GetEnemy(enemyName1).Getatk();
                einc1 = GetEnemy(enemyName1).Getinc();
                edef1 = GetEnemy(enemyName1).Getdef();
                emtl1 = GetEnemy(enemyName1).Getmtl();
                espd1 = GetEnemy(enemyName1).Getspd();
                eai1 = GetEnemy(enemyName1).Getai();
                icon.sprite = eicon1;
                zokusei.material = ezokusei1;
                hpmax.maxValue = ehp1;
                hpmax.value = ehp1;
            }
            else if (num == 2)
            {
                eicon2 = GetEnemy(enemyName2).Geticon();
                ezokusei2 = GetEnemy(enemyName2).Getzokusei();
                eName2 = GetEnemy(enemyName2).GetEnemyName();
                ehp2 = GetEnemy(enemyName2).Gethp();
                eatk2 = GetEnemy(enemyName2).Getatk();
                einc2 = GetEnemy(enemyName2).Getinc();
                edef2 = GetEnemy(enemyName2).Getdef();
                emtl2 = GetEnemy(enemyName2).Getmtl();
                espd2 = GetEnemy(enemyName2).Getspd();
                eai2 = GetEnemy(enemyName2).Getai();
                icon.sprite = eicon2;
                zokusei.material = ezokusei2;
                hpmax.maxValue = ehp2;
                hpmax.value = ehp2;
            }
            else if (num == 3)
            {
                eicon3 = GetEnemy(enemyName3).Geticon();
                ezokusei3 = GetEnemy(enemyName3).Getzokusei();
                eName3 = GetEnemy(enemyName3).GetEnemyName();
                ehp3 = GetEnemy(enemyName3).Gethp();
                eatk3 = GetEnemy(enemyName3).Getatk();
                einc3 = GetEnemy(enemyName3).Getinc();
                edef3 = GetEnemy(enemyName3).Getdef();
                emtl3 = GetEnemy(enemyName3).Getmtl();
                espd3 = GetEnemy(enemyName3).Getspd();
                eai3 = GetEnemy(enemyName3).Getai();
                icon.sprite = eicon3;
                zokusei.material = ezokusei3;
                hpmax.maxValue = ehp3;
                hpmax.value = ehp3;
            }
            else if (num == 4)
            {
                eicon4 = GetEnemy(enemyName4).Geticon();
                ezokusei4 = GetEnemy(enemyName4).Getzokusei();
                eName4 = GetEnemy(enemyName4).GetEnemyName();
                ehp4 = GetEnemy(enemyName4).Gethp();
                eatk4 = GetEnemy(enemyName4).Getatk();
                einc4 = GetEnemy(enemyName4).Getinc();
                edef4 = GetEnemy(enemyName4).Getdef();
                emtl4 = GetEnemy(enemyName4).Getmtl();
                espd4 = GetEnemy(enemyName4).Getspd();
                eai4 = GetEnemy(enemyName4).Getai();
                icon.sprite = eicon4;
                zokusei.material = ezokusei4;
                hpmax.maxValue = ehp4;
                hpmax.value = ehp4;
            }

            Debug.Log(hpmax.value);

            Debug.Log(num + "clear");
        }
        p = GameObject.Find("Player1");
        Debug.Log(p);
        Debug.Log(cName1);
        icon = p.GetComponent<SpriteRenderer>();
        p = GameObject.Find("Fillph1");
        zokusei = p.GetComponent<Image>();
        p = GameObject.Find("HP player1");
        hpmax = p.GetComponent<Slider>();
        p = GameObject.Find("HP player1/Fill Area/Text");
        text = p.GetComponent<Text>();
        picon1 = GetPlayer(cName1).Geticon();
        pzokusei1 = GetPlayer(cName1).Getzokusei();
        pName1 = GetPlayer(cName1).GetcName();
        php1 = GetPlayer(cName1).Gethp();
        patk1 = GetPlayer(cName1).Getatk();
        pinc1 = GetPlayer(cName1).Getinc();
        pdef1 = GetPlayer(cName1).Getdef();
        pmtl1 = GetPlayer(cName1).Getmtl();
        pspd1 = GetPlayer(cName1).Getspd();
        pskill11 = GetPlayer(cName1).GetSkilla();
        pskill12 = GetPlayer(cName1).GetSkillb();
        pskill13 = GetPlayer(cName1).GetSkillc();
        pskill14 = GetPlayer(cName1).GetSkilld();
        pskill15 = GetPlayer(cName1).GetSkille();
        pskill16 = GetPlayer(cName1).GetSkillf();
        pskill17 = GetPlayer(cName1).GetSkillg();
        pact1 = GetPlayer(cName1).Getact();
        Debug.Log(pact1);
        icon.sprite = picon1;
        zokusei.material = pzokusei1;
        hpmax.maxValue = php1;
        hpmax.value = php1;
        string hptext = (php1).ToString();
        text.text = "HP                       " + hptext + "/" + hptext;
        Debug.Log(hpmax.value);
        Debug.Log(Getpact1());
        e = GameObject.Find("コマンドパネル");
        Select select = e.GetComponent<Select>();
        select.smove = kazu + 1;                    //要変更
        
        select.Turn();

    }

    

    [SerializeField]
    private Enemy GetEnemy(string enumySearch) {
        return enemyDataBase.GetEnemyLists().Find(enemyName => enemyName.GetEnemyName() == enumySearch);
    }
    [SerializeField]
    private Player GetPlayer(string playerSearch)
    {
        return playerDataBase.GetPlayerLists().Find(cName => cName.GetcName() == playerSearch);
    }
    public int Getkazu() { return kazu; }
    public Material Getezokusei1() { return ezokusei1; }
    public Sprite Geteicon1() { return eicon1; }
    public string GeteName1() { return eName1; }
    public int Getehp1() { return ehp1; }
    public int Geteatk1() { return eatk1; }
    public int Geteinc1() { return einc1; }
    public int Getedef1() { return edef1; }
    public int Getemtl1() { return emtl1; }
    public int Getespd1() { return espd1; }
    public int Geteai1() { return eai1; }
    public Material Getezokusei2() { return ezokusei2; }
    public Sprite Geteicon2() { return eicon2; }
    public string GeteName2() { return eName2; }
    public int Getehp2() { return ehp2; }
    public int Geteatk2() { return eatk2; }
    public int Geteinc2() { return einc2; }
    public int Getedef2() { return edef2; }
    public int Getemtl2() { return emtl2; }
    public int Getespd2() { return espd2; }
    public int Geteai2() { return eai2; }
    public Material Getezokusei3() { return ezokusei3; }
    public Sprite Geteicon3() { return eicon3; }
    public string GeteName3() { return eName3; }
    public int Getehp3() { return ehp3; }
    public int Geteatk3() { return eatk3; }
    public int Geteinc3() { return einc3; }
    public int Getedef3() { return edef3; }
    public int Getemtl3() { return emtl3; }
    public int Getespd3() { return espd3; }
    public int Geteai3() { return eai3; }
    public Material Getezokusei4() { return ezokusei4; }
    public Sprite Geteicon4() { return eicon4; }
    public string GeteName4() { return eName4; }
    public int Getehp4() { return ehp4; }
    public int Geteatk4() { return eatk4; }
    public int Geteinc4() { return einc4; }
    public int Getedef4() { return edef4; }
    public int Getemtl4() { return emtl4; }
    public int Getespd4() { return espd4; }
    public int Geteai4() { return eai4; }
    public Material Getpzokusei1() { return pzokusei1; }
    public Sprite Getpicon1() { return picon1; }
    public string GetpName1() { return pName1; }
    public int Getphp1() { return php1; }
    public int Getpatk1() { return patk1; }
    public int Getpinc1() { return pinc1; }
    public int Getpdef1() { return pdef1; }
    public int Getpmtl1() { return pmtl1; }
    public int Getpspd1() { return pspd1; }
    public Skill Getpskill11() { return pskill11; }
    public Skill Getpskill12() { return pskill12; }
    public Skill Getpskill13() { return pskill13; }
    public Skill Getpskill14() { return pskill14; }
    public Skill Getpskill15() { return pskill15; }
    public Skill Getpskill16() { return pskill16; }
    public Skill Getpskill17() { return pskill17; }
    public int Getpact1() { return pact1; }
    public Material Getpzokusei2() { return pzokusei2; }
    public Sprite Getpicon2() { return picon2; }
    public string GetpName2() { return pName2; }
    public int Getphp2() { return php2; }
    public int Getpatk2() { return patk2; }
    public int Getpinc2() { return pinc2; }
    public int Getpdef2() { return pdef2; }
    public int Getpmtl2() { return pmtl2; }
    public int Getpspd2() { return pspd2; }
    public Skill Getpskill21() { return pskill21; }
    public Skill Getpskill22() { return pskill22; }
    public Skill Getpskill23() { return pskill23; }
    public Skill Getpskill24() { return pskill24; }
    public Skill Getpskill25() { return pskill25; }
    public Skill Getpskill26() { return pskill26; }
    public Skill Getpskill27() { return pskill27; }
    public int Getpact2() { return pact2; }
    public Material Getpzokusei3() { return pzokusei3; }
    public Sprite Getpicon3() { return picon3; }
    public string GetpName3() { return pName3; }
    public int Getphp3() { return php3; }
    public int Getpatk3() { return patk3; }
    public int Getpinc3() { return pinc3; }
    public int Getpdef3() { return pdef3; }
    public int Getpmtl3() { return pmtl3; }
    public int Getpspd3() { return pspd3; }
    public Skill Getpskill31() { return pskill31; }
    public Skill Getpskill32() { return pskill32; }
    public Skill Getpskill33() { return pskill33; }
    public Skill Getpskill34() { return pskill34; }
    public Skill Getpskill35() { return pskill35; }
    public Skill Getpskill36() { return pskill36; }
    public Skill Getpskill37() { return pskill37; }
    public int Getpact3() { return pact3; }
    public Material Getpzokusei4() { return pzokusei4; }
    public Sprite Getpicon4() { return picon4; }
    public string GetpName4() { return pName4; }
    public int Getphp4() { return php4; }
    public int Getpatk4() { return patk4; }
    public int Getpinc4() { return pinc4; }
    public int Getpdef4() { return pdef4; }
    public int Getpmtl4() { return pmtl4; }
    public int Getpspd4() { return pspd4; }
    public Skill Getpskill41() { return pskill41; }
    public Skill Getpskill42() { return pskill42; }
    public Skill Getpskill43() { return pskill43; }
    public Skill Getpskill44() { return pskill44; }
    public Skill Getpskill45() { return pskill45; }
    public Skill Getpskill46() { return pskill46; }
    public Skill Getpskill47() { return pskill47; }
    public int Getpact4() { return pact4; }
}
