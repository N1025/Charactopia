using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDataBase", menuName = "CreatePlayerDataBase")]
public class PlayerDataBase : ScriptableObject
{
    [SerializeField]
    private List<Player> playerLists = new List<Player>();

    //アイテムリストを返す
    public List<Player> GetPlayerLists()
    {
        return playerLists;
    }

}

