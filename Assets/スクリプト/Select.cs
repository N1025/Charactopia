using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour
{
    public GameObject select1;
    public int turn=1;
    public int smove;
    public int move;
    int fast;
    int ari = 1;
    GameObject a;
    GameObject b;
    Button button;
    static GetStatus getStatus;
    static List<int> speed;
    static Text coment;
    // Start is called before the first frame update
    public void Turn()
    {
        GameObject c = GameObject.Find("コメントパネル/Text");
        coment = c.GetComponent<Text>();
        GameObject sta = GameObject.Find("戦闘処理");
        getStatus = sta.GetComponent<GetStatus>();
        speed = new List<int> { getStatus.Getpspd1(), getStatus.Getespd1()-1 };
        if (getStatus.Getkazu() >= 2)
        {
            speed.Add(getStatus.Getespd2()-2);
            if (getStatus.Getkazu() >= 3)
            {
                speed.Add(getStatus.Getespd3()-3);
                if (getStatus.Getkazu() == 4)
                {
                    speed.Add(getStatus.Getespd4()-4);
                }
            }
        }
        move = smove;
        Debug.Log("ターン" + turn);
        Debug.Log("行動数"+move+"/"+smove);
        //Debug.Log("speed "+speed[0] + "," + speed[1] + "," + speed[2] + "," + speed[3] + "," + speed[4]);
        Move();
        
        
    }
    public void Move()
    {
        //coment.text = "ターン" + turn;
        while (move >= 0) {
            Debug.Log("clear1");
            fast = speed.Max();
            fast = speed.IndexOf(fast);
            if (move != smove)
            {
                if (move == 0)
                {
                    turn++;
                    Turn();
                    Debug.Log("break");
                    break;
                }
                Debug.Log(fast);
                speed.RemoveAt(fast);
                speed.Insert(fast, -99);
                //Debug.Log("speed " + speed[0] + "," + speed[1] + "," + speed[2] + "," + speed[3] + "," + speed[4]);
            }
            fast = speed.Max();
            if (fast == speed[0])
            {
                Debug.Log("clear2");
                button = select1.GetComponent<Button>();
                button.Select();
                Debug.Log("break");
                break;
            }
            else if (fast == speed[1])
            {
                EAI(1);
                Debug.Log("Enemy1move");
                move--;
                Debug.Log("行動数" + move + "/" + smove);
                
            }
            else if (fast == speed[2])
            {
                Debug.Log("Enemy2move");
                move--;
                Debug.Log("行動数" + move + "/" + smove);

            }
            else if (fast == speed[3])
            {
                Debug.Log("Enemy3move");
                move--;
                Debug.Log("行動数" + move + "/" + smove);

            }
            else if (fast == speed[4])
            {
                Debug.Log("Enemy4move");
                move--;
                Debug.Log("行動数" + move + "/" + smove);

            }
        }
        
        
    }
    public int EAI(int x) {
        Debug.Log("point"   +x);
        string name;
        int y;
        int ai;
        int eatk;
        int pdef;
        int damage;
        Slider slider;
        Text text;
        if (x == 1) {
             ai = getStatus.Geteai1();
            name = getStatus.GeteName1();
            Debug.Log("point2"   +ai);
        } else if (x == 2) {
             ai = getStatus.Geteai2();
            name = getStatus.GeteName2();
        }
        else if (x == 3) {
             ai = getStatus.Geteai3();
            name = getStatus.GeteName3();
        }
        else {
             ai = getStatus.Geteai4();
            name = getStatus.GeteName4();
        }
        switch (ai) {
            case 1://ブツリ攻撃
                if (x == 1)
                {
                    eatk = getStatus.Geteatk1();
                    Debug.Log("point3");
                }
                else if (x == 2)
                {
                    eatk = getStatus.Geteatk2();
                }
                else if (x == 3)
                {
                    eatk = getStatus.Geteatk3();
                }
                else
                {
                    eatk = getStatus.Geteatk4();
                }
                pdef = getStatus.Getpdef1();
                damage = eatk - pdef;
                Debug.Log(damage);
                if (damage < 0) {
                    damage = 0;
                }
                b = GameObject.Find("HP player1");
                Debug.Log(b);
                slider = b.GetComponent<Slider>();
                slider.value = slider.value - damage;
                coment.text = name + "の攻撃!" + getStatus.GetpName1() + "に" + damage + "のダメージ!";
                string hpnow = (slider.value).ToString();
                string hpmax = (getStatus.Getphp1()).ToString();
                b = GameObject.Find("HP player1/Fill Area/Text");
                text = b.GetComponent<Text>();
                text.text = "HP                       " + hpnow + "/" + hpmax;

                break;
        }
        y = 1;
        return y;
    }
    IEnumerator Wait()
    {
        while (!Input.GetKey("a")) yield return new WaitForSeconds(5);
        Debug.Log("test");
    }

    // Update is called once per frame
    private void Update()
    {
        if (ari == 1) {
            a = GameObject.Find("HP enemy1");
            Slider slider = a.GetComponent<Slider>();
            if (slider.value <= 0)
            {
                a = GameObject.Find("Enemy1");
                Destroy(a.gameObject);
                ari = 0;
                smove--;
                if (smove == 1) {
                    coment.text = "敵を倒した!";
                }
            }
        }
        
    }
}