using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartSceneOnDestroy : MonoBehaviour
{
    private void OnDestroy()
    {
        Level.Instance.Restart();
    }
}
