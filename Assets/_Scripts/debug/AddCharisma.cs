using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCharisma : MonoBehaviour
{
    public void AddCha(){
        Player.active.ModifyStat(PlayerStatType.CHA, 1);
    }
}
