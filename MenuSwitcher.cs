using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitcher : MonoBehaviour
{
    //Populate this section of your inspector with the respective menus you would love to switch
    [SerializeField]private List<GameObject> UI_List = new List<GameObject>();
    
    //Create Cinemachine virtual cameras for each Menu created.
    //Populate them in the List.
    [SerializeField]private List<GameObject> CameraUIList = new List<GameObject>();
    
    //drag the MenuManager (this Gameobject) to the OnClick() event (of the button)
    //select MenuSwitch then, select OpenUI()
    //drag the Menu game object/ canvas (you intend to open) to the object slot of the method.
    public void OpenUI(GameObject UI){
        if(UI_List.Contains(UI)){
            foreach (GameObject ui in UI_List){
                if(ui.name == UI.name){
                    ui.SetActive(true);
                }
                else
                    ui.SetActive(false);
            }
            CameraBlend(UI.name);
        }
        else{
            Debug.LogError("UI " + UI+ "not found in the UI List");
        } 
    }
    
    public void CameraBlend(string UIName){
        foreach(GameObject cams in CameraUIList){
            if(cams.name == UIName + "Cam"){
                cams.SetActive(true);
            }
            else{
                cams.SetActive(false);
            }
        }
    }
}
