using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    #region VARIAVEIS
     
    #endregion
     
     
    #region METODOS
        public void OnPointerEnter(PointerEventData eventData)
        {
            transform.Scale();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            transform.ResetScale();
        }
    #endregion
     
     
    #region UNITY-METODOS
     
    #endregion
}
