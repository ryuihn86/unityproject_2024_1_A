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
    public float Power = 100;
    public Rigidbody m_Rigidbody;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Count += 1;
            TextUI.text = Count.ToString();
            m_Rigidbody.AddForce(transform.up * Power);
            Power = Random.Range(100, 200);
        }

        if(gameObject.transform.position.y >=2 || gameObject.transform.position.y <= -2)
        {
            TextUI.text = "½ÇÆÐ";
            Count = 0;
        }
    }
}
