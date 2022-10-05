using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICounter : MonoBehaviour
{
    public int Point { get; private set; }
    public TMP_Text points;

    void Start()
    {
        Point = 0;
        points = GetComponent<TMP_Text>();
    }

    void Update()
    {
        points.text = $"Your points: {Point}";
    }

    public void AddPoint()
    {
        Point += 1;
    }
}
