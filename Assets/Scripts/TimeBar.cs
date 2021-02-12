
using UnityEngine;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour
{
    public Slider slider;
   

   public void SetMaxTimeJuice(int timeJuice)
   {
       slider.maxValue = timeJuice;
       slider.value = timeJuice;
   }
   public void SetTimeJuice(int timeJuice)
   {
       slider.value = timeJuice;
   }
   
}
