using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Excubeplater : MonoBehaviour
{
    // Start is called before the first frame update

    public Text TextUI = null;
    public int Count = 0;
    public int Power = 100;

    public int Point = 0;
    public float checktime = 0.0f;

    public Rigidbody m_Rigidbody;


    // Update is called once per frame
    void Update()
    {

        checktime += Time.deltaTime;
        if (checktime >= 1.0f)
        {
            Point += 1;
            checktime = 0.0f;

        }

        if (Input.GetMouseButtonDown(0))
        {
            Power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * Power);
        }

        TextUI.text = Count.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Pipe")
        {
            Point = 0;
            gameObject.transform.position = Vector3.zero;
        }
    }
    void OntriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Items")
        {
            Point += 10;
            Destroy(other.gameObject);
        }
    }
         
}
