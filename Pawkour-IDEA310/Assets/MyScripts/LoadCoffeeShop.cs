using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCoffeeShop : MonoBehaviour
{
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello");
        if (collision.gameObject.CompareTag("Player")) {
            //winText.gameObject.SetActive(false);
            SceneManager.LoadScene("CoffeeShop");
        }
    }
}
