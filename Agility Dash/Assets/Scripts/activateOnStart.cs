using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class activateOnStart : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().enabled = true;
    }
}
