using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    #region VARIAVEIS
        public int speed = 20;
        public int gear = 5;

        public GameObject carPrefab;
    #endregion
     
     
    #region METODOS
        public int TotalSpeed
        {
            get { return speed * gear; }
        }

        public void CreateCar()
        {
            var c = Instantiate(carPrefab);
            c.transform.position = Vector3.zero;
        }
    #endregion
     
     
    #region UNITY-METODOS
     
    #endregion
}
