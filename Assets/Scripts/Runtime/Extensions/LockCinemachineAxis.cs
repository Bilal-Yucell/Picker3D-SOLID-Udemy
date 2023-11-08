using System;
using Cinemachine;
using UnityEngine;

namespace Runtime.Extensions
{
    public enum CinemachineLockAxis
    {
        X,
        Y,
        Z
    }
    
    [ExecuteInEditMode]
    [SaveDuringPlay]
    [AddComponentMenu("")]
    public class LockCinemachineAxis : CinemachineExtension
    {
        [SerializeField] private CinemachineLockAxis lockAxis;
        [Tooltip("Lock The Cinemachine Virtual Camera's X Axis position with this spescfic value")]
        public float XClampValue = 0;
        
        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, 
            CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
            switch (lockAxis)
            {
                case CinemachineLockAxis.X:
                    if (stage == CinemachineCore.Stage.Body)
                    {
                        var pos = state.RawPosition;
                        pos.x = XClampValue;
                        state.RawPosition = pos;
                    }
                    break;
                case CinemachineLockAxis.Y:
                    if (stage == CinemachineCore.Stage.Body)
                    {
                        var pos = state.RawPosition;
                        pos.y = XClampValue;
                        state.RawPosition = pos;
                    }
                    break;
                case CinemachineLockAxis.Z:
                    if (stage == CinemachineCore.Stage.Body)
                    {
                        var pos = state.RawPosition;
                        pos.z = XClampValue;
                        state.RawPosition = pos;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}