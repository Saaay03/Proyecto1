using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner1 : MonoBehaviour
{
    public Button button;
    void Start()
    {
        button.onClick.AddListener(Dissapear);
    }
    void Dissapear()
    {
        button.gameObject.SetActive(false);
    }
}
