using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy_Dead : MonoBehaviour
{
    float health;
    float Enemyhealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        health = GameObject.FindGameObjectWithTag("Player").GetComponent<MinionStats>().GetStat("health");
        Enemyhealth = GameObject.FindGameObjectWithTag("Enemy").GetComponent<MinionStats>().GetStat("health");

        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
        if (Enemyhealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
	}
}