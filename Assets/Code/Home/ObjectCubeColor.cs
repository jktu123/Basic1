using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.HomeThree
{
    public class ObjectCubeColor : MonoBehaviour
    {
        private void OnValidate()
        {
            gameObject.GetComponent<MeshRenderer>().sharedMaterial.color = Color.grey;
        }

    }
}



