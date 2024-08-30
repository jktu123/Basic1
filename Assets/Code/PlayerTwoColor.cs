using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.Football
{
    public class PlayerTwoColor : MonoBehaviour
    {
        private void Start()
        {
            MeshRenderer addComponent = gameObject.GetComponent<MeshRenderer>();
            addComponent.material.color = Color.red;
        }
    }
}
