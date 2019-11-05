using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tatakau : MonoBehaviour
{
    [SerializeField]
    private SkillDataBase askillDataBase;
    private GetStatus getStatus;
    Button button;
    Slider slider;
    public GameObject lis;
    static Skill skill;
    static GameObject prefab;
    static Text coment;
    int num = 1;
    int code;
    int atk;
    int gur;
    [Flags]
    public enum KindOfSkill
    {
        パッシブ,
        オート,
        アクション

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
    public enum KindOfDamage
    {
        ブツリ,
        セイシン,
        なし

    }

    // Start is called before the first frame update
    public void tatakau()
    {
        GameObject gameObject = GameObject.Find("戦闘処理");
        getStatus = gameObject.GetComponent<GetStatus>();
        Debug.Log(getStatus.Getpact1());
        Instantiate(lis);
        num = 1;
        GameObject c = GameObject.Find("コメントパネル/Text");
        coment = c.GetComponent<Text>();

        
        for (int act = getStatus.Getpact1()+1; act < 8; act++) {
            GameObject find = GameObject.Find("Button" + act);
           Debug.Log(act);
            find.SetActive(false);
        }
        for (int act = 1; act <= getStatus.Getpact1(); act++) {
            GameObject find = GameObject.Find("Textb" + act);
            Debug.Log(find);
            Text text = find.GetComponent<Text>();
            Debug.Log(text.text);
            if (num == 1)
            {
                skill = getStatus.Getpskill11();
                Debug.Log(skill);
            }
            else if (num == 2)
            {
                skill = getStatus.Getpskill12();
                Debug.Log(skill);
            }
            else if (num == 3)
            {
                skill = getStatus.Getpskill13();
                Debug.Log(skill);

            }
            else if (num == 4)
            {
                skill = getStatus.Getpskill14();
                Debug.Log(skill);
            }
            else if (num == 5)
            {
                skill = getStatus.Getpskill15();
                Debug.Log(skill);
            }
            else if (num == 6)
            {
                skill = getStatus.Getpskill16();
                Debug.Log(skill);
            }
            else if (num == 7) {
                skill = getStatus.Getpskill17();
                Debug.Log(skill);
            }

            Skill.KindOfSkill KOS = skill.GetKindOfSkill();
            string strVal = Enum.GetName(typeof(KindOfSkill), KOS);

            if (strVal == "アクション")
            {
                text.text = skill.GetsName();
                
            }
            else
            {
                act--;
            }
                num++;
        }
        GameObject ppanel = GameObject.Find("Button1");
        Debug.Log(ppanel);
        button = ppanel.GetComponent<Button>();
        Debug.Log(button);
        button.Select();
    }
    public void tatakau2() {
        GameObject gameObject = GameObject.Find("戦闘処理");
        getStatus = gameObject.GetComponent<GetStatus>();
        Debug.Log(getStatus.Getpact1());
        gameObject = transform.GetChild(0).gameObject;
        Text text = gameObject.GetComponent<Text>();

        skill = GetSkill(text.text);
        Skill.Tage tage = skill.Gettage();
        Debug.Log(skill);
        string strVal = Enum.GetName(typeof(Tage), tage);
        Debug.Log(strVal);
        if (strVal == "敵単") {
            GameObject epanel = GameObject.Find("Enemy1");
            if (epanel == null) {
                epanel = GameObject.Find("Enemy2");
                if (epanel == null)
                {
                    epanel = GameObject.Find("Enemy3");
                    if (epanel == null)
                    {
                        epanel = GameObject.Find("Enemy4");
                    }
                }
            }
            Debug.Log(epanel);
            button = epanel.GetComponent<Button>();
            Debug.Log(button);
            Debug.Log(lis);
            Destroy(lis.gameObject);
            button.Select();
        }

    }
    public void tatakau3() {
        GameObject gameObject = GameObject.Find("戦闘処理");
        getStatus = gameObject.GetComponent<GetStatus>();
        Debug.Log(getStatus.Getpact1());
        gameObject = transform.GetChild(0).gameObject;
        slider = gameObject.GetComponent<Slider>();
        prefab = (GameObject)Resources.Load("Damage");
        Debug.Log(prefab);
        string name = this.name;
        Debug.Log(name);
        Skill.KindOfDamage KOD = skill.GetKindOfDamage();
        string strVal = Enum.GetName(typeof(KindOfDamage), KOD);
        if (strVal == "ブツリ")
        {
            atk = getStatus.Getpatk1();
            if (name == "Enemy1")
            {
                gur = getStatus.Getedef1();
                name = getStatus.GeteName1();
            }
            else if (name == "Enemy2")
            {
                gur = getStatus.Getedef2();
                name = getStatus.GeteName2();
            }
            else if (name == "Enemy3")
            {
                gur = getStatus.Getedef3();
                name = getStatus.GeteName3();
            }
            else if (name == "Enemy4")
            {
                gur = getStatus.Getedef4();
                name = getStatus.GeteName4();
            }
        }
        else if (strVal == "セイシン") {
            atk = getStatus.Getpinc1();
            if (name == "Enemy1")
            {
                gur = getStatus.Getemtl1();
                name = getStatus.GeteName1();
            }
            else if (name == "Enemy2")
            {
                gur = getStatus.Getemtl2();
                name = getStatus.GeteName2();
            }
            else if (name == "Enemy3")
            {
                gur = getStatus.Getemtl3();
                name = getStatus.GeteName3();
            }
            else if (name == "Enemy4")
            {
                gur = getStatus.Getemtl4();
                name = getStatus.GeteName4();
            }
        }
        int damage= atk+Mathf.CeilToInt(skill.Getpow())-gur;
        if (damage < 0)
        {
            damage = 0;
        }
        
        Debug.Log(damage);
        slider.value = slider.value - damage;
        coment.text = name + "に" + damage + "のダメージ!";
        
        gameObject = GameObject.Find("コマンドパネル");
        Select select = gameObject.GetComponent<Select>();
        select.move--;
        Debug.Log("行動数" + select.move + "/" + select.smove);
        select.Move();
        //Instantiate(prefab);
        //new WaitForSeconds(1);
        //Destroy(prefab.gameObject);
    }
    [SerializeField]
    private Skill GetSkill(string skillSearch)
    {
        return askillDataBase.GetSkillLists().Find(sName => sName.GetsName() == skillSearch);
    }

    

}
