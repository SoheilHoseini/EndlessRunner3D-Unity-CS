using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bld;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f,0f,0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Instantiate(bld, this.transform.position, this.transform.rotation);//at the position of bullet hitting another object, vreates blood
        }
        Destroy(this.gameObject);//if the bullet hits anything, it will be destroyed
    }                            //because of "trigger" the bullet will enter the objects but will be destroyed
}
