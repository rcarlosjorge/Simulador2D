using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   public void Default() {
       Time.timeScale = 1;
   }

   public void Lento() {
       Time.timeScale = 0.2f;
   }

   public void Rapido() {
       Time.timeScale = 6;
   }
}
