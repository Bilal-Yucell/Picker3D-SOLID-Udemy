using UnityEngine;

namespace Runtime.Commands.Level
{
    public class OnLevelLoaderCommand
    {
        private Transform _levelHolder;
        internal OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }
        
        internal void Execute(byte levelIndex)
        {
            // levelIndex numaralı prefab'ı Prefabs/LevelPrefabs/ dosyası içinde oluşturdu.
            // Bu prefab LevelHolder gameobject'inin altına açıldı ( _levelHolder, true )
            // ( _levelHolder değişkeni LevelHolder'ı tutmakta )
            Object.Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level {levelIndex}"), _levelHolder,
                true);
            
            
            // var resourceRequest = Resources.LoadAsync<GameObject>($"Prefabs/LevelPrefabs/level {levelIndex}");
            //
            // resourceRequest.completed += operation =>
            // {
            //     var newLevel = Object.Instantiate(resourceRequest.asset as GameObject,
            //         Vector3.zero, Quaternion.identity);
            //     if (newLevel != null) newLevel.transform.SetParent(_levelHolder.transform);
            // };
        }
    }
}