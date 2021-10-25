using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLocker : MonoBehaviour
{
    public bool isLocked;
    public int level;
    Image lockImage;

    public void setLocked()
    {
        isLocked = true;
        lockImage.enabled = true;
    }
    public void setUnLocked()
    {
        isLocked = false;
    }
}
