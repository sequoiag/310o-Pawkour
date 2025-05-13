using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PickUpObject : MonoBehaviour
{
    // Start is called before the first frame update
    private int fish;
    //PickUpObject fishCount;

    public TextMeshProUGUI fishtext;
    private void Awake()
    {

        DontDestroyOnLoad(fishtext);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fish++;
            fishtext.text = "Fish: " + fish.ToString();
            Destroy(gameObject);

        }
    }
}
