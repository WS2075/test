using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_typeB : MonoBehaviour
{
    //private enum POW_STATE
    //{
    //    STATE_1,
    //    STATE_2,
    //    STATE_3,
    //    STATE_MAX
    //};

    public float speed;
    public float cooltime;
    //private POW_STATE state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        if (transform.position.x > 960 || transform.position.x <= -960)
        {
            Destroy(gameObject);
        }
    }

    public float GetCooltime()
    {
        return cooltime;
    }
}
