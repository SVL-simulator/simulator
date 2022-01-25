/**
 * Copyright (c) 2020-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

namespace Simulator.ScenarioEditor.Utilities
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Castle.Core.Internal;
    using Elements;
    using Managers;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// Pooling mechanism for prefabs in the visual scenario editor
    /// </summary>
    public class PrefabsPools : MonoBehaviour
    {
        /// <summary>
        /// Pool handling a single prefab instances
        /// </summary>
        private class PrefabPool
        {
            /// <summary>
            /// Transform parent where the unused instances are stored
            /// </summary>
            private readonly Transform poolParent;

            /// <summary>
            /// Origin prefab, used to populate more instances if needed
            /// </summary>
            private readonly GameObject originPrefab;

            /// <summary>
            /// All unused prefab instances
            /// </summary>
            private readonly List<GameObject> instances = new List<GameObject>();

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="parent">Transform parent where the unused instances are stored</param>
            /// <param name="prefab">Origin prefab, used to populate more instances if needed</param>
            public PrefabPool(Transform parent, GameObject prefab)
            {
                poolParent = parent;
                originPrefab = prefab;
            }

            /// <summary>
            /// Get a single prefab instance
            /// </summary>
            /// <returns>Prefab instance ready to be used</returns>
            public GameObject GetInstance()
            {
                if (instances.Count > 0)
                {
                    var id = instances.Count - 1;
                    var instance = instances[id];
                    instances.RemoveAt(id);
                    return instance;
                }

                return Populate();
            }

            /// <summary>
            /// Return instance to the pool
            /// </summary>
            /// <param name="instance">Instance that is no longer used and can be reused later</param>
            public void ReleaseInstance(GameObject instance)
            {
                instance.transform.SetParent(poolParent);
                instances.Add(instance);
            }

            /// <summary>
            /// Instantiates another object from the prefab
            /// </summary>
            /// <returns>Instance ready to be used</returns>
            private GameObject Populate()
            {
                var instance = Instantiate(originPrefab, poolParent);
                return instance;
            }
        }

        /// <inheritdoc/>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// Dictionary of all prefab pools accessed by the prefab reference
        /// </summary>
        private Dictionary<GameObject, PrefabPool> prefabPools = new Dictionary<GameObject, PrefabPool>();

        /// <summary>
        /// Dictionary of prefab pools corresponding to the used instance reference
        /// </summary>
        private Dictionary<GameObject, PrefabPool> instanceToPool = new Dictionary<GameObject, PrefabPool>();
        
        /// <inheritdoc/>
        public Task Initialize()
        {
            if (IsInitialized)
                return Task.CompletedTask;
            gameObject.SetActive(false);
            IsInitialized = true;
            Debug.Log($"{GetType().Name} scenario editor extension has been initialized.");
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public void Deinitialize()
        {
            if (!IsInitialized)
                return;
            IsInitialized = false;
            Debug.Log($"{GetType().Name} scenario editor extension has been deinitialized.");
        }

        /// <summary>
        /// Gets a unused prefab instance
        /// </summary>
        /// <param name="prefab">Prefab which instance will be retrieved</param>
        /// <returns>Unused prefab instance</returns>
        public GameObject GetInstance(GameObject prefab)
        {
            if (prefab == null)
                return null;
            
            if (!prefabPools.TryGetValue(prefab, out var pool))
            {
                var poolParent = new GameObject(prefab.name);
                SceneManager.MoveGameObjectToScene(poolParent, gameObject.scene);
                poolParent.transform.SetParent(transform);
                pool = new PrefabPool(poolParent.transform, prefab);
                prefabPools.Add(prefab, pool);
            }

            var instance = pool.GetInstance();
            instanceToPool.Add(instance, pool);
            return instance;
        }

        /// <summary>
        /// Checks if passed instance was created by the pool
        /// </summary>
        /// <param name="instance"></param>
        public bool IsInstanceFromPool(GameObject instance)
        {
            return instance != null && instanceToPool.ContainsKey(instance);
        }

        /// <summary>
        /// Returns the prefab instance back to the pool
        /// </summary>
        /// <param name="instance">Instance that is no longer used and can be reused later</param>
        public void ReturnInstance(GameObject instance)
        {
            if (instance == null)
                return;
            if (!instanceToPool.TryGetValue(instance, out var pool))
            {
                Debug.LogWarning("Passed instance cannot be returned to the pool as it was not found in the register.");
                return;
            }

            pool.ReleaseInstance(instance);
            instanceToPool.Remove(instance);
        }

        private void ValidateClones(GameObject origin, GameObject clone)
        {
            if (instanceToPool.TryGetValue(origin, out var pool))
                instanceToPool.Add(clone, pool);
            
            for (var i = 0; i < origin.transform.childCount; i++)
            {
                var originChild = origin.transform.GetChild(i).gameObject;
                var cloneChild = clone.transform.GetChild(i).gameObject;
                if (cloneChild != null)
                    ValidateClones(originChild, cloneChild);
            }

            var clonedElements = clone.GetComponents<ScenarioElement>();
            var originElements = origin.GetComponents<ScenarioElement>();
            foreach (var clonedElement in clonedElements)
            {
                var originElement = originElements.Find(e => e.GetType() == clonedElement.GetType());
                clonedElement.CopyProperties(originElement);
            }
        }

        public GameObject Clone(GameObject origin)
        {
            var clone = Instantiate(origin, origin.transform.parent);
            ValidateClones(origin, clone);
            return clone;
        }
    }
}