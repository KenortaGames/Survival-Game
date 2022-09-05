using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatManager : MonoBehaviour
{
    public List<Stat> stats;
    
    public void AddStat(string statToAdd)
    {
        for (int i = 0; i < stats.Count; i++)
        {
            if(statToAdd == stats[i].statName){
                stats[i].value++;
            }
        }
    }
    public void RemoveStat(string statToRemove)
    {
        for (int i = 0; i < stats.Count; i++)
        {
            if(statToRemove == stats[i].statName){
                stats[i].value--;
            }
        }
    }
}
[System.Serializable]
public class Stat
{
    public string statName = "Null";
    public int value = 15;
}
