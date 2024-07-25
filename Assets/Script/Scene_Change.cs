using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを適用
using UnityEngine.SceneManagement; // シーン切り替えに必要

public class Scene_Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Data.practice_rnd = Random.Range(0, 5);//練習シーンの選択
        // Data.scene_rnd = Random.Range(0,2);//本番シーンの選択
    }

    // Update is called once per frae
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){//migi 矢印が押された
            if(Data.practice_actived == 0 && Data.practice_count != 13){
                PracticeSceneChange();
            } else if(Data.practice_actived == 1 && Data.scene_count != 12){
                ExperimentSceneChange();
            } else {
                SceneManager.LoadSceneAsync("End");
            }   
         }
    }

    private void PracticeSceneChange(){
        Data.practice_rnd = Random.Range(0, 13);//練習シーンの選択
        while(Data.practice[Data.practice_rnd] == 1){
            Data.practice_rnd = Random.Range(0, 13);
        }
        if(Data.practice_rnd == 0){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB0.0cm");
        } else if(Data.practice_rnd == 1){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB0.5cm");
        } else if(Data.practice_rnd == 2){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB1.0cm");
        } else if(Data.practice_rnd == 3){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB1.5cm");
        } else if(Data.practice_rnd == 4){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB2.0cm");
        } else if(Data.practice_rnd == 5){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB2.5cm");
        } else if(Data.practice_rnd == 6){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB3.0cm");
        } else if(Data.practice_rnd == 7){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB3.5cm");
        }else if(Data.practice_rnd == 8){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB4.0cm");
        } else if(Data.practice_rnd == 9){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB4.5cm");
        } else if(Data.practice_rnd == 10){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB5.0cm");
        } else if(Data.practice_rnd == 11){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB5.5cm");
        } else if(Data.practice_rnd == 12){
            Data.practice_actived = 1;
            Data.practice[Data.practice_rnd] = 1;
            Data.practice_count += 1;
            SceneManager.LoadSceneAsync("FB6.0cm");
        }
    }

    private void ExperimentSceneChange(){ 
        if(Data.practice_rnd == 0){
            SceneManager.LoadScene("FB0.0cm");
            Data.practice_actived = 0;    
        }
        if(Data.practice_rnd == 1){
            SceneManager.LoadScene("FB0.5cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 2){
           SceneManager.LoadScene("FB1.0cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 3){
            SceneManager.LoadScene("FB1.5cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 4){
            SceneManager.LoadScene("FB2.0cm");
            Data.practice_actived = 0;    
        }
        if(Data.practice_rnd == 5){
            SceneManager.LoadScene("FB2.5cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 6){
           SceneManager.LoadScene("FB3.0cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 7){
            SceneManager.LoadScene("FB3.5cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 8){
            SceneManager.LoadScene("FB4.0cm");
            Data.practice_actived = 0;    
        }
        if(Data.practice_rnd == 9){
            SceneManager.LoadScene("FB4.5cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 10){
           SceneManager.LoadScene("FB5.0cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 11){
            SceneManager.LoadScene("FB5.5cm");
            Data.practice_actived = 0;  
        }
        if(Data.practice_rnd == 12){
            SceneManager.LoadScene("FB6.0cm");
            Data.practice_actived = 0;  
        }
    }
}

    