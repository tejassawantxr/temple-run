using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    int cubePoints = 10;
    int cylinderPoints = 15;
    int spherePoints = 20;
    int totalPoints=0;

    [SerializeField] TMP_Text totalPointsText;
    [SerializeField] TMP_Text PointText;

    void Start(){
        PointText.text="";
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {  
        if(hit.gameObject.tag == "Cube"){
            totalPoints += cubePoints;
            PointText.text = "(Cube: +" + cubePoints + ")";
            Destroy(hit.gameObject);
        }else if(hit.gameObject.tag == "Cylinder"){
            totalPoints += cylinderPoints;
            PointText.text = "(Cylinder: +" + cylinderPoints + ")";
            Destroy(hit.gameObject);
        }else if(hit.gameObject.tag == "Sphere"){
            totalPoints += spherePoints;
            PointText.text = "(Sphere: +" + spherePoints + ")";
            Destroy(hit.gameObject);
        }
          totalPointsText.text=((int) totalPoints).ToString();  
    }
}
