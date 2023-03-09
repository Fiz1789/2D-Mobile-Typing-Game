using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager musicManagerInstance;

    public void Awake()
    {
        if (musicManagerInstance == null)
        {
            musicManagerInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
