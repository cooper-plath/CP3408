using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowWaypoints : MonoBehaviour {



    GameObject[] wps;
    GameObject currentNode;
    NavMeshAgent agent;



    public GameObject wpManager;

    void Start() {
        Time.timeScale = 5.0f;
        wps = wpManager.GetComponent<WPManager>().waypoints;
        currentNode = wps[0];

        agent = GetComponent<NavMeshAgent>();

    }

    public void GotoHeli() {

        GotoHere(0);
    }

    public void GotoRuin() {

        GotoHere(7);
    }

    public void GotoRock() {


        GotoHere(1);
    }

    public void GotoFactory() {

        GotoHere(4);
    }

    void GotoHere(int value) {

        agent.SetDestination(wps[value].transform.position);
    }

    void LateUpdate() {


    }
}
