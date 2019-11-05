using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillDataBase", menuName = "CreateSkillDataBase")]
public class SkillDataBase : ScriptableObject
{
    [SerializeField]
    private List<Skill> skillLists = new List<Skill>();

    // スキルリストを返す
    public List<Skill> GetSkillLists()
    {
        return skillLists;
    }

}
