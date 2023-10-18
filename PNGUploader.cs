using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class CSVUploader : MonoBehaviour
{
//User can upload an image of their choice and have it replace a raw image in-game
    string path;
    public RawImage image;

    public void OpenExplorer()
    {
        //open file explorer
        path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        GetImage();
    }


     void GetImage()
    {
        if(path != null)
        {
            //upload image if none is present
            UpdateImage();
        }
    }
    void UpdateImage()
    {
        //change path of image to new path 
        WWW www = new WWW("file:///" + path);
        image.texture = www.texture;
    }
}
