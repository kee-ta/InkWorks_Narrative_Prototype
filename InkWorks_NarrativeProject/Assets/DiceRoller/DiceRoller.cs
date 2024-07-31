using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    public float rollForce;
    private Rigidbody rgbd;
    
    // Start is called before the first frame update
    void Start()
    {
        rgbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RollDice();
            Debug.Log("Rolling!");
        }
    }

    private void RollDice()
    {
        rgbd.AddForce(Vector3.up * rollForce*100);
        rgbd.AddTorque(new Vector3(Random.Range(1, 8), Random.Range(1, 8), Random.Range(1, 8)));
    }
}
