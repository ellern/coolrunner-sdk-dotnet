using System;

namespace CoolRunner.SDK
{
    internal static partial class Endpoints
    {
        public static Uri Me() => "v1/me".FormatUri();

        public static Uri PCN(string type, string action) => $"pcn/{type}/{action}".FormatUri();

        public static Uri Shipments(string action) => $"v1/shipment/{action}".FormatUri();
        public static Uri Shipments(string action, int shipmentId) => $"v1/shipment/{action}/{shipmentId}".FormatUri();

        public static Uri PDF(string uniqueId) => $"v1/pdf/{uniqueId}".FormatUri();

        public static Uri DropPoints(string carrier) => $"v1/droppoints/{carrier}".FormatUri();

        public static Uri FreightRates(string countryCode) => $"v1/freight_rates/{countryCode}".FormatUri();

        public static Uri Insurance(string action) => $"v1/insurance/{action}".FormatUri();

        public static Uri Manifests(string action) => $"v1/manifest/{action}".FormatUri();

        public static Uri Tracking(string packageNumber) => $"v1/tracking/{packageNumber}".FormatUri();
    }
}
