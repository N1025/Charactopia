using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : MonoBehaviour
{
    // 敵と味方の数を判定、配置
    [SerializeField]
    private int kazu;
    private GameObject nouse;
    [SerializeField]
    private EnemyDataBase enemyDataBase;
    [SerializeField]
    private PlayerDataBase playerDataBase;
    private GameObject e;
    private GameObject filleh;
    private GameObject hp_enemy;
    private GameObject p;
    private GameObject fillph;
    private GameObject hp_player;
    private GameObject hp_player_now;
    [SerializeField]
    private string enemyName1;
    [SerializeField]
    private string enemyName2;
    [SerializeField]
    private string enemyName3;
    [SerializeField]
    static string enemyName4;
    static SpriteRenderer icon;
    static Image zokusei;
    static Slider hpmax;
    static Text text;
    static Material ezokusei1;
    static Sprite eicon1;
    static string eName1;
    static int ehp1;
    static Material ezokusei2;
    static Sprite eicon2;
    static string eName2;
    static int ehp2;
    static Material ezokusei3;
    static Sprite eicon3;
    static string eName3;
    static int ehp3;
    static Material ezokusei4;
    static Sprite eicon4;
    static string eName4;
    static int ehp4;
    [SerializeField]
    private string cName1;
    static Material pzokusei1;
    static Sprite picon1;
    static string pName1;
    static int php1;
    void Start()
    {
        //初めに敵の数
        if (kazu <= 2)
        {
            for (int num = kazu+1; num <= 4; num++)
            {
                nouse = GameObject.Find("Enemy" + num);
                GameObject.Destroy(nouse);//敵一人
            }
            if (kazu == 2) {
                GameObject.Find("Enemy1").gameObject.transform.Translate(-2f, 0f, 0f);
                GameObject.Find("Enemy2").gameObject.transform.Translate(2f, 0f, 0f);//敵二人
            }
        }
        else if (kazu == 3)
        {
            nouse = GameObject.Find("Enemy4");
            GameObject.Destroy(nouse);
            GameObject.Find("Enemy1").gameObject.transform.Translate(-4, 0, 0);
            GameObject.Find("Enemy3").gameObject.transform.Translate(4, 0, 0);//敵三人
        }
        else if (kazu == 4)
        {
            GameObject.Find("Enemy1").gameObject.transform.Translate(-6, 0, 0);
            GameObject.Find("Enemy2").gameObject.transform.Translate(-2, 0, 0);
            GameObject.Find("Enemy3").gameObject.transform.Translate(2, 0, 0);
            GameObject.Find("Enemy4").gameObject.transform.Translate(6, 0, 0);//敵四人
        }
        //敵の情報を取得、表示
        for (int num = 1; num <= kazu; num++)
        {
            e = GameObject.Find("Enemy" + num);
            Debug.Log(e);
            icon = e.GetComponent<SpriteRenderer>();
            filleh = GameObject.Find("Filleh" + num);
            zokusei = filleh.GetComponent<Image>();
            hp_enemy = GameObject.Find("HP enemy" + num);
            hpmax = hp_enemy.GetComponent<Slider>();
            if (num == 1)
            {
                eicon1 = GetEnemy(enemyName1).Geticon();
                ezokusei1 = GetEnemy(enemyName1).Getzokusei();
                eName1 = GetEnemy(enemyName1).GetEnemyName();
                ehp1 = GetEnemy(enemyName1).Gethp();
                
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
               
                icon.sprite = eicon4;
                zokusei.material = ezokusei4;
                hpmax.maxValue = ehp4;
                hpmax.value = ehp4;
            }

            Debug.Log(hpmax.value);

            Debug.Log(num + "clear");
        }
        //次に味方の情報取得、表示
        p = GameObject.Find("Player1");
        Debug.Log(p);
        Debug.Log(cName1);
        icon = p.GetComponent<SpriteRenderer>();
        fillph = GameObject.Find("Fillph1");
        zokusei = fillph.GetComponent<Image>();
        hp_player = GameObject.Find("HP player1");
        hpmax = hp_player.GetComponent<Slider>();
        hp_player_now = GameObject.Find("HP player1/Fill Area/Text");
        text = hp_player_now.GetComponent<Text>();
        picon1 = GetPlayer(cName1).Geticon();
        pzokusei1 = GetPlayer(cName1).Getzokusei();
        pName1 = GetPlayer(cName1).GetcName();
        php1 = GetPlayer(cName1).Gethp();

        icon.sprite = picon1;
        zokusei.material = pzokusei1;
        hpmax.maxValue = php1;
        hpmax.value = php1;
        string maxhptext = (hpmax.maxValue).ToString();
        string nowhptext = (hpmax.value).ToString();
        text.text = "HP                       " + nowhptext + "/" + maxhptext;
    }

    

    [SerializeField]
    private Enemy GetEnemy(string enumySearch)
    {
        return enemyDataBase.GetEnemyLists().Find(enemyName => enemyName.GetEnemyName() == enumySearch);
    }
    [SerializeField]
    private Player GetPlayer(string playerSearch)
    {
        return playerDataBase.GetPlayerLists().Find(cName => cName.GetcName() == playerSearch);
    }
    // 戦闘処理
    void Update()
    {
        
    }
}
