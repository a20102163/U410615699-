using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class init : MonoBehaviour
{

    public Rigidbody prefab;
    public Rigidbody startobj = null;
    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            Rigidbody obj = Instantiate(prefab, new Vector3(i * 0.8f, 0.5f, 0), Quaternion.identity);
            if (i == 0)
            {
                startobj = obj;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            startobj.AddForce(new Vector3(1, 0, 0));
        }
    }
}
