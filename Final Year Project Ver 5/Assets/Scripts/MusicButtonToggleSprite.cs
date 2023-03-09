using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButtonToggleSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] buttonSprites;
    [SerializeField] private Image targetbutton;



    public void ChangeSprite()
    {
        if (targetbutton.sprite == buttonSprites[0])
        {
            targetbutton.sprite = buttonSprites[1];
            MusicManager.musicManagerInstance.GetComponent<AudioSource>().Pause();
            return;
        }
        if (targetbutton.sprite == buttonSprites[1])
        {
            targetbutton.sprite = buttonSprites[0];
            MusicManager.musicManagerInstance.GetComponent<AudioSource>().Play();
            return;
        }
    }
}
