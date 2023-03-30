using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEnemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D enemy){
        if(enemy.tag == "Enemy"){
            enemy.transform.Rotate(0f, 180f, 0f);
        }
    }
}
