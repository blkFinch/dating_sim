using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  enum PlayerStatType
{
    INT, CHA, SOC, STR
}
public class Player : MonoBehaviour
{
    private PlayerStats stats;
    public static Player active;

    private void Awake() {
        if(active == null){
            active = this;
        }else{
            Destroy(this.gameObject);
        }

        //todo: initialize or load from save
        stats = SaveLoad.LoadData();
    }

    public int GetStat(PlayerStatType type){
        switch(type){
            case PlayerStatType.CHA:
                return stats.Charisma;
            case PlayerStatType.INT:
                return stats.Intelligence;
            case PlayerStatType.SOC:
                return stats.Social;
            case PlayerStatType.STR:
                return stats.Strength;
            default:
                return 999;
        }
    }

    public string GetName(){
        return stats.Name;
    }

    public void ModifyStat(PlayerStatType statType, int modifier){
        switch(statType){
            case PlayerStatType.CHA:
                stats.Charisma += modifier;
                break;
            case PlayerStatType.INT:
                stats.Intelligence += modifier;
                break;
            case PlayerStatType.SOC:
                stats.Social += modifier;
                break;
            case PlayerStatType.STR:
                stats.Strength += modifier;
                break;
            default:
                break;
        }
    }
}
