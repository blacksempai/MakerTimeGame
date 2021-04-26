using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text textHP;
    public Text textScore; 

    private int score = 0;
    private int hp = 100;

    void Start()
    {
        
    }


    void Update()
    {
        textHP.text = "HP: " + hp;
        textScore.text = "Score: " + score;
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "coin"){
            Destroy(other.gameObject);
            score++;
        }
        if(other.tag == "enemy"){
            hp -= 5;
        }
    }
}
