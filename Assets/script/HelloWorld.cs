using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
    public int speed = 35;
    public GameObject helloText;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        helloText.GetComponent<TextMeshPro>().text = "BRUH";
    }

    // Update is called once per frame
    void Update()
    {
        print("BRUH !!!!");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
