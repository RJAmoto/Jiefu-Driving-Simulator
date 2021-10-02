using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Scaler : MonoBehaviour
{
    public RectTransform panelRectTransform;
    // Start is called before the first frame update
    void Start()
    {

        panelRectTransform.anchorMin = new Vector2(1, 0);
        panelRectTransform.anchorMax = new Vector2(0, 1);
        panelRectTransform.pivot = new Vector2(0.5f, 0.5f);
    }
}
