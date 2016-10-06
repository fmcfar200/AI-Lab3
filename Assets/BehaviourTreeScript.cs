using UnityEngine;
using System.Collections;
using System;

public class BehaviourTreeScript : MonoBehaviour {

       public bool enemyVisible, 
            enemyAttacking,
            enemyFlank,
            enemyAudible,
            enemyFlee,
            enemyReload,
            enemyClose,
            enemyDead,
            enemyCover;



	// Use this for initialization
	void Start () {

        
	
	}

    void Fire()
    {
        Debug.Log("Firing");
    }
    
    void FlankEnemy()
    {
        Debug.Log("Flanking enemy");
    }
    void Search()
    {
        Debug.Log("searching");

    }
    void MoveToEnemy()
    {
        Debug.Log("moving to enemy pos");

    }
    void Cover()
    {

    }
    void Stealth()
    {
        Debug.Log("Creeping");

    }

    // Update is called once per frame
    void Update () {

        if(enemyVisible == true)
        {
            if(enemyAttacking== true)
            {
                if (enemyCover == true)
                {
                    FlankEnemy();
                }
                else
                {
                    Fire();
                }
            }
            else if (enemyFlee == true)
            {
                Chase();
            }
            else
            {
                Stealth();
            }
            
        }
        else if (enemyAudible == true)
        {
            if (enemyClose)
            {
                MoveToEnemy();
            }
            else
            {
                Search();
            }
        }
        else if (enemyDead)
        {
            MissionComplete();
        }

    }

    private void MissionComplete()
    {
        Debug.Log("Mission Complete");
    }

    void Chase()
    {
        Debug.Log("Chasing");

    }
}
