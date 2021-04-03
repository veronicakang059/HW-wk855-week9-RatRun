using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CatChase : MonoBehaviour
{
    // Start is called before the first frame update
    private Queue<int> catMove = new Queue<int>();
    public GameObject cat;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            catMove.Enqueue(0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            catMove.Enqueue(1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            catMove.Enqueue(2);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            catMove.Enqueue(3);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            showChase();
        }
        
    }

    void showChase()
    {
        while (catMove.Count > 0)
        {
            switch (catMove.Dequeue())
            {
                case 0:
                    cat.transform.Translate(0,1,0);
                    break;
                case 1:
                    cat.transform.Translate(0,-1,0);
                    break;
                case 2:
                    cat.transform.Translate(-1,0,0);
                    break;
                case 3:
                    cat.transform.Translate(1,0,0);
                    break;
                default:
                    break;
                    
            }
        }
    }
}
