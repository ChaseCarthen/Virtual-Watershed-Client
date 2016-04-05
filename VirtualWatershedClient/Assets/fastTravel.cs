﻿using UnityEngine;
using System.Collections;

public class fastTravel : MonoBehaviour {

    public Camera miniMap;
    public GameObject player;
    public GameObject playerMarker;

    private Ray ray;
    private RaycastHit hit;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            ray = miniMap.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Clicked on Minimap");
                player.transform.position = hit.point+new Vector3(0,10,0);
            }

        }
        playerMarker.transform.position = player.transform.position + new Vector3(0, 30, 0);
	}
}
