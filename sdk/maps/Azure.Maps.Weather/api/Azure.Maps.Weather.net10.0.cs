namespace Azure.Maps.Weather
{
    public partial class ActiveStorm : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ActiveStorm>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStorm>
    {
        internal ActiveStorm() { }
        public Azure.Maps.Weather.BasinId? BasinId { get { throw null; } }
        public int? GovId { get { throw null; } }
        public bool? IsActive { get { throw null; } }
        public bool? IsSubtropical { get { throw null; } }
        public string Name { get { throw null; } }
        public string Year { get { throw null; } }
        protected virtual Azure.Maps.Weather.ActiveStorm JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.ActiveStorm PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.ActiveStorm System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ActiveStorm>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ActiveStorm>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.ActiveStorm System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStorm>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStorm>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStorm>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ActiveStormResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ActiveStormResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStormResult>
    {
        internal ActiveStormResult() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.ActiveStorm> ActiveStorms { get { throw null; } }
        public string NextLink { get { throw null; } }
        protected virtual Azure.Maps.Weather.ActiveStormResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.ActiveStormResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.ActiveStormResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.ActiveStormResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ActiveStormResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ActiveStormResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.ActiveStormResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStormResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStormResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ActiveStormResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AirAndPollen : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirAndPollen>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirAndPollen>
    {
        internal AirAndPollen() { }
        public string AirQualityType { get { throw null; } }
        public string Category { get { throw null; } }
        public int? CategoryValue { get { throw null; } }
        public string Description { get { throw null; } }
        public int? Value { get { throw null; } }
        protected virtual Azure.Maps.Weather.AirAndPollen JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.AirAndPollen PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.AirAndPollen System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirAndPollen>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirAndPollen>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.AirAndPollen System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirAndPollen>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirAndPollen>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirAndPollen>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AirQuality : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirQuality>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQuality>
    {
        internal AirQuality() { }
        public string Category { get { throw null; } }
        public string CategoryColor { get { throw null; } }
        public string Description { get { throw null; } }
        public Azure.Maps.Weather.DominantPollutant? DominantPollutant { get { throw null; } }
        public float? GlobalIndex { get { throw null; } }
        public float? Index { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.Pollutant> Pollutants { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        protected virtual Azure.Maps.Weather.AirQuality JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.AirQuality PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.AirQuality System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirQuality>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirQuality>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.AirQuality System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQuality>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQuality>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQuality>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AirQualityResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirQualityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQualityResult>
    {
        internal AirQualityResult() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.AirQuality> AirQualityResults { get { throw null; } }
        public string NextLink { get { throw null; } }
        protected virtual Azure.Maps.Weather.AirQualityResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.AirQualityResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.AirQualityResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.AirQualityResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirQualityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AirQualityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.AirQualityResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQualityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQualityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AirQualityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AlertDetails : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AlertDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AlertDetails>
    {
        internal AlertDetails() { }
        public string Description { get { throw null; } }
        public string Details { get { throw null; } }
        public System.DateTimeOffset? EndTime { get { throw null; } }
        public string Language { get { throw null; } }
        public Azure.Maps.Weather.LatestStatus LatestStatus { get { throw null; } }
        public string Name { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } }
        protected virtual Azure.Maps.Weather.AlertDetails JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.AlertDetails PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.AlertDetails System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AlertDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.AlertDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.AlertDetails System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AlertDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AlertDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.AlertDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AzureMapsWeatherContext : System.ClientModel.Primitives.ModelReaderWriterContext
    {
        internal AzureMapsWeatherContext() { }
        public static Azure.Maps.Weather.AzureMapsWeatherContext Default { get { throw null; } }
        protected override bool TryGetTypeBuilderCore(System.Type type, out System.ClientModel.Primitives.ModelReaderWriterTypeBuilder builder) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BasinId : System.IEquatable<Azure.Maps.Weather.BasinId>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BasinId(string value) { throw null; }
        public static Azure.Maps.Weather.BasinId AL { get { throw null; } }
        public static Azure.Maps.Weather.BasinId CP { get { throw null; } }
        public static Azure.Maps.Weather.BasinId EP { get { throw null; } }
        public static Azure.Maps.Weather.BasinId NI { get { throw null; } }
        public static Azure.Maps.Weather.BasinId NP { get { throw null; } }
        public static Azure.Maps.Weather.BasinId SI { get { throw null; } }
        public static Azure.Maps.Weather.BasinId SP { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.BasinId other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.BasinId left, Azure.Maps.Weather.BasinId right) { throw null; }
        public static implicit operator Azure.Maps.Weather.BasinId (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.BasinId? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.BasinId left, Azure.Maps.Weather.BasinId right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ColorValue : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ColorValue>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ColorValue>
    {
        internal ColorValue() { }
        public int? Blue { get { throw null; } }
        public int? Green { get { throw null; } }
        public string Hex { get { throw null; } }
        public int? Red { get { throw null; } }
        protected virtual Azure.Maps.Weather.ColorValue JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.ColorValue PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.ColorValue System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ColorValue>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ColorValue>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.ColorValue System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ColorValue>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ColorValue>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ColorValue>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CurrentConditions : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.CurrentConditions>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditions>
    {
        internal CurrentConditions() { }
        public Azure.Maps.Weather.WeatherValue ApparentTemperature { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue CloudCeiling { get { throw null; } }
        public int? CloudCover { get { throw null; } }
        public System.DateTimeOffset? DateTime { get { throw null; } }
        public string Description { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue DewPoint { get { throw null; } }
        public bool? HasPrecipitation { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public bool? IsDaytime { get { throw null; } }
        public string ObstructionsToVisibility { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue PastTwentyFourHourTemperatureDeparture { get { throw null; } }
        public Azure.Maps.Weather.PrecipitationSummary PrecipitationSummary { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Pressure { get { throw null; } }
        public Azure.Maps.Weather.PressureTendency PressureTendency { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue RealFeelTemperature { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue RealFeelTemperatureShade { get { throw null; } }
        public int? RelativeHumidity { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Temperature { get { throw null; } }
        public Azure.Maps.Weather.TemperatureSummary TemperatureSummary { get { throw null; } }
        public int? UvIndex { get { throw null; } }
        public string UvIndexDescription { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Visibility { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue WetBulbTemperature { get { throw null; } }
        public Azure.Maps.Weather.WindDetails Wind { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue WindChillTemperature { get { throw null; } }
        public Azure.Maps.Weather.WindDetails WindGust { get { throw null; } }
        protected virtual Azure.Maps.Weather.CurrentConditions JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.CurrentConditions PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.CurrentConditions System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.CurrentConditions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.CurrentConditions>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.CurrentConditions System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditions>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditions>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditions>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CurrentConditionsResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.CurrentConditionsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditionsResult>
    {
        internal CurrentConditionsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.CurrentConditions> Results { get { throw null; } }
        protected virtual Azure.Maps.Weather.CurrentConditionsResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.CurrentConditionsResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.CurrentConditionsResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.CurrentConditionsResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.CurrentConditionsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.CurrentConditionsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.CurrentConditionsResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditionsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditionsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.CurrentConditionsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyAirQuality : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyAirQuality>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQuality>
    {
        internal DailyAirQuality() { }
        public string Category { get { throw null; } }
        public string CategoryColor { get { throw null; } }
        public string Description { get { throw null; } }
        public Azure.Maps.Weather.DominantPollutant? DominantPollutant { get { throw null; } }
        public float? GlobalIndex { get { throw null; } }
        public float? Index { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyAirQuality JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyAirQuality PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyAirQuality System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyAirQuality>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyAirQuality>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyAirQuality System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQuality>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQuality>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQuality>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyAirQualityForecastResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyAirQualityForecastResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQualityForecastResult>
    {
        internal DailyAirQualityForecastResult() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.DailyAirQuality> AirQualityResults { get { throw null; } }
        public string NextLink { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyAirQualityForecastResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.DailyAirQualityForecastResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.DailyAirQualityForecastResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyAirQualityForecastResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyAirQualityForecastResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyAirQualityForecastResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyAirQualityForecastResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQualityForecastResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQualityForecastResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyAirQualityForecastResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DailyDuration : System.IEquatable<Azure.Maps.Weather.DailyDuration>
    {
        private readonly int _dummyPrimitive;
        public DailyDuration(long value) { throw null; }
        public static Azure.Maps.Weather.DailyDuration FiveDays { get { throw null; } }
        public static Azure.Maps.Weather.DailyDuration FourDays { get { throw null; } }
        public static Azure.Maps.Weather.DailyDuration OneDay { get { throw null; } }
        public static Azure.Maps.Weather.DailyDuration SevenDays { get { throw null; } }
        public static Azure.Maps.Weather.DailyDuration SixDays { get { throw null; } }
        public static Azure.Maps.Weather.DailyDuration ThreeDays { get { throw null; } }
        public static Azure.Maps.Weather.DailyDuration TwoDays { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.DailyDuration other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.DailyDuration left, Azure.Maps.Weather.DailyDuration right) { throw null; }
        public static implicit operator Azure.Maps.Weather.DailyDuration (long value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.DailyDuration left, Azure.Maps.Weather.DailyDuration right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DailyForecast : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecast>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecast>
    {
        internal DailyForecast() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.AirAndPollen> AirQuality { get { throw null; } }
        public System.DateTimeOffset? DateTime { get { throw null; } }
        public Azure.Maps.Weather.DailyForecastDetail DaytimeForecast { get { throw null; } }
        public float? HoursOfSun { get { throw null; } }
        public Azure.Maps.Weather.DegreeDaySummary MeanTemperatureDeviation { get { throw null; } }
        public Azure.Maps.Weather.DailyForecastDetail NighttimeForecast { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueRange RealFeelTemperature { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueRange RealFeelTemperatureShade { get { throw null; } }
        public System.Collections.Generic.IList<string> Sources { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueRange Temperature { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyForecast JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyForecast PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyForecast System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecast>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecast>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyForecast System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecast>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecast>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecast>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyForecastDetail : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastDetail>
    {
        internal DailyForecastDetail() { }
        public int? CloudCover { get { throw null; } }
        public bool? HasPrecipitation { get { throw null; } }
        public float? HoursOfIce { get { throw null; } }
        public float? HoursOfPrecipitation { get { throw null; } }
        public float? HoursOfRain { get { throw null; } }
        public float? HoursOfSnow { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Ice { get { throw null; } }
        public int? IceProbability { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public string IconPhrase { get { throw null; } }
        public Azure.Maps.Weather.LocalSource LocalSource { get { throw null; } }
        public string LongPhrase { get { throw null; } }
        public string PrecipitationIntensity { get { throw null; } }
        public int? PrecipitationProbability { get { throw null; } }
        public Azure.Maps.Weather.PrecipitationType? PrecipitationType { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Rain { get { throw null; } }
        public int? RainProbability { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Snow { get { throw null; } }
        public int? SnowProbability { get { throw null; } }
        public int? ThunderstormProbability { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue TotalLiquid { get { throw null; } }
        public Azure.Maps.Weather.WindDetails Wind { get { throw null; } }
        public Azure.Maps.Weather.WindDetails WindGust { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyForecastDetail JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyForecastDetail PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyForecastDetail System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyForecastDetail System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyForecastResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastResult>
    {
        internal DailyForecastResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.DailyForecast> Forecasts { get { throw null; } }
        public Azure.Maps.Weather.DailyForecastSummary Summary { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyForecastResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.DailyForecastResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.DailyForecastResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyForecastResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyForecastResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyForecastSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastSummary>
    {
        internal DailyForecastSummary() { }
        public string Category { get { throw null; } }
        public System.DateTimeOffset? EndDate { get { throw null; } }
        public string Phrase { get { throw null; } }
        public int? Severity { get { throw null; } }
        public System.DateTimeOffset? StartDate { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyForecastSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyForecastSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyForecastSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyForecastSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyForecastSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyForecastSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyHistoricalActuals : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalActuals>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActuals>
    {
        internal DailyHistoricalActuals() { }
        public Azure.Maps.Weather.DegreeDaySummary DegreeDaySummary { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Precipitation { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue SnowDepth { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Snowfall { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueMaxMinAvg Temperature { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyHistoricalActuals JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyHistoricalActuals PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyHistoricalActuals System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalActuals>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalActuals>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyHistoricalActuals System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActuals>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActuals>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActuals>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyHistoricalActualsResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalActualsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActualsResult>
    {
        internal DailyHistoricalActualsResult() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.DailyHistoricalActuals> HistoricalActuals { get { throw null; } }
        public string NextLink { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyHistoricalActualsResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.DailyHistoricalActualsResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.DailyHistoricalActualsResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyHistoricalActualsResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalActualsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalActualsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyHistoricalActualsResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActualsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActualsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalActualsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyHistoricalNormals : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalNormals>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormals>
    {
        internal DailyHistoricalNormals() { }
        public Azure.Maps.Weather.DegreeDaySummary DegreeDaySummary { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Precipitation { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueMaxMinAvg Temperature { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyHistoricalNormals JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyHistoricalNormals PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyHistoricalNormals System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalNormals>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalNormals>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyHistoricalNormals System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormals>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormals>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormals>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyHistoricalNormalsResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>
    {
        internal DailyHistoricalNormalsResult() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.DailyHistoricalNormals> HistoricalNormals { get { throw null; } }
        public string NextLink { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyHistoricalNormalsResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.DailyHistoricalNormalsResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.DailyHistoricalNormalsResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyHistoricalNormalsResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyHistoricalNormalsResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalNormalsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyHistoricalRecords : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalRecords>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecords>
    {
        internal DailyHistoricalRecords() { }
        public Azure.Maps.Weather.WeatherValueYearMax Precipitation { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueYearMax Snowfall { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueYearMaxMinAvg Temperature { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyHistoricalRecords JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyHistoricalRecords PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyHistoricalRecords System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalRecords>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalRecords>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyHistoricalRecords System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecords>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecords>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecords>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyHistoricalRecordsResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>
    {
        internal DailyHistoricalRecordsResult() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.DailyHistoricalRecords> HistoricalRecords { get { throw null; } }
        public string NextLink { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyHistoricalRecordsResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.DailyHistoricalRecordsResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.DailyHistoricalRecordsResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyHistoricalRecordsResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyHistoricalRecordsResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyHistoricalRecordsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyIndex : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyIndex>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndex>
    {
        internal DailyIndex() { }
        public string CategoryDescription { get { throw null; } }
        public int? CategoryValue { get { throw null; } }
        public System.DateTimeOffset? DateTime { get { throw null; } }
        public string Description { get { throw null; } }
        public int? IndexId { get { throw null; } }
        public string IndexName { get { throw null; } }
        public bool? IsAscending { get { throw null; } }
        public float? Value { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyIndex JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DailyIndex PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyIndex System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyIndex>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyIndex>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyIndex System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndex>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndex>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndex>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DailyIndicesResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyIndicesResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndicesResult>
    {
        internal DailyIndicesResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.DailyIndex> Results { get { throw null; } }
        protected virtual Azure.Maps.Weather.DailyIndicesResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.DailyIndicesResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.DailyIndicesResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DailyIndicesResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyIndicesResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DailyIndicesResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DailyIndicesResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndicesResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndicesResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DailyIndicesResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DayQuarter : System.IEquatable<Azure.Maps.Weather.DayQuarter>
    {
        private readonly int _dummyPrimitive;
        public DayQuarter(long value) { throw null; }
        public static Azure.Maps.Weather.DayQuarter FirstQuarter { get { throw null; } }
        public static Azure.Maps.Weather.DayQuarter ForthQuarter { get { throw null; } }
        public static Azure.Maps.Weather.DayQuarter SecondQuarter { get { throw null; } }
        public static Azure.Maps.Weather.DayQuarter ThirdQuarter { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.DayQuarter other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.DayQuarter left, Azure.Maps.Weather.DayQuarter right) { throw null; }
        public static implicit operator Azure.Maps.Weather.DayQuarter (long value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.DayQuarter left, Azure.Maps.Weather.DayQuarter right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DegreeDaySummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DegreeDaySummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DegreeDaySummary>
    {
        internal DegreeDaySummary() { }
        public Azure.Maps.Weather.WeatherValue Cooling { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Heating { get { throw null; } }
        protected virtual Azure.Maps.Weather.DegreeDaySummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.DegreeDaySummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.DegreeDaySummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DegreeDaySummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.DegreeDaySummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.DegreeDaySummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DegreeDaySummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DegreeDaySummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.DegreeDaySummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DominantPollutant : System.IEquatable<Azure.Maps.Weather.DominantPollutant>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DominantPollutant(string value) { throw null; }
        public static Azure.Maps.Weather.DominantPollutant CarbonMonoxide { get { throw null; } }
        public static Azure.Maps.Weather.DominantPollutant NitrogenDioxide { get { throw null; } }
        public static Azure.Maps.Weather.DominantPollutant Ozone { get { throw null; } }
        public static Azure.Maps.Weather.DominantPollutant ParticulateMatter10 { get { throw null; } }
        public static Azure.Maps.Weather.DominantPollutant ParticulateMatter25 { get { throw null; } }
        public static Azure.Maps.Weather.DominantPollutant SulfurDioxide { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.DominantPollutant other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.DominantPollutant left, Azure.Maps.Weather.DominantPollutant right) { throw null; }
        public static implicit operator Azure.Maps.Weather.DominantPollutant (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.DominantPollutant? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.DominantPollutant left, Azure.Maps.Weather.DominantPollutant right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ForecastInterval : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ForecastInterval>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ForecastInterval>
    {
        internal ForecastInterval() { }
        public int? CloudCover { get { throw null; } }
        public Azure.Maps.Weather.ColorValue Color { get { throw null; } }
        public double? DecibelRelativeToZ { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public int? Minute { get { throw null; } }
        public Azure.Maps.Weather.PrecipitationType? PrecipitationType { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        public Azure.Maps.Weather.ColorValue SimplifiedColor { get { throw null; } }
        public System.DateTimeOffset? StartTime { get { throw null; } }
        public string Threshold { get { throw null; } }
        protected virtual Azure.Maps.Weather.ForecastInterval JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.ForecastInterval PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.ForecastInterval System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ForecastInterval>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.ForecastInterval>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.ForecastInterval System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ForecastInterval>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ForecastInterval>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.ForecastInterval>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public abstract partial class GeoJsonGeometry : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonGeometry>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometry>
    {
        internal GeoJsonGeometry() { }
        protected virtual Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonGeometry System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonGeometry>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonGeometry>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonGeometry System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometry>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometry>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometry>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonGeometryCollection : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonGeometryCollection>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometryCollection>
    {
        internal GeoJsonGeometryCollection() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.GeoJsonGeometry> Geometries { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonGeometryCollection System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonGeometryCollection>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonGeometryCollection>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonGeometryCollection System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometryCollection>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometryCollection>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonGeometryCollection>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonLineString : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonLineString>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonLineString>
    {
        internal GeoJsonLineString() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<double>> Coordinates { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonLineString System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonLineString>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonLineString>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonLineString System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonLineString>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonLineString>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonLineString>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonMultiLineString : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiLineString>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiLineString>
    {
        internal GeoJsonMultiLineString() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<double>>> Coordinates { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonMultiLineString System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiLineString>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiLineString>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonMultiLineString System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiLineString>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiLineString>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiLineString>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonMultiPoint : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiPoint>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPoint>
    {
        internal GeoJsonMultiPoint() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<double>> Coordinates { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonMultiPoint System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiPoint>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiPoint>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonMultiPoint System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPoint>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPoint>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPoint>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonMultiPolygon : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiPolygon>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPolygon>
    {
        internal GeoJsonMultiPolygon() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<double>>>> Coordinates { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonMultiPolygon System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiPolygon>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonMultiPolygon>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonMultiPolygon System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPolygon>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPolygon>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonMultiPolygon>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonPoint : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonPoint>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPoint>
    {
        internal GeoJsonPoint() { }
        public System.Collections.Generic.IList<double> Coordinates { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonPoint System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonPoint>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonPoint>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonPoint System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPoint>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPoint>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPoint>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class GeoJsonPolygon : Azure.Maps.Weather.GeoJsonGeometry, System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonPolygon>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPolygon>
    {
        internal GeoJsonPolygon() { }
        public System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<double>>> Coordinates { get { throw null; } }
        protected override Azure.Maps.Weather.GeoJsonGeometry JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected override Azure.Maps.Weather.GeoJsonGeometry PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected override System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.GeoJsonPolygon System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonPolygon>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.GeoJsonPolygon>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.GeoJsonPolygon System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPolygon>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPolygon>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.GeoJsonPolygon>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HazardDetail : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HazardDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HazardDetail>
    {
        internal HazardDetail() { }
        public string HazardCode { get { throw null; } }
        public Azure.Maps.Weather.HazardIndex? HazardIndex { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        protected virtual Azure.Maps.Weather.HazardDetail JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.HazardDetail PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.HazardDetail System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HazardDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HazardDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.HazardDetail System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HazardDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HazardDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HazardDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HazardIndex : System.IEquatable<Azure.Maps.Weather.HazardIndex>
    {
        private readonly int _dummyPrimitive;
        public HazardIndex(long value) { throw null; }
        public static Azure.Maps.Weather.HazardIndex Emergency { get { throw null; } }
        public static Azure.Maps.Weather.HazardIndex Informed { get { throw null; } }
        public static Azure.Maps.Weather.HazardIndex NoHazard { get { throw null; } }
        public static Azure.Maps.Weather.HazardIndex PayAttention { get { throw null; } }
        public static Azure.Maps.Weather.HazardIndex TakeAction { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.HazardIndex other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.HazardIndex left, Azure.Maps.Weather.HazardIndex right) { throw null; }
        public static implicit operator Azure.Maps.Weather.HazardIndex (long value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.HazardIndex left, Azure.Maps.Weather.HazardIndex right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HourlyDuration : System.IEquatable<Azure.Maps.Weather.HourlyDuration>
    {
        private readonly int _dummyPrimitive;
        public HourlyDuration(long value) { throw null; }
        public static Azure.Maps.Weather.HourlyDuration FortyEightHours { get { throw null; } }
        public static Azure.Maps.Weather.HourlyDuration NinetySixHours { get { throw null; } }
        public static Azure.Maps.Weather.HourlyDuration OneHour { get { throw null; } }
        public static Azure.Maps.Weather.HourlyDuration SeventyTwoHours { get { throw null; } }
        public static Azure.Maps.Weather.HourlyDuration TwelveHours { get { throw null; } }
        public static Azure.Maps.Weather.HourlyDuration TwentyFourHours { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.HourlyDuration other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.HourlyDuration left, Azure.Maps.Weather.HourlyDuration right) { throw null; }
        public static implicit operator Azure.Maps.Weather.HourlyDuration (long value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.HourlyDuration left, Azure.Maps.Weather.HourlyDuration right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HourlyForecast : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HourlyForecast>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecast>
    {
        internal HourlyForecast() { }
        public Azure.Maps.Weather.WeatherValue CloudCeiling { get { throw null; } }
        public int? CloudCover { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue DewPoint { get { throw null; } }
        public bool? HasPrecipitation { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Ice { get { throw null; } }
        public int? IceProbability { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public string IconPhrase { get { throw null; } }
        public bool? IsDaylight { get { throw null; } }
        public int? PrecipitationProbability { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Rain { get { throw null; } }
        public int? RainProbability { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue RealFeelTemperature { get { throw null; } }
        public int? RelativeHumidity { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Snow { get { throw null; } }
        public int? SnowProbability { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Temperature { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue TotalLiquid { get { throw null; } }
        public int? UvIndex { get { throw null; } }
        public string UvIndexDescription { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Visibility { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue WetBulbTemperature { get { throw null; } }
        public Azure.Maps.Weather.WindDetails Wind { get { throw null; } }
        public Azure.Maps.Weather.WindDetails WindGust { get { throw null; } }
        protected virtual Azure.Maps.Weather.HourlyForecast JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.HourlyForecast PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.HourlyForecast System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HourlyForecast>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HourlyForecast>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.HourlyForecast System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecast>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecast>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecast>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class HourlyForecastResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HourlyForecastResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecastResult>
    {
        internal HourlyForecastResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.HourlyForecast> Forecasts { get { throw null; } }
        protected virtual Azure.Maps.Weather.HourlyForecastResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.HourlyForecastResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.HourlyForecastResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.HourlyForecastResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HourlyForecastResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.HourlyForecastResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.HourlyForecastResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecastResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecastResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.HourlyForecastResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IconCode : System.IEquatable<Azure.Maps.Weather.IconCode>
    {
        private readonly int _dummyPrimitive;
        public IconCode(long value) { throw null; }
        public static Azure.Maps.Weather.IconCode Clear { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Cloudy { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Cold { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Dreary { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Flurries { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Fog { get { throw null; } }
        public static Azure.Maps.Weather.IconCode FreezingRain { get { throw null; } }
        public static Azure.Maps.Weather.IconCode HazyMoonlight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode HazySunshine { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Hot { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Ice { get { throw null; } }
        public static Azure.Maps.Weather.IconCode IntermittentClouds { get { throw null; } }
        public static Azure.Maps.Weather.IconCode IntermittentCloudsNight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyClear { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudy { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyNight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithFlurries { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithFlurriesNight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithShowers { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithShowersNight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithSnow { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithSnowNight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithThunderstorms { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlyCloudyWithThunderstormsNight { get { throw null; } }
        public static Azure.Maps.Weather.IconCode MostlySunny { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlyCloudy { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlyCloudyWithShowers { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlyCloudyWithThunderstorms { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlySunny { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlySunnyWithFlurries { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlySunnyWithShowers { get { throw null; } }
        public static Azure.Maps.Weather.IconCode PartlySunnyWithThunderstorms { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Rain { get { throw null; } }
        public static Azure.Maps.Weather.IconCode RainAndSnow { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Showers { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Sleet { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Snow { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Sunny { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Thunderstorms { get { throw null; } }
        public static Azure.Maps.Weather.IconCode Windy { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.IconCode other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.IconCode left, Azure.Maps.Weather.IconCode right) { throw null; }
        public static implicit operator Azure.Maps.Weather.IconCode (long value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.IconCode left, Azure.Maps.Weather.IconCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IntervalSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.IntervalSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.IntervalSummary>
    {
        internal IntervalSummary() { }
        public string BriefDescription { get { throw null; } }
        public int? EndMinute { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public string LongPhrase { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        public int? StartMinute { get { throw null; } }
        public int? TotalMinutes { get { throw null; } }
        protected virtual Azure.Maps.Weather.IntervalSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.IntervalSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.IntervalSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.IntervalSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.IntervalSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.IntervalSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.IntervalSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.IntervalSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.IntervalSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct JsonFormat : System.IEquatable<Azure.Maps.Weather.JsonFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public JsonFormat(string value) { throw null; }
        public static Azure.Maps.Weather.JsonFormat Json { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.JsonFormat other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.JsonFormat left, Azure.Maps.Weather.JsonFormat right) { throw null; }
        public static implicit operator Azure.Maps.Weather.JsonFormat (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.JsonFormat? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.JsonFormat left, Azure.Maps.Weather.JsonFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LatestStatus : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LatestStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatestStatus>
    {
        internal LatestStatus() { }
        public Azure.Maps.Weather.LatestStatusKeyword? English { get { throw null; } }
        public string Localized { get { throw null; } }
        protected virtual Azure.Maps.Weather.LatestStatus JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.LatestStatus PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.LatestStatus System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LatestStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LatestStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.LatestStatus System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatestStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatestStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatestStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct LatestStatusKeyword : System.IEquatable<Azure.Maps.Weather.LatestStatusKeyword>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public LatestStatusKeyword(string value) { throw null; }
        public static Azure.Maps.Weather.LatestStatusKeyword Cancel { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword Continue { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword Correct { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword Expire { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword Extend { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword New { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword Update { get { throw null; } }
        public static Azure.Maps.Weather.LatestStatusKeyword Upgrade { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.LatestStatusKeyword other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.LatestStatusKeyword left, Azure.Maps.Weather.LatestStatusKeyword right) { throw null; }
        public static implicit operator Azure.Maps.Weather.LatestStatusKeyword (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.LatestStatusKeyword? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.LatestStatusKeyword left, Azure.Maps.Weather.LatestStatusKeyword right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LatLongPair : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LatLongPair>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatLongPair>
    {
        internal LatLongPair() { }
        public double? Latitude { get { throw null; } }
        public double? Longitude { get { throw null; } }
        protected virtual Azure.Maps.Weather.LatLongPair JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.LatLongPair PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.LatLongPair System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LatLongPair>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LatLongPair>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.LatLongPair System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatLongPair>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatLongPair>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LatLongPair>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class LocalSource : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LocalSource>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LocalSource>
    {
        internal LocalSource() { }
        public int? Id { get { throw null; } }
        public string Name { get { throw null; } }
        public string WeatherCode { get { throw null; } }
        protected virtual Azure.Maps.Weather.LocalSource JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.LocalSource PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.LocalSource System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LocalSource>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.LocalSource>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.LocalSource System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LocalSource>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LocalSource>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.LocalSource>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MapsWeatherClient
    {
        protected MapsWeatherClient() { }
        [System.Diagnostics.CodeAnalysis.ExperimentalAttribute("SCME0002")]
        public MapsWeatherClient(Azure.Maps.Weather.MapsWeatherClientSettings settings) { }
        public MapsWeatherClient(System.Uri endpoint, Azure.AzureKeyCredential credential) { }
        public MapsWeatherClient(System.Uri endpoint, Azure.AzureKeyCredential credential, Azure.Maps.Weather.MapsWeatherClientOptions options) { }
        public MapsWeatherClient(System.Uri endpoint, Azure.Core.TokenCredential credential) { }
        public MapsWeatherClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Maps.Weather.MapsWeatherClientOptions options) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
        public virtual Azure.Response<Azure.Maps.Weather.DailyAirQualityForecastResult> GetAirQualityDailyForecasts(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, Azure.Maps.Weather.DailyDuration? duration = default(Azure.Maps.Weather.DailyDuration?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetAirQualityDailyForecasts(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, long? duration = default(long?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.DailyAirQualityForecastResult>> GetAirQualityDailyForecastsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, Azure.Maps.Weather.DailyDuration? duration = default(Azure.Maps.Weather.DailyDuration?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAirQualityDailyForecastsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, long? duration = default(long?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.AirQualityResult> GetAirQualityHourlyForecasts(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, Azure.Maps.Weather.HourlyDuration? duration = default(Azure.Maps.Weather.HourlyDuration?), bool? includePollutantDetails = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetAirQualityHourlyForecasts(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, long? duration = default(long?), bool? includePollutantDetails = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.AirQualityResult>> GetAirQualityHourlyForecastsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, Azure.Maps.Weather.HourlyDuration? duration = default(Azure.Maps.Weather.HourlyDuration?), bool? includePollutantDetails = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetAirQualityHourlyForecastsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, long? duration = default(long?), bool? includePollutantDetails = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.AirQualityResult> GetCurrentAirQuality(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, bool? includePollutantDetails = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetCurrentAirQuality(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, bool? includePollutantDetails = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.AirQualityResult>> GetCurrentAirQualityAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, bool? includePollutantDetails = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCurrentAirQualityAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, bool? includePollutantDetails = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.CurrentConditionsResult> GetCurrentConditions(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), string details = null, int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetCurrentConditions(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, string details = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.CurrentConditionsResult>> GetCurrentConditionsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), string details = null, int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetCurrentConditionsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, string details = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.DailyForecastResult> GetDailyForecast(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDailyForecast(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.DailyForecastResult>> GetDailyForecastAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDailyForecastAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.DailyHistoricalActualsResult> GetDailyHistoricalActuals(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDailyHistoricalActuals(string format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, string unit = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.DailyHistoricalActualsResult>> GetDailyHistoricalActualsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDailyHistoricalActualsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, string unit = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.DailyHistoricalNormalsResult> GetDailyHistoricalNormals(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDailyHistoricalNormals(string format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, string unit = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.DailyHistoricalNormalsResult>> GetDailyHistoricalNormalsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDailyHistoricalNormalsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, string unit = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.DailyHistoricalRecordsResult> GetDailyHistoricalRecords(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDailyHistoricalRecords(string format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, string unit = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.DailyHistoricalRecordsResult>> GetDailyHistoricalRecordsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDailyHistoricalRecordsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, System.DateTimeOffset startDate, System.DateTimeOffset endDate, string clientId = null, string unit = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.DailyIndicesResult> GetDailyIndices(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, int? duration = default(int?), int? indexId = default(int?), int? indexGroupId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetDailyIndices(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, int? duration = default(int?), int? indexId = default(int?), int? indexGroupId = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.DailyIndicesResult>> GetDailyIndicesAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, int? duration = default(int?), int? indexId = default(int?), int? indexGroupId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetDailyIndicesAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, int? duration = default(int?), int? indexId = default(int?), int? indexGroupId = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.HourlyForecastResult> GetHourlyForecast(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetHourlyForecast(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.HourlyForecastResult>> GetHourlyForecastAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetHourlyForecastAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.MinuteForecastResult> GetMinuteForecast(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, int? interval = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetMinuteForecast(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, int? interval = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.MinuteForecastResult>> GetMinuteForecastAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, int? interval = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetMinuteForecastAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, int? interval = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.QuarterDayForecastResult> GetQuarterDayForecast(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetQuarterDayForecast(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.QuarterDayForecastResult>> GetQuarterDayForecastAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), int? duration = default(int?), string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetQuarterDayForecastAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string unit = null, int? duration = default(int?), string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.SevereWeatherAlertsResult> GetSevereWeatherAlerts(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, string details = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetSevereWeatherAlerts(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, string details = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.SevereWeatherAlertsResult>> GetSevereWeatherAlertsAsync(Azure.Maps.Weather.JsonFormat format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, string details = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetSevereWeatherAlertsAsync(string format, System.Collections.Generic.IEnumerable<double> coordinates, string clientId = null, string language = null, string details = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.ActiveStormResult> GetTropicalStormActive(Azure.Maps.Weather.JsonFormat format, string clientId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTropicalStormActive(string format, string clientId = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.ActiveStormResult>> GetTropicalStormActiveAsync(Azure.Maps.Weather.JsonFormat format, string clientId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTropicalStormActiveAsync(string format, string clientId = null, Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.StormForecastResult> GetTropicalStormForecast(Azure.Maps.Weather.JsonFormat format, int year, Azure.Maps.Weather.BasinId basinId, int governmentStormId, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), bool? includeWindowGeometry = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTropicalStormForecast(string format, int year, string basinId, int governmentStormId, string clientId = null, string unit = null, bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), bool? includeWindowGeometry = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.StormForecastResult>> GetTropicalStormForecastAsync(Azure.Maps.Weather.JsonFormat format, int year, Azure.Maps.Weather.BasinId basinId, int governmentStormId, string clientId = null, Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), bool? includeWindowGeometry = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTropicalStormForecastAsync(string format, int year, string basinId, int governmentStormId, string clientId = null, string unit = null, bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), bool? includeWindowGeometry = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.StormLocationsResult> GetTropicalStormLocations(Azure.Maps.Weather.JsonFormat format, int year, Azure.Maps.Weather.BasinId basinId, int governmentStormId, string clientId = null, bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), bool? includeCurrentStorm = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTropicalStormLocations(string format, int year, string basinId, int governmentStormId, string clientId = null, bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), string unit = null, bool? includeCurrentStorm = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.StormLocationsResult>> GetTropicalStormLocationsAsync(Azure.Maps.Weather.JsonFormat format, int year, Azure.Maps.Weather.BasinId basinId, int governmentStormId, string clientId = null, bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), Azure.Maps.Weather.WeatherDataUnit? unit = default(Azure.Maps.Weather.WeatherDataUnit?), bool? includeCurrentStorm = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTropicalStormLocationsAsync(string format, int year, string basinId, int governmentStormId, string clientId = null, bool? includeDetails = default(bool?), bool? includeGeometricDetails = default(bool?), string unit = null, bool? includeCurrentStorm = default(bool?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.StormSearchResult> GetTropicalStormSearch(Azure.Maps.Weather.JsonFormat format, int year, string clientId = null, Azure.Maps.Weather.BasinId? basinId = default(Azure.Maps.Weather.BasinId?), int? governmentStormId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetTropicalStormSearch(string format, int year, string clientId = null, string basinId = null, int? governmentStormId = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.StormSearchResult>> GetTropicalStormSearchAsync(Azure.Maps.Weather.JsonFormat format, int year, string clientId = null, Azure.Maps.Weather.BasinId? basinId = default(Azure.Maps.Weather.BasinId?), int? governmentStormId = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetTropicalStormSearchAsync(string format, int year, string clientId = null, string basinId = null, int? governmentStormId = default(int?), Azure.RequestContext context = null) { throw null; }
        public virtual Azure.Response<Azure.Maps.Weather.WeatherAlongRouteResult> GetWeatherAlongRoute(Azure.Maps.Weather.JsonFormat format, string query, string clientId = null, string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response GetWeatherAlongRoute(string format, string query, string clientId = null, string language = null, Azure.RequestContext context = null) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Maps.Weather.WeatherAlongRouteResult>> GetWeatherAlongRouteAsync(Azure.Maps.Weather.JsonFormat format, string query, string clientId = null, string language = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> GetWeatherAlongRouteAsync(string format, string query, string clientId = null, string language = null, Azure.RequestContext context = null) { throw null; }
    }
    [System.Diagnostics.CodeAnalysis.ExperimentalAttribute("SCME0002")]
    public static partial class MapsWeatherClientHostExtensions
    {
        public static System.ClientModel.Primitives.IClientBuilder AddKeyedMapsWeatherClient(this Microsoft.Extensions.Hosting.IHostApplicationBuilder host, string key, string sectionName) { throw null; }
        public static System.ClientModel.Primitives.IClientBuilder AddKeyedMapsWeatherClient(this Microsoft.Extensions.Hosting.IHostApplicationBuilder host, string key, string sectionName, System.Action<Azure.Maps.Weather.MapsWeatherClientSettings> configureSettings) { throw null; }
        public static System.ClientModel.Primitives.IClientBuilder AddMapsWeatherClient(this Microsoft.Extensions.Hosting.IHostApplicationBuilder host, string sectionName) { throw null; }
        public static System.ClientModel.Primitives.IClientBuilder AddMapsWeatherClient(this Microsoft.Extensions.Hosting.IHostApplicationBuilder host, string sectionName, System.Action<Azure.Maps.Weather.MapsWeatherClientSettings> configureSettings) { throw null; }
    }
    public partial class MapsWeatherClientOptions : Azure.Core.ClientOptions
    {
        public MapsWeatherClientOptions(Azure.Maps.Weather.MapsWeatherClientOptions.ServiceVersion version = Azure.Maps.Weather.MapsWeatherClientOptions.ServiceVersion.V1_1) { }
        public enum ServiceVersion
        {
            V1_1 = 1,
        }
    }
    [System.Diagnostics.CodeAnalysis.ExperimentalAttribute("SCME0002")]
    public partial class MapsWeatherClientSettings : System.ClientModel.Primitives.ClientSettings
    {
        public MapsWeatherClientSettings() { }
        public System.Uri Endpoint { get { throw null; } set { } }
        public Azure.Maps.Weather.MapsWeatherClientOptions Options { get { throw null; } set { } }
        protected override void BindCore(Microsoft.Extensions.Configuration.IConfigurationSection section) { }
    }
    public partial class MinuteForecastResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.MinuteForecastResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastResult>
    {
        internal MinuteForecastResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.ForecastInterval> Intervals { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.IntervalSummary> IntervalSummaries { get { throw null; } }
        public Azure.Maps.Weather.MinuteForecastSummary Summary { get { throw null; } }
        protected virtual Azure.Maps.Weather.MinuteForecastResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.MinuteForecastResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.MinuteForecastResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.MinuteForecastResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.MinuteForecastResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.MinuteForecastResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.MinuteForecastResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MinuteForecastSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.MinuteForecastSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastSummary>
    {
        internal MinuteForecastSummary() { }
        public string BriefDescription { get { throw null; } }
        public string BriefPhrase60 { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public string LongPhrase { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        protected virtual Azure.Maps.Weather.MinuteForecastSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.MinuteForecastSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.MinuteForecastSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.MinuteForecastSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.MinuteForecastSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.MinuteForecastSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.MinuteForecastSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PastHoursTemperature : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PastHoursTemperature>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PastHoursTemperature>
    {
        internal PastHoursTemperature() { }
        public Azure.Maps.Weather.WeatherValue Maximum { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Minimum { get { throw null; } }
        protected virtual Azure.Maps.Weather.PastHoursTemperature JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.PastHoursTemperature PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.PastHoursTemperature System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PastHoursTemperature>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PastHoursTemperature>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.PastHoursTemperature System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PastHoursTemperature>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PastHoursTemperature>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PastHoursTemperature>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class Pollutant : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.Pollutant>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.Pollutant>
    {
        internal Pollutant() { }
        public Azure.Maps.Weather.WeatherValue Concentration { get { throw null; } }
        public float? GlobalIndex { get { throw null; } }
        public float? Index { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.Maps.Weather.PollutantType? Type { get { throw null; } }
        protected virtual Azure.Maps.Weather.Pollutant JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.Pollutant PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.Pollutant System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.Pollutant>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.Pollutant>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.Pollutant System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.Pollutant>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.Pollutant>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.Pollutant>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PollutantType : System.IEquatable<Azure.Maps.Weather.PollutantType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PollutantType(string value) { throw null; }
        public static Azure.Maps.Weather.PollutantType CO { get { throw null; } }
        public static Azure.Maps.Weather.PollutantType NO2 { get { throw null; } }
        public static Azure.Maps.Weather.PollutantType O3 { get { throw null; } }
        public static Azure.Maps.Weather.PollutantType PM10 { get { throw null; } }
        public static Azure.Maps.Weather.PollutantType PM25 { get { throw null; } }
        public static Azure.Maps.Weather.PollutantType SO2 { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.PollutantType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.PollutantType left, Azure.Maps.Weather.PollutantType right) { throw null; }
        public static implicit operator Azure.Maps.Weather.PollutantType (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.PollutantType? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.PollutantType left, Azure.Maps.Weather.PollutantType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrecipitationSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PrecipitationSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PrecipitationSummary>
    {
        internal PrecipitationSummary() { }
        public Azure.Maps.Weather.WeatherValue Past12Hours { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Past18Hours { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Past24Hours { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Past3Hours { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Past6Hours { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Past9Hours { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue PastHour { get { throw null; } }
        protected virtual Azure.Maps.Weather.PrecipitationSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.PrecipitationSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.PrecipitationSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PrecipitationSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PrecipitationSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.PrecipitationSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PrecipitationSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PrecipitationSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PrecipitationSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrecipitationType : System.IEquatable<Azure.Maps.Weather.PrecipitationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrecipitationType(string value) { throw null; }
        public static Azure.Maps.Weather.PrecipitationType Ice { get { throw null; } }
        public static Azure.Maps.Weather.PrecipitationType Mix { get { throw null; } }
        public static Azure.Maps.Weather.PrecipitationType Rain { get { throw null; } }
        public static Azure.Maps.Weather.PrecipitationType Snow { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.PrecipitationType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.PrecipitationType left, Azure.Maps.Weather.PrecipitationType right) { throw null; }
        public static implicit operator Azure.Maps.Weather.PrecipitationType (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.PrecipitationType? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.PrecipitationType left, Azure.Maps.Weather.PrecipitationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PressureTendency : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PressureTendency>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PressureTendency>
    {
        internal PressureTendency() { }
        public string Code { get { throw null; } }
        public string Description { get { throw null; } }
        protected virtual Azure.Maps.Weather.PressureTendency JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.PressureTendency PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.PressureTendency System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PressureTendency>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.PressureTendency>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.PressureTendency System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PressureTendency>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PressureTendency>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.PressureTendency>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class QuarterDayForecast : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.QuarterDayForecast>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecast>
    {
        internal QuarterDayForecast() { }
        public int? CloudCover { get { throw null; } }
        public System.DateTimeOffset? DateTime { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue DewPoint { get { throw null; } }
        public System.DateTimeOffset? EffectiveDate { get { throw null; } }
        public bool? HasPrecipitation { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Ice { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public string IconPhrase { get { throw null; } }
        public string Phrase { get { throw null; } }
        public string PrecipitationIntensity { get { throw null; } }
        public int? PrecipitationProbability { get { throw null; } }
        public Azure.Maps.Weather.PrecipitationType? PrecipitationType { get { throw null; } }
        public Azure.Maps.Weather.DayQuarter? Quarter { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Rain { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueRange RealFeelTemperature { get { throw null; } }
        public int? RelativeHumidity { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Snow { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueRange Temperature { get { throw null; } }
        public int? ThunderstormProbability { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue TotalLiquid { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Visibility { get { throw null; } }
        public Azure.Maps.Weather.WindDetails Wind { get { throw null; } }
        public Azure.Maps.Weather.WindDetails WindGust { get { throw null; } }
        protected virtual Azure.Maps.Weather.QuarterDayForecast JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.QuarterDayForecast PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.QuarterDayForecast System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.QuarterDayForecast>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.QuarterDayForecast>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.QuarterDayForecast System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecast>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecast>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecast>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class QuarterDayForecastResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.QuarterDayForecastResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecastResult>
    {
        internal QuarterDayForecastResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.QuarterDayForecast> Forecasts { get { throw null; } }
        protected virtual Azure.Maps.Weather.QuarterDayForecastResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.QuarterDayForecastResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.QuarterDayForecastResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.QuarterDayForecastResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.QuarterDayForecastResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.QuarterDayForecastResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.QuarterDayForecastResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecastResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecastResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.QuarterDayForecastResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RadiusSector : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.RadiusSector>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.RadiusSector>
    {
        internal RadiusSector() { }
        public double? BeginBearing { get { throw null; } }
        public double? EndBearing { get { throw null; } }
        public double? Radius { get { throw null; } }
        protected virtual Azure.Maps.Weather.RadiusSector JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.RadiusSector PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.RadiusSector System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.RadiusSector>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.RadiusSector>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.RadiusSector System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.RadiusSector>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.RadiusSector>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.RadiusSector>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SevereWeatherAlert : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlert>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlert>
    {
        internal SevereWeatherAlert() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.AlertDetails> AlertDetails { get { throw null; } }
        public int? AlertId { get { throw null; } }
        public string Category { get { throw null; } }
        public string Classification { get { throw null; } }
        public string CountryCode { get { throw null; } }
        public Azure.Maps.Weather.SevereWeatherAlertDescription Description { get { throw null; } }
        public string Disclaimer { get { throw null; } }
        public string Level { get { throw null; } }
        public int? Priority { get { throw null; } }
        public string Source { get { throw null; } }
        public int? SourceId { get { throw null; } }
        protected virtual Azure.Maps.Weather.SevereWeatherAlert JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.SevereWeatherAlert PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.SevereWeatherAlert System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlert>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlert>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.SevereWeatherAlert System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlert>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlert>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlert>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SevereWeatherAlertDescription : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlertDescription>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertDescription>
    {
        internal SevereWeatherAlertDescription() { }
        public string Description { get { throw null; } }
        public string Status { get { throw null; } }
        protected virtual Azure.Maps.Weather.SevereWeatherAlertDescription JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.SevereWeatherAlertDescription PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.SevereWeatherAlertDescription System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlertDescription>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlertDescription>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.SevereWeatherAlertDescription System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertDescription>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertDescription>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertDescription>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SevereWeatherAlertsResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlertsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertsResult>
    {
        internal SevereWeatherAlertsResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.SevereWeatherAlert> Results { get { throw null; } }
        protected virtual Azure.Maps.Weather.SevereWeatherAlertsResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.SevereWeatherAlertsResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.SevereWeatherAlertsResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.SevereWeatherAlertsResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlertsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SevereWeatherAlertsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.SevereWeatherAlertsResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SevereWeatherAlertsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormForecast : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormForecast>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecast>
    {
        internal StormForecast() { }
        public Azure.Maps.Weather.LatLongPair Coordinates { get { throw null; } }
        public string InitializedTimestamp { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue MaxWindGust { get { throw null; } }
        public string Status { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue SustainedWind { get { throw null; } }
        public string Timestamp { get { throw null; } }
        public Azure.Maps.Weather.WeatherWindow WeatherWindow { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.StormWindRadiiSummary> WindRadiiSummary { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormForecast JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.StormForecast PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormForecast System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormForecast>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormForecast>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormForecast System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecast>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecast>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecast>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormForecastResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormForecastResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecastResult>
    {
        internal StormForecastResult() { }
        public string NextLink { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.StormForecast> StormForecasts { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormForecastResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.StormForecastResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.StormForecastResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormForecastResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormForecastResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormForecastResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormForecastResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecastResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecastResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormForecastResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormLocation : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormLocation>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocation>
    {
        internal StormLocation() { }
        public Azure.Maps.Weather.LatLongPair Coordinates { get { throw null; } }
        public bool? HasTropicalPotential { get { throw null; } }
        public bool? IsPostTropical { get { throw null; } }
        public bool? IsSubtropical { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue MaxWindGust { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue MinimumPressure { get { throw null; } }
        public Azure.Maps.Weather.WindDetails Movement { get { throw null; } }
        public string Status { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue SustainedWind { get { throw null; } }
        public string Timestamp { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.StormWindRadiiSummary> WindRadiiSummary { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormLocation JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.StormLocation PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormLocation System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormLocation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormLocation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormLocation System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormLocationsResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormLocationsResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocationsResult>
    {
        internal StormLocationsResult() { }
        public string NextLink { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.StormLocation> StormLocations { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormLocationsResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.StormLocationsResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.StormLocationsResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormLocationsResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormLocationsResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormLocationsResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormLocationsResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocationsResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocationsResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormLocationsResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormSearchResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormSearchResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResult>
    {
        internal StormSearchResult() { }
        public string NextLink { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.StormSearchResultItem> Storms { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormSearchResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.StormSearchResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.StormSearchResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormSearchResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormSearchResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormSearchResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormSearchResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormSearchResultItem : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormSearchResultItem>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResultItem>
    {
        internal StormSearchResultItem() { }
        public Azure.Maps.Weather.BasinId? BasinId { get { throw null; } }
        public int? GovId { get { throw null; } }
        public bool? IsActive { get { throw null; } }
        public bool? IsRetired { get { throw null; } }
        public bool? IsSubtropical { get { throw null; } }
        public string Name { get { throw null; } }
        public string Year { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormSearchResultItem JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.StormSearchResultItem PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormSearchResultItem System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormSearchResultItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormSearchResultItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormSearchResultItem System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResultItem>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResultItem>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormSearchResultItem>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class StormWindRadiiSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormWindRadiiSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormWindRadiiSummary>
    {
        internal StormWindRadiiSummary() { }
        public Azure.Maps.Weather.GeoJsonGeometry RadiiGeometry { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.RadiusSector> RadiusSectorData { get { throw null; } }
        public string Timestamp { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue WindSpeed { get { throw null; } }
        protected virtual Azure.Maps.Weather.StormWindRadiiSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.StormWindRadiiSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.StormWindRadiiSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormWindRadiiSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.StormWindRadiiSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.StormWindRadiiSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormWindRadiiSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormWindRadiiSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.StormWindRadiiSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SunGlare : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SunGlare>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SunGlare>
    {
        internal SunGlare() { }
        public int? CalculatedVehicleHeading { get { throw null; } }
        public int? GlareIndex { get { throw null; } }
        protected virtual Azure.Maps.Weather.SunGlare JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.SunGlare PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.SunGlare System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SunGlare>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.SunGlare>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.SunGlare System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SunGlare>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SunGlare>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.SunGlare>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class TemperatureSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.TemperatureSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.TemperatureSummary>
    {
        internal TemperatureSummary() { }
        public Azure.Maps.Weather.PastHoursTemperature Past12Hours { get { throw null; } }
        public Azure.Maps.Weather.PastHoursTemperature Past24Hours { get { throw null; } }
        public Azure.Maps.Weather.PastHoursTemperature Past6Hours { get { throw null; } }
        protected virtual Azure.Maps.Weather.TemperatureSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.TemperatureSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.TemperatureSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.TemperatureSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.TemperatureSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.TemperatureSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.TemperatureSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.TemperatureSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.TemperatureSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UnitType : System.IEquatable<Azure.Maps.Weather.UnitType>
    {
        private readonly int _dummyPrimitive;
        public UnitType(long value) { throw null; }
        public static Azure.Maps.Weather.UnitType Celsius { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Centimeter { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Fahrenheit { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Feet { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Float { get { throw null; } }
        public static Azure.Maps.Weather.UnitType HectoPascals { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Inches { get { throw null; } }
        public static Azure.Maps.Weather.UnitType InchesOfMercury { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Integer { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Kelvin { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Kilometer { get { throw null; } }
        public static Azure.Maps.Weather.UnitType KilometersPerHour { get { throw null; } }
        public static Azure.Maps.Weather.UnitType KiloPascals { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Knots { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Meter { get { throw null; } }
        public static Azure.Maps.Weather.UnitType MetersPerSecond { get { throw null; } }
        public static Azure.Maps.Weather.UnitType MicrogramsPerCubicMeterOfAir { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Miles { get { throw null; } }
        public static Azure.Maps.Weather.UnitType MilesPerHour { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Millibars { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Millimeter { get { throw null; } }
        public static Azure.Maps.Weather.UnitType MillimetersOfMercury { get { throw null; } }
        public static Azure.Maps.Weather.UnitType Percent { get { throw null; } }
        public static Azure.Maps.Weather.UnitType PoundsPerSquareInch { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.UnitType other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.UnitType left, Azure.Maps.Weather.UnitType right) { throw null; }
        public static implicit operator Azure.Maps.Weather.UnitType (long value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.UnitType left, Azure.Maps.Weather.UnitType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WaypointForecast : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WaypointForecast>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WaypointForecast>
    {
        internal WaypointForecast() { }
        public int? CloudCover { get { throw null; } }
        public Azure.Maps.Weather.WeatherHazards Hazards { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        public bool? IsDaytime { get { throw null; } }
        public int? LightningCount { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Maps.Weather.WeatherNotification> Notifications { get { throw null; } }
        public Azure.Maps.Weather.WeatherAlongRoutePrecipitation Precipitation { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        public Azure.Maps.Weather.SunGlare SunGlare { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Temperature { get { throw null; } }
        public Azure.Maps.Weather.WindDetails Wind { get { throw null; } }
        public Azure.Maps.Weather.WindDetails WindGust { get { throw null; } }
        protected virtual Azure.Maps.Weather.WaypointForecast JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WaypointForecast PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WaypointForecast System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WaypointForecast>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WaypointForecast>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WaypointForecast System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WaypointForecast>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WaypointForecast>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WaypointForecast>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherAlongRoutePrecipitation : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>
    {
        internal WeatherAlongRoutePrecipitation() { }
        public double? Dbz { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherAlongRoutePrecipitation JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherAlongRoutePrecipitation PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherAlongRoutePrecipitation System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherAlongRoutePrecipitation System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRoutePrecipitation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherAlongRouteResult : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRouteResult>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteResult>
    {
        internal WeatherAlongRouteResult() { }
        public Azure.Maps.Weather.WeatherAlongRouteSummary Summary { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Maps.Weather.WaypointForecast> Waypoints { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherAlongRouteResult JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        public static explicit operator Azure.Maps.Weather.WeatherAlongRouteResult (Azure.Response response) { throw null; }
        protected virtual Azure.Maps.Weather.WeatherAlongRouteResult PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherAlongRouteResult System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRouteResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRouteResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherAlongRouteResult System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherAlongRouteSummary : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRouteSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteSummary>
    {
        internal WeatherAlongRouteSummary() { }
        public Azure.Maps.Weather.WeatherHazards Hazards { get { throw null; } }
        public Azure.Maps.Weather.IconCode? IconCode { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherAlongRouteSummary JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherAlongRouteSummary PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherAlongRouteSummary System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRouteSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherAlongRouteSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherAlongRouteSummary System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherAlongRouteSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WeatherDataUnit : System.IEquatable<Azure.Maps.Weather.WeatherDataUnit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WeatherDataUnit(string value) { throw null; }
        public static Azure.Maps.Weather.WeatherDataUnit Imperial { get { throw null; } }
        public static Azure.Maps.Weather.WeatherDataUnit Metric { get { throw null; } }
        public bool Equals(Azure.Maps.Weather.WeatherDataUnit other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Maps.Weather.WeatherDataUnit left, Azure.Maps.Weather.WeatherDataUnit right) { throw null; }
        public static implicit operator Azure.Maps.Weather.WeatherDataUnit (string value) { throw null; }
        public static implicit operator Azure.Maps.Weather.WeatherDataUnit? (string value) { throw null; }
        public static bool operator !=(Azure.Maps.Weather.WeatherDataUnit left, Azure.Maps.Weather.WeatherDataUnit right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WeatherHazards : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherHazards>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherHazards>
    {
        internal WeatherHazards() { }
        public System.Collections.Generic.IList<Azure.Maps.Weather.HazardDetail> Details { get { throw null; } }
        public Azure.Maps.Weather.HazardIndex? MaxHazardIndex { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherHazards JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherHazards PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherHazards System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherHazards>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherHazards>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherHazards System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherHazards>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherHazards>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherHazards>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class WeatherModelFactory
    {
        public static Azure.Maps.Weather.ActiveStorm ActiveStorm(string year = null, Azure.Maps.Weather.BasinId? basinId = default(Azure.Maps.Weather.BasinId?), string name = null, bool? isActive = default(bool?), bool? isSubtropical = default(bool?), int? govId = default(int?)) { throw null; }
        public static Azure.Maps.Weather.ActiveStormResult ActiveStormResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.ActiveStorm> activeStorms = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.AirAndPollen AirAndPollen(string description = null, int? value = default(int?), string category = null, int? categoryValue = default(int?), string airQualityType = null) { throw null; }
        public static Azure.Maps.Weather.AirQuality AirQuality(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), float? index = default(float?), float? globalIndex = default(float?), Azure.Maps.Weather.DominantPollutant? dominantPollutant = default(Azure.Maps.Weather.DominantPollutant?), string category = null, string categoryColor = null, string description = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.Pollutant> pollutants = null) { throw null; }
        public static Azure.Maps.Weather.AirQualityResult AirQualityResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.AirQuality> airQualityResults = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.AlertDetails AlertDetails(string name = null, string description = null, System.DateTimeOffset? startTime = default(System.DateTimeOffset?), System.DateTimeOffset? endTime = default(System.DateTimeOffset?), Azure.Maps.Weather.LatestStatus latestStatus = null, string details = null, string language = null) { throw null; }
        public static Azure.Maps.Weather.ColorValue ColorValue(int? red = default(int?), int? green = default(int?), int? blue = default(int?), string hex = null) { throw null; }
        public static Azure.Maps.Weather.CurrentConditions CurrentConditions(System.DateTimeOffset? dateTime = default(System.DateTimeOffset?), string description = null, Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), bool? hasPrecipitation = default(bool?), bool? isDaytime = default(bool?), Azure.Maps.Weather.WeatherValue temperature = null, Azure.Maps.Weather.WeatherValue realFeelTemperature = null, Azure.Maps.Weather.WeatherValue realFeelTemperatureShade = null, int? relativeHumidity = default(int?), Azure.Maps.Weather.WeatherValue dewPoint = null, Azure.Maps.Weather.WindDetails wind = null, Azure.Maps.Weather.WindDetails windGust = null, int? uvIndex = default(int?), string uvIndexDescription = null, Azure.Maps.Weather.WeatherValue visibility = null, string obstructionsToVisibility = null, int? cloudCover = default(int?), Azure.Maps.Weather.WeatherValue cloudCeiling = null, Azure.Maps.Weather.WeatherValue pressure = null, Azure.Maps.Weather.PressureTendency pressureTendency = null, Azure.Maps.Weather.WeatherValue pastTwentyFourHourTemperatureDeparture = null, Azure.Maps.Weather.WeatherValue apparentTemperature = null, Azure.Maps.Weather.WeatherValue windChillTemperature = null, Azure.Maps.Weather.WeatherValue wetBulbTemperature = null, Azure.Maps.Weather.PrecipitationSummary precipitationSummary = null, Azure.Maps.Weather.TemperatureSummary temperatureSummary = null) { throw null; }
        public static Azure.Maps.Weather.CurrentConditionsResult CurrentConditionsResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.CurrentConditions> results = null) { throw null; }
        public static Azure.Maps.Weather.DailyAirQuality DailyAirQuality(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), float? index = default(float?), float? globalIndex = default(float?), Azure.Maps.Weather.DominantPollutant? dominantPollutant = default(Azure.Maps.Weather.DominantPollutant?), string category = null, string categoryColor = null, string description = null) { throw null; }
        public static Azure.Maps.Weather.DailyAirQualityForecastResult DailyAirQualityForecastResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.DailyAirQuality> airQualityResults = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.DailyForecast DailyForecast(System.DateTimeOffset? dateTime = default(System.DateTimeOffset?), Azure.Maps.Weather.WeatherValueRange temperature = null, Azure.Maps.Weather.WeatherValueRange realFeelTemperature = null, Azure.Maps.Weather.WeatherValueRange realFeelTemperatureShade = null, float? hoursOfSun = default(float?), Azure.Maps.Weather.DegreeDaySummary meanTemperatureDeviation = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.AirAndPollen> airQuality = null, Azure.Maps.Weather.DailyForecastDetail daytimeForecast = null, Azure.Maps.Weather.DailyForecastDetail nighttimeForecast = null, System.Collections.Generic.IEnumerable<string> sources = null) { throw null; }
        public static Azure.Maps.Weather.DailyForecastDetail DailyForecastDetail(Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), string iconPhrase = null, Azure.Maps.Weather.LocalSource localSource = null, bool? hasPrecipitation = default(bool?), Azure.Maps.Weather.PrecipitationType? precipitationType = default(Azure.Maps.Weather.PrecipitationType?), string precipitationIntensity = null, string shortDescription = null, string longPhrase = null, int? precipitationProbability = default(int?), int? thunderstormProbability = default(int?), int? rainProbability = default(int?), int? snowProbability = default(int?), int? iceProbability = default(int?), Azure.Maps.Weather.WindDetails wind = null, Azure.Maps.Weather.WindDetails windGust = null, Azure.Maps.Weather.WeatherValue totalLiquid = null, Azure.Maps.Weather.WeatherValue rain = null, Azure.Maps.Weather.WeatherValue snow = null, Azure.Maps.Weather.WeatherValue ice = null, float? hoursOfPrecipitation = default(float?), float? hoursOfRain = default(float?), float? hoursOfSnow = default(float?), float? hoursOfIce = default(float?), int? cloudCover = default(int?)) { throw null; }
        public static Azure.Maps.Weather.DailyForecastResult DailyForecastResult(Azure.Maps.Weather.DailyForecastSummary summary = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.DailyForecast> forecasts = null) { throw null; }
        public static Azure.Maps.Weather.DailyForecastSummary DailyForecastSummary(System.DateTimeOffset? startDate = default(System.DateTimeOffset?), System.DateTimeOffset? endDate = default(System.DateTimeOffset?), int? severity = default(int?), string phrase = null, string category = null) { throw null; }
        public static Azure.Maps.Weather.DailyHistoricalActuals DailyHistoricalActuals(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), Azure.Maps.Weather.WeatherValueMaxMinAvg temperature = null, Azure.Maps.Weather.DegreeDaySummary degreeDaySummary = null, Azure.Maps.Weather.WeatherValue precipitation = null, Azure.Maps.Weather.WeatherValue snowfall = null, Azure.Maps.Weather.WeatherValue snowDepth = null) { throw null; }
        public static Azure.Maps.Weather.DailyHistoricalActualsResult DailyHistoricalActualsResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.DailyHistoricalActuals> historicalActuals = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.DailyHistoricalNormals DailyHistoricalNormals(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), Azure.Maps.Weather.WeatherValueMaxMinAvg temperature = null, Azure.Maps.Weather.DegreeDaySummary degreeDaySummary = null, Azure.Maps.Weather.WeatherValue precipitation = null) { throw null; }
        public static Azure.Maps.Weather.DailyHistoricalNormalsResult DailyHistoricalNormalsResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.DailyHistoricalNormals> historicalNormals = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.DailyHistoricalRecords DailyHistoricalRecords(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), Azure.Maps.Weather.WeatherValueYearMaxMinAvg temperature = null, Azure.Maps.Weather.WeatherValueYearMax precipitation = null, Azure.Maps.Weather.WeatherValueYearMax snowfall = null) { throw null; }
        public static Azure.Maps.Weather.DailyHistoricalRecordsResult DailyHistoricalRecordsResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.DailyHistoricalRecords> historicalRecords = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.DailyIndex DailyIndex(string indexName = null, int? indexId = default(int?), System.DateTimeOffset? dateTime = default(System.DateTimeOffset?), float? value = default(float?), string categoryDescription = null, int? categoryValue = default(int?), bool? isAscending = default(bool?), string description = null) { throw null; }
        public static Azure.Maps.Weather.DailyIndicesResult DailyIndicesResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.DailyIndex> results = null) { throw null; }
        public static Azure.Maps.Weather.DegreeDaySummary DegreeDaySummary(Azure.Maps.Weather.WeatherValue heating = null, Azure.Maps.Weather.WeatherValue cooling = null) { throw null; }
        public static Azure.Maps.Weather.ForecastInterval ForecastInterval(System.DateTimeOffset? startTime = default(System.DateTimeOffset?), int? minute = default(int?), double? decibelRelativeToZ = default(double?), string shortDescription = null, string threshold = null, Azure.Maps.Weather.ColorValue color = null, Azure.Maps.Weather.ColorValue simplifiedColor = null, Azure.Maps.Weather.PrecipitationType? precipitationType = default(Azure.Maps.Weather.PrecipitationType?), Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), int? cloudCover = default(int?)) { throw null; }
        public static Azure.Maps.Weather.GeoJsonGeometry GeoJsonGeometry(string type = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonGeometryCollection GeoJsonGeometryCollection(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.GeoJsonGeometry> geometries = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonLineString GeoJsonLineString(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<double>> coordinates = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonMultiLineString GeoJsonMultiLineString(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<System.Collections.Generic.IList<double>>> coordinates = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonMultiPoint GeoJsonMultiPoint(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<double>> coordinates = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonMultiPolygon GeoJsonMultiPolygon(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<System.Collections.Generic.IList<System.Collections.Generic.IList<double>>>> coordinates = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonPoint GeoJsonPoint(System.Collections.Generic.IEnumerable<double> coordinates = null) { throw null; }
        public static Azure.Maps.Weather.GeoJsonPolygon GeoJsonPolygon(System.Collections.Generic.IEnumerable<System.Collections.Generic.IList<System.Collections.Generic.IList<double>>> coordinates = null) { throw null; }
        public static Azure.Maps.Weather.HazardDetail HazardDetail(Azure.Maps.Weather.HazardIndex? hazardIndex = default(Azure.Maps.Weather.HazardIndex?), string hazardCode = null, string shortDescription = null) { throw null; }
        public static Azure.Maps.Weather.HourlyForecast HourlyForecast(System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), string iconPhrase = null, bool? hasPrecipitation = default(bool?), bool? isDaylight = default(bool?), Azure.Maps.Weather.WeatherValue temperature = null, Azure.Maps.Weather.WeatherValue realFeelTemperature = null, Azure.Maps.Weather.WeatherValue wetBulbTemperature = null, Azure.Maps.Weather.WeatherValue dewPoint = null, Azure.Maps.Weather.WindDetails wind = null, Azure.Maps.Weather.WindDetails windGust = null, int? relativeHumidity = default(int?), Azure.Maps.Weather.WeatherValue visibility = null, Azure.Maps.Weather.WeatherValue cloudCeiling = null, int? uvIndex = default(int?), string uvIndexDescription = null, int? precipitationProbability = default(int?), int? rainProbability = default(int?), int? snowProbability = default(int?), int? iceProbability = default(int?), Azure.Maps.Weather.WeatherValue totalLiquid = null, Azure.Maps.Weather.WeatherValue rain = null, Azure.Maps.Weather.WeatherValue snow = null, Azure.Maps.Weather.WeatherValue ice = null, int? cloudCover = default(int?)) { throw null; }
        public static Azure.Maps.Weather.HourlyForecastResult HourlyForecastResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.HourlyForecast> forecasts = null) { throw null; }
        public static Azure.Maps.Weather.IntervalSummary IntervalSummary(int? startMinute = default(int?), int? endMinute = default(int?), int? totalMinutes = default(int?), string shortDescription = null, string briefDescription = null, string longPhrase = null, Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?)) { throw null; }
        public static Azure.Maps.Weather.LatestStatus LatestStatus(string localized = null, Azure.Maps.Weather.LatestStatusKeyword? english = default(Azure.Maps.Weather.LatestStatusKeyword?)) { throw null; }
        public static Azure.Maps.Weather.LatLongPair LatLongPair(double? latitude = default(double?), double? longitude = default(double?)) { throw null; }
        public static Azure.Maps.Weather.LocalSource LocalSource(int? id = default(int?), string name = null, string weatherCode = null) { throw null; }
        public static Azure.Maps.Weather.MinuteForecastResult MinuteForecastResult(Azure.Maps.Weather.MinuteForecastSummary summary = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.IntervalSummary> intervalSummaries = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.ForecastInterval> intervals = null) { throw null; }
        public static Azure.Maps.Weather.MinuteForecastSummary MinuteForecastSummary(string briefPhrase60 = null, string shortDescription = null, string briefDescription = null, string longPhrase = null, Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?)) { throw null; }
        public static Azure.Maps.Weather.PastHoursTemperature PastHoursTemperature(Azure.Maps.Weather.WeatherValue minimum = null, Azure.Maps.Weather.WeatherValue maximum = null) { throw null; }
        public static Azure.Maps.Weather.Pollutant Pollutant(Azure.Maps.Weather.PollutantType? type = default(Azure.Maps.Weather.PollutantType?), string name = null, float? index = default(float?), float? globalIndex = default(float?), Azure.Maps.Weather.WeatherValue concentration = null) { throw null; }
        public static Azure.Maps.Weather.PrecipitationSummary PrecipitationSummary(Azure.Maps.Weather.WeatherValue pastHour = null, Azure.Maps.Weather.WeatherValue past3Hours = null, Azure.Maps.Weather.WeatherValue past6Hours = null, Azure.Maps.Weather.WeatherValue past9Hours = null, Azure.Maps.Weather.WeatherValue past12Hours = null, Azure.Maps.Weather.WeatherValue past18Hours = null, Azure.Maps.Weather.WeatherValue past24Hours = null) { throw null; }
        public static Azure.Maps.Weather.PressureTendency PressureTendency(string description = null, string code = null) { throw null; }
        public static Azure.Maps.Weather.QuarterDayForecast QuarterDayForecast(System.DateTimeOffset? dateTime = default(System.DateTimeOffset?), System.DateTimeOffset? effectiveDate = default(System.DateTimeOffset?), Azure.Maps.Weather.DayQuarter? quarter = default(Azure.Maps.Weather.DayQuarter?), Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), string iconPhrase = null, string phrase = null, Azure.Maps.Weather.WeatherValueRange temperature = null, Azure.Maps.Weather.WeatherValueRange realFeelTemperature = null, Azure.Maps.Weather.WeatherValue dewPoint = null, int? relativeHumidity = default(int?), Azure.Maps.Weather.WindDetails wind = null, Azure.Maps.Weather.WindDetails windGust = null, Azure.Maps.Weather.WeatherValue visibility = null, int? cloudCover = default(int?), bool? hasPrecipitation = default(bool?), Azure.Maps.Weather.PrecipitationType? precipitationType = default(Azure.Maps.Weather.PrecipitationType?), string precipitationIntensity = null, int? precipitationProbability = default(int?), int? thunderstormProbability = default(int?), Azure.Maps.Weather.WeatherValue totalLiquid = null, Azure.Maps.Weather.WeatherValue rain = null, Azure.Maps.Weather.WeatherValue snow = null, Azure.Maps.Weather.WeatherValue ice = null) { throw null; }
        public static Azure.Maps.Weather.QuarterDayForecastResult QuarterDayForecastResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.QuarterDayForecast> forecasts = null) { throw null; }
        public static Azure.Maps.Weather.RadiusSector RadiusSector(double? beginBearing = default(double?), double? endBearing = default(double?), double? radius = default(double?)) { throw null; }
        public static Azure.Maps.Weather.SevereWeatherAlert SevereWeatherAlert(string countryCode = null, int? alertId = default(int?), Azure.Maps.Weather.SevereWeatherAlertDescription description = null, string category = null, int? priority = default(int?), string classification = null, string level = null, string source = null, int? sourceId = default(int?), string disclaimer = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.AlertDetails> alertDetails = null) { throw null; }
        public static Azure.Maps.Weather.SevereWeatherAlertDescription SevereWeatherAlertDescription(string description = null, string status = null) { throw null; }
        public static Azure.Maps.Weather.SevereWeatherAlertsResult SevereWeatherAlertsResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.SevereWeatherAlert> results = null) { throw null; }
        public static Azure.Maps.Weather.StormForecast StormForecast(string timestamp = null, string initializedTimestamp = null, Azure.Maps.Weather.LatLongPair coordinates = null, Azure.Maps.Weather.WeatherValue maxWindGust = null, Azure.Maps.Weather.WeatherValue sustainedWind = null, string status = null, Azure.Maps.Weather.WeatherWindow weatherWindow = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.StormWindRadiiSummary> windRadiiSummary = null) { throw null; }
        public static Azure.Maps.Weather.StormForecastResult StormForecastResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.StormForecast> stormForecasts = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.StormLocation StormLocation(string timestamp = null, Azure.Maps.Weather.LatLongPair coordinates = null, Azure.Maps.Weather.WeatherValue maxWindGust = null, Azure.Maps.Weather.WeatherValue sustainedWind = null, Azure.Maps.Weather.WeatherValue minimumPressure = null, Azure.Maps.Weather.WindDetails movement = null, string status = null, bool? isSubtropical = default(bool?), bool? hasTropicalPotential = default(bool?), bool? isPostTropical = default(bool?), System.Collections.Generic.IEnumerable<Azure.Maps.Weather.StormWindRadiiSummary> windRadiiSummary = null) { throw null; }
        public static Azure.Maps.Weather.StormLocationsResult StormLocationsResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.StormLocation> stormLocations = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.StormSearchResult StormSearchResult(System.Collections.Generic.IEnumerable<Azure.Maps.Weather.StormSearchResultItem> storms = null, string nextLink = null) { throw null; }
        public static Azure.Maps.Weather.StormSearchResultItem StormSearchResultItem(string year = null, Azure.Maps.Weather.BasinId? basinId = default(Azure.Maps.Weather.BasinId?), string name = null, bool? isActive = default(bool?), bool? isRetired = default(bool?), bool? isSubtropical = default(bool?), int? govId = default(int?)) { throw null; }
        public static Azure.Maps.Weather.StormWindRadiiSummary StormWindRadiiSummary(string timestamp = null, Azure.Maps.Weather.WeatherValue windSpeed = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.RadiusSector> radiusSectorData = null, Azure.Maps.Weather.GeoJsonGeometry radiiGeometry = null) { throw null; }
        public static Azure.Maps.Weather.SunGlare SunGlare(int? calculatedVehicleHeading = default(int?), int? glareIndex = default(int?)) { throw null; }
        public static Azure.Maps.Weather.TemperatureSummary TemperatureSummary(Azure.Maps.Weather.PastHoursTemperature past6Hours = null, Azure.Maps.Weather.PastHoursTemperature past12Hours = null, Azure.Maps.Weather.PastHoursTemperature past24Hours = null) { throw null; }
        public static Azure.Maps.Weather.WaypointForecast WaypointForecast(Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), string shortDescription = null, bool? isDaytime = default(bool?), int? cloudCover = default(int?), Azure.Maps.Weather.WeatherValue temperature = null, Azure.Maps.Weather.WindDetails wind = null, Azure.Maps.Weather.WindDetails windGust = null, Azure.Maps.Weather.WeatherAlongRoutePrecipitation precipitation = null, int? lightningCount = default(int?), Azure.Maps.Weather.SunGlare sunGlare = null, Azure.Maps.Weather.WeatherHazards hazards = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.WeatherNotification> notifications = null) { throw null; }
        public static Azure.Maps.Weather.WeatherAlongRoutePrecipitation WeatherAlongRoutePrecipitation(double? dbz = default(double?), string type = null) { throw null; }
        public static Azure.Maps.Weather.WeatherAlongRouteResult WeatherAlongRouteResult(Azure.Maps.Weather.WeatherAlongRouteSummary summary = null, System.Collections.Generic.IEnumerable<Azure.Maps.Weather.WaypointForecast> waypoints = null) { throw null; }
        public static Azure.Maps.Weather.WeatherAlongRouteSummary WeatherAlongRouteSummary(Azure.Maps.Weather.IconCode? iconCode = default(Azure.Maps.Weather.IconCode?), Azure.Maps.Weather.WeatherHazards hazards = null) { throw null; }
        public static Azure.Maps.Weather.WeatherHazards WeatherHazards(Azure.Maps.Weather.HazardIndex? maxHazardIndex = default(Azure.Maps.Weather.HazardIndex?), System.Collections.Generic.IEnumerable<Azure.Maps.Weather.HazardDetail> details = null) { throw null; }
        public static Azure.Maps.Weather.WeatherNotification WeatherNotification(string type = null, Azure.Maps.Weather.HazardIndex? hazardIndex = default(Azure.Maps.Weather.HazardIndex?), string hazardCode = null, string shortDescription = null) { throw null; }
        public static Azure.Maps.Weather.WeatherValue WeatherValue(float? value = default(float?), string unitLabel = null, Azure.Maps.Weather.UnitType? unitType = default(Azure.Maps.Weather.UnitType?)) { throw null; }
        public static Azure.Maps.Weather.WeatherValueMaxMinAvg WeatherValueMaxMinAvg(Azure.Maps.Weather.WeatherValue maximum = null, Azure.Maps.Weather.WeatherValue minimum = null, Azure.Maps.Weather.WeatherValue average = null) { throw null; }
        public static Azure.Maps.Weather.WeatherValueRange WeatherValueRange(Azure.Maps.Weather.WeatherValue minimum = null, Azure.Maps.Weather.WeatherValue maximum = null) { throw null; }
        public static Azure.Maps.Weather.WeatherValueYear WeatherValueYear(float? value = default(float?), string unit = null, int? unitType = default(int?), int? year = default(int?)) { throw null; }
        public static Azure.Maps.Weather.WeatherValueYearMax WeatherValueYearMax(Azure.Maps.Weather.WeatherValueYear maximum = null) { throw null; }
        public static Azure.Maps.Weather.WeatherValueYearMaxMinAvg WeatherValueYearMaxMinAvg(Azure.Maps.Weather.WeatherValueYear maximum = null, Azure.Maps.Weather.WeatherValueYear minimum = null, Azure.Maps.Weather.WeatherValue average = null) { throw null; }
        public static Azure.Maps.Weather.WeatherWindow WeatherWindow(Azure.Maps.Weather.LatLongPair topLeft = null, Azure.Maps.Weather.LatLongPair bottomRight = null, System.DateTimeOffset? beginTimestamp = default(System.DateTimeOffset?), System.DateTimeOffset? endTimestamp = default(System.DateTimeOffset?), string beginStatus = null, string endStatus = null, Azure.Maps.Weather.GeoJsonGeometry geometry = null) { throw null; }
        public static Azure.Maps.Weather.WindDetails WindDetails(Azure.Maps.Weather.WindDirection direction = null, Azure.Maps.Weather.WeatherValue speed = null) { throw null; }
        public static Azure.Maps.Weather.WindDirection WindDirection(int? degrees = default(int?), string description = null) { throw null; }
    }
    public partial class WeatherNotification : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherNotification>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherNotification>
    {
        internal WeatherNotification() { }
        public string HazardCode { get { throw null; } }
        public Azure.Maps.Weather.HazardIndex? HazardIndex { get { throw null; } }
        public string ShortDescription { get { throw null; } }
        public string Type { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherNotification JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherNotification PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherNotification System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherNotification>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherNotification>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherNotification System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherNotification>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherNotification>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherNotification>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherValue : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValue>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValue>
    {
        internal WeatherValue() { }
        public string UnitLabel { get { throw null; } }
        public Azure.Maps.Weather.UnitType? UnitType { get { throw null; } }
        public float? Value { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherValue JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherValue PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherValue System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValue>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValue>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherValue System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValue>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValue>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValue>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherValueMaxMinAvg : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>
    {
        internal WeatherValueMaxMinAvg() { }
        public Azure.Maps.Weather.WeatherValue Average { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Maximum { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Minimum { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherValueMaxMinAvg JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherValueMaxMinAvg PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherValueMaxMinAvg System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherValueMaxMinAvg System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueMaxMinAvg>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherValueRange : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueRange>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueRange>
    {
        internal WeatherValueRange() { }
        public Azure.Maps.Weather.WeatherValue Maximum { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Minimum { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherValueRange JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherValueRange PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherValueRange System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueRange>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueRange>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherValueRange System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueRange>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueRange>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueRange>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherValueYear : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYear>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYear>
    {
        internal WeatherValueYear() { }
        public string Unit { get { throw null; } }
        public int? UnitType { get { throw null; } }
        public float? Value { get { throw null; } }
        public int? Year { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherValueYear JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherValueYear PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherValueYear System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYear>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYear>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherValueYear System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYear>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYear>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYear>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherValueYearMax : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYearMax>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMax>
    {
        internal WeatherValueYearMax() { }
        public Azure.Maps.Weather.WeatherValueYear Maximum { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherValueYearMax JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherValueYearMax PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherValueYearMax System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYearMax>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYearMax>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherValueYearMax System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMax>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMax>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMax>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherValueYearMaxMinAvg : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>
    {
        internal WeatherValueYearMaxMinAvg() { }
        public Azure.Maps.Weather.WeatherValue Average { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueYear Maximum { get { throw null; } }
        public Azure.Maps.Weather.WeatherValueYear Minimum { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherValueYearMaxMinAvg JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherValueYearMaxMinAvg PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherValueYearMaxMinAvg System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherValueYearMaxMinAvg System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherValueYearMaxMinAvg>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WeatherWindow : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherWindow>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherWindow>
    {
        internal WeatherWindow() { }
        public string BeginStatus { get { throw null; } }
        public System.DateTimeOffset? BeginTimestamp { get { throw null; } }
        public Azure.Maps.Weather.LatLongPair BottomRight { get { throw null; } }
        public string EndStatus { get { throw null; } }
        public System.DateTimeOffset? EndTimestamp { get { throw null; } }
        public Azure.Maps.Weather.GeoJsonGeometry Geometry { get { throw null; } }
        public Azure.Maps.Weather.LatLongPair TopLeft { get { throw null; } }
        protected virtual Azure.Maps.Weather.WeatherWindow JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WeatherWindow PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WeatherWindow System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherWindow>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WeatherWindow>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WeatherWindow System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherWindow>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherWindow>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WeatherWindow>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WindDetails : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WindDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDetails>
    {
        internal WindDetails() { }
        public Azure.Maps.Weather.WindDirection Direction { get { throw null; } }
        public Azure.Maps.Weather.WeatherValue Speed { get { throw null; } }
        protected virtual Azure.Maps.Weather.WindDetails JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WindDetails PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WindDetails System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WindDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WindDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WindDetails System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class WindDirection : System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WindDirection>, System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDirection>
    {
        internal WindDirection() { }
        public int? Degrees { get { throw null; } }
        public string Description { get { throw null; } }
        protected virtual Azure.Maps.Weather.WindDirection JsonModelCreateCore(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        protected virtual Azure.Maps.Weather.WindDirection PersistableModelCreateCore(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        protected virtual System.BinaryData PersistableModelWriteCore(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        Azure.Maps.Weather.WindDirection System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WindDirection>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.Maps.Weather.WindDirection>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.Maps.Weather.WindDirection System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDirection>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDirection>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.Maps.Weather.WindDirection>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Microsoft.Extensions.Azure
{
    public static partial class WeatherClientBuilderExtensions
    {
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Maps.Weather.MapsWeatherClient, Azure.Maps.Weather.MapsWeatherClientOptions> AddMapsWeatherClient<TBuilder>(this TBuilder builder, System.Uri endpoint) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithCredential { throw null; }
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Maps.Weather.MapsWeatherClient, Azure.Maps.Weather.MapsWeatherClientOptions> AddMapsWeatherClient<TBuilder>(this TBuilder builder, System.Uri endpoint, Azure.AzureKeyCredential credential) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilder { throw null; }
        [System.Diagnostics.CodeAnalysis.RequiresDynamicCodeAttribute("Requires unreferenced code until we opt into EnableConfigurationBindingGenerator.")]
        public static Azure.Core.Extensions.IAzureClientBuilder<Azure.Maps.Weather.MapsWeatherClient, Azure.Maps.Weather.MapsWeatherClientOptions> AddMapsWeatherClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration) where TBuilder : Azure.Core.Extensions.IAzureClientFactoryBuilderWithConfiguration<TConfiguration> { throw null; }
    }
}
