using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Core
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Collider2D))]
    public class GeoView : MonoBehaviour, IPoolable<IMemoryPool>, IDisposable
    {
        private IMemoryPool _pool;
        private Rigidbody2D _rigidbody;
        public event Action<GeoView> Obtained;

        private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();
        public void Dispose() => _pool?.Despawn(this);
        public void SetVelocity(Vector2 velocity) => _rigidbody.velocity = velocity;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == Constants.PlayerLayer)
            {
                Obtained?.Invoke(this);
            }
        }

        void IPoolable<IMemoryPool>.OnDespawned()
        {
            _pool = null;
        }
        void IPoolable<IMemoryPool>.OnSpawned(IMemoryPool pool)
        {
            _pool = pool;
        }

        public class Factory : PlaceholderFactory<GeoView> 
        {
            private LinkedList<GeoView> _geos = new LinkedList<GeoView>();
            public override GeoView Create()
            {
                GeoView geo = base.Create();
                geo.Obtained += OnGeoObtained;
                _geos.AddLast(geo);
                return geo;
            }
            private void OnGeoObtained(GeoView geo)
            {
                _geos.Remove(geo);
                geo.Obtained -= OnGeoObtained;
            }
            public void Dispose()
            {
                while (_geos.Count > 0)
                {
                    _geos.First.Value.Dispose();
                }
            }
        }
    }
}