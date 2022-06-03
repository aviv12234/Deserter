using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oasis : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 temp;
    void Start()
    {

        transform.localScale = new Vector3(Random.Range(5, 12), Random.Range(5, 12), 1);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
