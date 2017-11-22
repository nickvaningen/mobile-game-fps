using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Cube : MonoBehaviour
{
    [SerializeField]
    private float steps = 0;
    private int chance = 0;


    float xpos;
    float ypos;

    enum Direction {Up,Down,Left,Right, }



    [SerializeField] GameObject player;

    public void Down()
    {
        transform.position+= Vector3.down;
        steps++;
    }

    public void Up()
    {
        transform.position+= Vector3.up;
        steps++;
    }
    
    public void Left()
    {
        transform.position+= Vector3.left;
        steps++;
    }

    public void Right()
    {
        transform.position+= Vector3.right;
        steps++;
    }
     void Update()
    {
        print(steps);
        if (steps > 10)
        {
             int chance = Random.Range(0, 2);
            if (chance == 1)
            {
                print("werkt");
                SceneManager.LoadScene(1);
            }
            print(steps);
            print(chance);
            steps = 0;
        } 

    }



}


