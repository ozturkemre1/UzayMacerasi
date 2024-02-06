using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MuzikKontrol : MonoBehaviour
{
    public static MuzikKontrol instance;

    AudioSource audioSource;
    
    // Start is called before the first frame update
    void Awake()
    {
        Singleton();
        audioSource = GetComponent<AudioSource>();
    }

    void Singleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }else
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    public void MuzikCal(bool play)
    {
        if (play)
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

}
