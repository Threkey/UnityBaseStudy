using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    protected char player;
    public char enemy;
    // Start is called before the first frame update
    void Start()
    {
        print("가위: s / 바위: r / 보: p");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            player = 'r';
        }
        else if (Input.GetKey(KeyCode.S))
        {
            player = 's';
        }
        else if (Input.GetKey(KeyCode.P))
        {
            player = 'p';
        }
        else
        {
            player = 'x';
            print("wrong input");
        }

        switch(player)
        {
            case 'r':
                {
                    if (enemy == 'r')
                        print("draw");
                    else if (enemy == 's')
                        print("player lose");
                    else if (enemy == 'p')
                        print("player win");
                    break;
                }

            case 's':
                {
                    if (enemy == 'r')
                        print("player lose");
                    else if (enemy == 's')
                        print("draw");
                    else if (enemy == 'p')
                        print("player lose");
                    break;
                }

            case 'p':
                {
                    if (enemy == 'r')
                        print("player win");
                    else if (enemy == 's')
                        print("player lose");
                    else if (enemy == 'p')
                        print("draw");
                    break;
                }

            default:
                {
                    print("error");
                    break;
                }

        }
    }
}
