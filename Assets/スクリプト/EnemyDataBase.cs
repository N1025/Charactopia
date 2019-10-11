using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyDataBase", menuName = "CreateEnemyDataBase")]
public class EnemyDataBase : ScriptableObject
{
    [SerializeField]
    private List<Enemy> enemyLists = new List<Enemy>();

    //アイテムリストを返す
    public List<Enemy> GetEnemyLists()
    {
        return enemyLists;
    }

}
