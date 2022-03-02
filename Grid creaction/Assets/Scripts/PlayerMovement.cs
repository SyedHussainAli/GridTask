using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GridSpawner gridInfo;
    private BoundryChecker bChecker;
    // Start is called before the first frame update
    void Start()
    {
        gridInfo = GameObject.Find("Cube Spawnner").GetComponent<GridSpawner>();
        bChecker = GetComponent<BoundryChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementt();
    }

    private void PlayerMovementt()
    {
      //  PlayerConstraint();
        if (Input.GetKeyDown(KeyCode.UpArrow)&& bChecker.forwardPlane==false)
        {
            transform.position = new Vector3(transform.position.x, 1.6f, transform.position.z + 2);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)&&bChecker.backPlane == false)
        {
            transform.position = new Vector3(transform.position.x, 1.6f, transform.position.z - 2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && bChecker.rightPlane == false)
        {
            transform.position = new Vector3(transform.position.x + 2, 1.6f, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && bChecker.leftPlane == false)
        {
            transform.position = new Vector3(transform.position.x - 2, 1.6f, transform.position.z);
        }

    }

  /*  private void PlayerConstraint()
    {
        if (gameObject.transform.position.x < 0)
        {
            transform.position = new Vector3(0, 1.6f, transform.position.z );
        }
        if (gameObject.transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, 1.6f, 0);
        }
        if (gameObject.transform.position.x > (gridInfo.rowSpace - 2))
        {
            transform.position = new Vector3((gridInfo.rowSpace - 2), 1.6f, transform.position.z);
        }
        if (gameObject.transform.position.z > (gridInfo.colSpace - 2))
        {
            transform.position = new Vector3(transform.position.x, 1.6f, (gridInfo.colSpace - 2));
        }
    }*/
}
