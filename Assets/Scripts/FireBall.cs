using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    Vector3 target;
    public float fireBallSpeed = 0.03f;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, fireBallSpeed);
        transform.Rotate(new Vector3(0, 0, 0.5f));
        if(transform.position == target)
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        GameObject.Find("Player").SendMessage("PlayImpactSound");
    }


}
