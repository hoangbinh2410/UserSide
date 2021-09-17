using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookTaxi.Droid;
using System.Collections.Concurrent;
using Xamarin.Forms.GoogleMaps;
using AndroidBitmapDescriptor = Android.Gms.Maps.Model.BitmapDescriptor;
using Xamarin.Forms.GoogleMaps.Android.Factories;
using AndroidBitmapDescriptorFactory = Android.Gms.Maps.Model.BitmapDescriptorFactory;

namespace BookTaxi.Droid
{
    public sealed class CachingNativeBitmapDescriptorFactory : IBitmapDescriptorFactory
    {
        private readonly ConcurrentDictionary<string, AndroidBitmapDescriptor> _cache
            = new ConcurrentDictionary<string, AndroidBitmapDescriptor>();

        public AndroidBitmapDescriptor ToNative(BitmapDescriptor descriptor)
        {
            var defaultFactory = DefaultBitmapDescriptorFactory.Instance;

            if (!string.IsNullOrEmpty(descriptor.Id))
            {
                var cacheEntry = _cache.GetOrAdd(descriptor.Id, _ => defaultFactory.ToNative(descriptor));
                return cacheEntry;
            }

            return defaultFactory.ToNative(descriptor);
            //int iconId = 0;
            //switch (descriptor.Id)
            //{
            //    case "cartaxi":
            //        iconId = Resource.Drawable.cartaxi;
            //        break;
            //    //case "beer":
            //    //    iconId = Resource.Drawable.beer;
            //    //    break;
            //}
            //return AndroidBitmapDescriptorFactory.FromResource(iconId);
        }
    }
}