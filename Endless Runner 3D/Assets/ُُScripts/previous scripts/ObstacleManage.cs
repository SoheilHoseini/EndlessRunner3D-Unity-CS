using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManage : MonoBehaviour
{
    public GameObject Obstacle1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creator1", 4f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        //Creator();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
    }

    void Creator1()
    {
        Instantiate(Obstacle1, this.transform.position, this.transform.rotation);
    }

}
