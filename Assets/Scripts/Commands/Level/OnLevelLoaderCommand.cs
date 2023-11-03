using UnityEngine;

namespace Commands.Level
{
    public class OnLevelLoaderCommand
    {
        private Transform _levelHolder;
        public OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }
        
        public void Execute(byte levelIndex)
        {
            // levelIndex numaralı prefab'ı Prefabs/LevelPrefabs/ dosyası içinde oluşturdu.
            // Bu prefab LevelHolder gameobject'inin altına açıldı ( _levelHolder, true )
            // ( _levelHolder değişkeni LevelHolder'ı tutmakta )
            Object.Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level {levelIndex}"), _levelHolder, true);
        }
    }
}