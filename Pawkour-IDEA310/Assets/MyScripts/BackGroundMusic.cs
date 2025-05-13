using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    // Start is called before the first frame update
    private static BackGroundMusic backGroundMusic;
    void Awake()
    {
        if(backGroundMusic == null)
        {
            DontDestroyOnLoad(backGroundMusic);
        } else {
            Destroy(gameObject);
        }
    }

}
