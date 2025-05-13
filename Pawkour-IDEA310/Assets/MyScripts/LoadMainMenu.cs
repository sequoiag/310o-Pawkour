using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello");
        if (collision.gameObject.CompareTag("Player")) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //winText.gameObject.SetActive(false);
            SceneManager.LoadScene("Win");
        }
    }
}
