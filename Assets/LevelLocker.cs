using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLocker : MonoBehaviour
{
    public bool isLocked;
    public int level;
    public Image lockImage;

    public void setLocked()
    {
        isLocked = true;
    }
    public void setUnLocked()
    {
        isLocked = false;
    }

    public void Update()
    {
        if (isLocked)
        {
            lockImage.enabled = true;
        }
        else
        {
            lockImage.enabled = false;
        }
    }
}
