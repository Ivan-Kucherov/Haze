using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public GameObject apple;
    public Vector2 Position;
	public double frequency;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(frequency > Random.Range(0.0f, 1.0f))
            Instantiate(apple, Position, Quaternion.identity);

    }
}
