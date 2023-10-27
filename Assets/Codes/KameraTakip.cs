using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform ucak;
    public float ucakKonum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ucak.position.x + ucakKonum, 0, -10f);
    }
}
