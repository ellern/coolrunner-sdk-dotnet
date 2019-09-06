using System;

namespace CoolRunner.SDK
{
    internal static partial class Endpoints
    {
        public static Uri Me() => "me".FormatUri();

        public static Uri Shipments(string action) => $"shipment/{action}".FormatUri();
        public static Uri Shipments(string action, int shipmentId) => $"shipment/{action}/{shipmentId}".FormatUri();

        public static Uri PDF(string uniqueId) => $"pdf/{uniqueId}".FormatUri();

        public static Uri DropPoints(string carrier) => $"droppoints/{carrier}".FormatUri();

        public static Uri FreightRates(string countryCode) => $"freight_rates/{countryCode}".FormatUri();

        public static Uri Insurance(string action) => $"insurance/{action}".FormatUri();

        public static Uri Manifests(string action) => $"manifest/{action}".FormatUri();

        public static Uri Tracking(int packageNumber) => $"tracking/{packageNumber}".FormatUri();
    }
}
