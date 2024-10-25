using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LessonBasic
{ 

public class FirstLessonScript : MonoBehaviour
{
   

        public int tamSayi=1;
        float ondalikSayi = 0.25f;
        bool dogru = true;
      [SerializeField]  private Vector3 ucFloat=new Vector3(1,2,3);



        public float FloatProperty { get; private set; }


        void Start()
    {
            ondalikSayi = 1000;
            FloatProperty= 100000f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
