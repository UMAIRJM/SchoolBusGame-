using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficScript : MonoBehaviour
{
    public Vector3 pos1;
    public Vector3 initialPosition1;
    public Vector3 pos2;
    public Vector3 initialPosition2;
    public Vector3 pos3;
    public Vector3 initialPosition3;
    public Vector3 pos4;
    public Vector3 initialPosition4;
    public Vector3 pos5;
    public Vector3 initialPosition5;
    public Vector3 pos6;
    public Vector3 initialPosition6;
    public GameObject traffic1;
    public GameObject traffic2;
    public GameObject traffic3;
    public GameObject traffic4;
    public GameObject traffic5;
    public GameObject traffic6;


    // Start is called before the first frame update
    void Start()
    {
        initialPosition1 = traffic1.transform.position;
        initialPosition2 = traffic2.transform.position;
        initialPosition3 = traffic3.transform.position;
        initialPosition4 = traffic4.transform.position;
        initialPosition5 = traffic5.transform.position;
        initialPosition6 = traffic6.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        
        pos1 = traffic1.transform.position;
        pos2 = traffic2.transform.position;
        pos3 = traffic3.transform.position;
        pos4 = traffic4.transform.position;
        pos5 = traffic5.transform.position;
        pos6 = traffic6.transform.position;


        if (pos1.z >= 100f)
        {
            traffic1.transform.position = initialPosition1;

        }
        else {
            traffic1.transform.Translate(0, 0, 0.5f);
        }

        if (pos2.x >= 100f)
        {
            traffic2.transform.position = initialPosition2;

        }
        else
        {
            traffic2.transform.Translate(0, 0, 0.5f);
        }
        if (pos3.z <= -100f)
        {
            traffic3.transform.position = initialPosition3;

        }
        else
        {
            traffic3.transform.Translate(0, 0, 0.5f);
        }

        if (pos4.x >= 100f)
        {
            traffic4.transform.position = initialPosition4;

        }
        else
        {
            traffic4.transform.Translate(0, 0, 0.5f);
        }
        if (pos5.x >= 100f)
        {
            traffic5.transform.position = initialPosition5;

        }
        else
        {
            traffic5.transform.Translate(0, 0, 0.5f);
        }
        if (pos6.x <= -100f)
        {
            traffic6.transform.position = initialPosition6;

        }
        else
        {
            traffic6.transform.Translate(0, 0, 0.5f);
        }
    }
}
