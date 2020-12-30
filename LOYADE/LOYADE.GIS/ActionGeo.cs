using System;
using System.Collections.Generic;
using System.Drawing;

namespace LOYADE.GIS
{
    public class ActionGeo
    {
        public static float ResolutionX = 1;
        public static float ResolutionY = 1;
        public static PointF ScreenCenterF = new PointF(0, 0);
        public static PointF GeoCenterF;
        public static PointF GeoMinF;
        public static PointF GeoMaxF;
        public static float Scale;

        public static void InitializeGISData(float scale, PointF geocenter, PointF geomin, PointF geomax)
        {
            Scale = scale;
            GeoCenterF = geocenter;
            GeoMinF = geomin;
            GeoMaxF = geomax;
        }

        public static void FitResolution()
        {
            if (ResolutionX > ResolutionY)
            {
                ResolutionX = ResolutionY;
            }
            else
            {
                ResolutionY = ResolutionX;
            }
        }

        public static float GetScreenX(float geolon)
        {
            float x = geolon * Scale;
            return x;
        }

        public static float GetScreenY(float geolat)
        {
            float y = -geolat * Scale;
            return y;
        }

        public static float GetGeoLon(float screenx)
        {
            float lon = screenx / Scale;
            return lon;
        }

        public static float GetGeoLat(float screeny)
        {
            float lat = -screeny / Scale;
            return lat;
        }
    }


}
