using UnityEngine;
using System.Collections;
using System;

public class UnbalancedTreeScript : MonoBehaviour {

    public bool enemyVisible,
        enemyAudible,
        needHealth,
        underFire,
        squadDead,
        squadNeedHealth,
        ordersComplete;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (enemyVisible)
        {
            Fight();
        }
        else if (enemyAudible)
        {
            Search();
        }
        else if (needHealth)
        {
            Health();
        }
        else if (underFire)
        {
            Cover();
        }
        else if (squadDead)
        {
            CallBackup();
        }
        else if (squadNeedHealth)
        {
            OrderMedic();
        }
        else if (ordersComplete)
        {
            MissionComplete();
        }
        else
        {
            FollowOrders();
        }
	
	}

    private void FollowOrders()
    {
        Debug.Log("Following Orders");
    }

    private void MissionComplete()
    {
        Debug.Log("Mission complete ");
    }

    private void OrderMedic()
    {
        Debug.Log("Order Medic");
    }

    private void CallBackup()
    {
        Debug.Log("CallBackup");
    }

    private void Cover()
    {
        Debug.Log("Cover");
    }

    private void Health()
    {
        Debug.Log("Heal");
    }

    private void Search()
    {
        Debug.Log("Search");
    }

    private void Fight()
    {
        Debug.Log("Fight");
    }
}
