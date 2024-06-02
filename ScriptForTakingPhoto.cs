using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Android;

public class ScriptForTakingPhoto : MonoBehaviour
{
    public WebCamTexture webCamTexture;
    public RawImage display;
    public AspectRatioFitter fit;

    public void Start()
    {
        // Start the camera feed

        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }

        WebCamDevice[] devices = WebCamTexture.devices;

        for (int i = 0; i < devices.Length; i++)
        {
            if (!devices[i].isFrontFacing)
            {
                webCamTexture = new WebCamTexture(devices[i].name);
                break;
            }
        }

        webCamTexture.requestedWidth = 966;
        webCamTexture.requestedHeight = 966;

        display.texture = webCamTexture;
        // display.transform.localScale = new Vector3(-1, 1, 1); // Mirror the front camera feed
        webCamTexture.Play();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(CaptureImageAndSave());
        }
    }

    public IEnumerator CaptureImageAndSave()
    {
        yield return new WaitForEndOfFrame();

        // Create a new Texture2D using the camera feed
        Texture2D texture = new Texture2D(webCamTexture.width, webCamTexture.height, TextureFormat.RGB24, false);
        texture.SetPixels(webCamTexture.GetPixels());
        texture.Apply();

        // // Mirror the captured image
        // texture = FlipTexture(texture);

        // Save the image to Gallery/Photos
        string fileName = "Image.png";
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(texture, "GalleryTest", fileName, (success, path) =>
        {
            if (success)
            {
                Debug.Log("Image saved to gallery: " + path);

                // Save the image path to PlayerPrefs
                PlayerPrefs.SetString("LastImagePath", path);
            }
            else
            {
                Debug.LogError("Failed to save image to gallery");
            }
        });

        Debug.Log("Permission result: " + permission);

        // Destroy the texture to avoid memory leaks
        Destroy(texture);
    }

    // private Texture2D FlipTexture(Texture2D original)
    // {
    //     Texture2D flipped = new Texture2D(original.width, original.height);

    //     for (int y = 0; y < original.height; y++)
    //     {
    //         for (int x = 0; x < original.width; x++)
    //         {
    //             flipped.SetPixel(original.width - x - 1, y, original.GetPixel(x, y));
    //         }
    //     }

    //     flipped.Apply();
    //     return flipped;
    // }
}