using System;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraController : Singleton<CameraController>
{
   [FormerlySerializedAs("positionOffset")] public Vector3 cameraOffset;
   [FormerlySerializedAs("lerpSpeed")] public float speed;
   
   private void Update()
   {
      transform.position = Vector3.Lerp(transform.position, Player.Instance.transform.position + cameraOffset,
         Time.deltaTime * speed);
   }

   public void OverwriteCameraOffset(Vector3 cameraOffset)
   {
      this.cameraOffset = cameraOffset;
   }
}
