using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Queue<int> attackInput = new Queue<int>();
    public GameObject player;
    private bool playAttack = false;
    public Text displaytext;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            attackInput.Enqueue(0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            attackInput.Enqueue(1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            attackInput.Enqueue(2);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            attackInput.Enqueue(3);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playAttack = true;
            showAttack();
        }
        
    }

    void showAttack()
    {
        while (attackInput.Count > 0)
        {
            switch (attackInput.Dequeue())
            {
                case 0:
                    player.transform.Translate(-1,0,0);
                    break;
                case 1:
                    player.transform.Translate(0,-1,0);
                    break;
                case 2:
                    player.transform.Translate(1,0,0);
                    break;
                case 3:
                    player.transform.Translate(0,1,0);
                    break;
                default:
                    break;
            }
        }
        playAttack = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        displaytext.text = "Rat lost!";
    }
}
