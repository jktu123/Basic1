using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Football
{
    public class PlayerOneColor : MonoBehaviour
    {
        private void Start()
        {
            MeshRenderer addComponent = gameObject.GetComponent<MeshRenderer>();
            addComponent.material.color = Color.blue;
        }
    }
}
