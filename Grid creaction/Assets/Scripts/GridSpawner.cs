using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{

    public int row;
    public int col;
    public int rowSpace=0;
    public int colSpace=0;
    public GameObject cubePF;

    private GameObject[,] gridCube;
    // Start is called before the first frame update
    void Start()
    {
        GridMaker(row,col);  
    }

    private void GridMaker(int row, int col)
    {
        rowSpace = 0;
        colSpace = 0;
        gridCube = new GameObject[row, col];
   /*     Debug.Log(gridCube.GetLength(0));
        Debug.Log(gridCube.GetLength(1));*/

        for (int i = 0; i < gridCube.GetLength(0); i++)
        {
            colSpace = 0;
            for (int j = 0; j < gridCube.GetLength(1); j++)
            {
                Vector3 pos = new Vector3(transform.position.x + rowSpace, 0.56f, transform.position.z + colSpace);
                gridCube[i, j] = Instantiate(cubePF, pos, cubePF.transform.rotation);
                colSpace += 2;

            }
            
            rowSpace += 2;
        }
        Debug.Log(rowSpace);
        Debug.Log(colSpace);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
