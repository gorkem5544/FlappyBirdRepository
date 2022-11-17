using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnvironmentController : MonoBehaviour
{

    public GameObject[] BakGorundSprite;
    public GameObject Gorund;
    public GameObject Bakgorund;
    public float time;

    float speed = 20;


    private void Awake()
    {

    }
    private void Start()
    {
        Bakgorund.GetComponent<SpriteRenderer>().sprite = BakGorundSprite[0].GetComponent<SpriteRenderer>().sprite;
    }
    void Update()
    {
        speed += Time.deltaTime * 5;
        Gorund.GetComponent<SpriteRenderer>().size = new Vector2(speed, 3.5f);
        Bakgorund.GetComponent<SpriteRenderer>().size = new Vector2(speed, 16);

        time += Time.deltaTime;
        if (time > 2)
        {
            Bakgorund.GetComponent<SpriteRenderer>().sprite = BakGorundSprite[Random.Range(0, BakGorundSprite.Length)].GetComponent<SpriteRenderer>().sprite;
            time = 0;

        }

    }


}
