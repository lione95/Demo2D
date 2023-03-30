using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour{

    public int LifeTotal = 1;
    public int EnemySpeed = 20;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update(){
        rb.velocity = transform.right * EnemySpeed;
    }
    
}
