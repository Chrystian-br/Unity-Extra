using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    #if UNITY_EDITOR
    [UnityEditor.MenuItem("RysCorp/Test")]
    public static void Test()
    {
        Debug.Log("Teste");
    }

    [UnityEditor.MenuItem("RysCorp/Test2 %g")]
    public static void Test2()
    {
        Debug.Log("Teste");
    }
    #endif

    #region Scale
        public static void Scale(this Transform t, float size = 1.2f)
        {
            t.localScale = Vector3.one * size;
        }

        public static void ResetScale(this Transform t)
        {
            t.localScale = Vector3.one;
        }
    #endregion

    #region Random

        public static T GetRandom<T>(this List<T> list)
        {
            return list[Random.Range(0,list.Count)];
        }

        public static T GetRandomButNotSame<T>(this List<T> list, T unique)
        {
            if(list.Count == 1)
                return unique;

            int randomIndex = Random.Range(0, list.Count);
            return list[randomIndex];
        }

    #endregion

    

}
