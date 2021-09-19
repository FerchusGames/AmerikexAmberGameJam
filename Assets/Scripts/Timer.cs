using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool gameDone;
    public bool loseflag;
    public float timer;
    public float current_time;
    public Text timer_text;
    public Image timer_image;

    public SistemaComprobación sistemaComprbacion;
    // Start is called before the first frame update
    public void SetTimer()
    {
        current_time = timer;
    }

    public void AddToTimer(float _time_to_add)
    {
        current_time += _time_to_add;
        current_time = Mathf.Clamp(current_time, 0f, timer);
    }

    public void SubstractToTimer(float _time_to_substract)
    {
        current_time -= Time.deltaTime * 1.0f;
        timer_text.text = current_time.ToString("F2").Replace(".", ":");
        timer_image.fillAmount = current_time / (timer);
    }

    public void Start()
    {
        gameDone = false;
        loseflag = false;
        SetTimer();
    }

    public void Update()
    {
        if (!gameDone)
            SubstractToTimer(0.0f);

        if (current_time <= 0 && !loseflag)
        {
            timer_text.text = "0:00";
            gameDone = true;
            loseflag = true;
            sistemaComprbacion.valorTotal = 0;
            sistemaComprbacion.Comprobar();
        }
            
    }
}
