using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    #region VARIAVEIS
        public List<GameObject> objects;
    #endregion


    #region METODOS

    #endregion


    #region UNITY-METODOS
        public void Update()
        {
            if(Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(objects.GetRandom(), transform);
            }
        }
    #endregion
}
