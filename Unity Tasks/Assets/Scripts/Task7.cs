using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class Task7 : MonoBehaviour
{
    public List<GameObject> Tile = new List<GameObject>();

    GameObject[,] grid = new GameObject[16,16];

    private float XMin, XMax, YMin, YMax;
    public float padding;


    // Start is called before the first frame update
    void Start()
    {
        CreateBoard();

        Camera cam = Camera.main;
        XMin = cam.WorldToViewportPoint(new Vector3(0, 0, 0)).x + padding;
        XMax = cam.WorldToViewportPoint(new Vector3(1, 0, 0)).x - padding;
        YMin = cam.WorldToViewportPoint(new Vector3(0, 0, 0)).y + padding;
        YMax = cam.WorldToViewportPoint(new Vector3(0, 1, 0)).y - padding;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBoard()
    {
        

        for (int i = -8; i < grid.Length; i++) {
            for (int j = -8; j < grid.Length; i++) {

                Vector3 pos = new Vector3(i, j , 0);

                if (i % 2 != 0 && j % 2 != 0 || i % 2 == 0 && j % 2 == 0)
                {
                    Debug.Log("This is being accessed");
                    grid[i,j] = Instantiate(Tile[0], pos, Quaternion.identity);
                }

                if (i % 2 > 0 && j % 2 == 0 || i % 2 == 0 && j % 2 > 0)
                {
                    Debug.Log("This is being accessed");
                    grid[i,j] = Instantiate(Tile[1], pos, Quaternion.identity);
                }
            }
        }
    }
}
