// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.Maps.Weather
{
    // Workaround for a base TypeSpec C# emitter bug: an OPTIONAL query parameter whose
    // type is an integer-backed extensible enum (DailyDuration / HourlyDuration) is projected
    // into the protocol method and REST request builder as a NON-nullable `long` instead of
    // `long?`. The surrounding generated code, however, treats the value as nullable
    // (the convenience overloads pass `duration?.ToSerialInt64()`, and the request builder uses
    // `if (duration != null)`), which produces CS1503 and CS0472 build errors. Plain optional
    // numeric query parameters (e.g. GetHourlyForecast's `int? duration`) are generated correctly,
    // so the defect is specific to optional enum-typed query parameters being flattened to their
    // serialized scalar form. These members are suppressed and re-declared here with the correct
    // `long?` type. Remove this file once the base emitter is fixed and the library is regenerated.
    [CodeGenSuppress("GetAirQualityDailyForecasts", typeof(string), typeof(IEnumerable<double>), typeof(string), typeof(string), typeof(long), typeof(RequestContext))]
    [CodeGenSuppress("GetAirQualityDailyForecastsAsync", typeof(string), typeof(IEnumerable<double>), typeof(string), typeof(string), typeof(long), typeof(RequestContext))]
    [CodeGenSuppress("CreateGetAirQualityDailyForecastsRequest", typeof(string), typeof(IEnumerable<double>), typeof(string), typeof(string), typeof(long), typeof(RequestContext))]
    [CodeGenSuppress("GetAirQualityHourlyForecasts", typeof(string), typeof(IEnumerable<double>), typeof(string), typeof(string), typeof(long), typeof(bool?), typeof(RequestContext))]
    [CodeGenSuppress("GetAirQualityHourlyForecastsAsync", typeof(string), typeof(IEnumerable<double>), typeof(string), typeof(string), typeof(long), typeof(bool?), typeof(RequestContext))]
    [CodeGenSuppress("CreateGetAirQualityHourlyForecastsRequest", typeof(string), typeof(IEnumerable<double>), typeof(string), typeof(string), typeof(long), typeof(bool?), typeof(RequestContext))]
    public partial class MapsWeatherClient
    {
        /// <summary> [Protocol Method] The `Get Air Quality Daily Forecasts` API. </summary>
        public virtual Response GetAirQualityDailyForecasts(string format, IEnumerable<double> coordinates, string clientId = default, string language = default, long? duration = default, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("MapsWeatherClient.GetAirQualityDailyForecasts");
            scope.Start();
            try
            {
                Argument.AssertNotNull(coordinates, nameof(coordinates));

                using HttpMessage message = CreateGetAirQualityDailyForecastsRequest(format, coordinates, clientId, language, duration, context);
                return Pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> [Protocol Method] The `Get Air Quality Daily Forecasts` API. </summary>
        public virtual async Task<Response> GetAirQualityDailyForecastsAsync(string format, IEnumerable<double> coordinates, string clientId = default, string language = default, long? duration = default, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("MapsWeatherClient.GetAirQualityDailyForecasts");
            scope.Start();
            try
            {
                Argument.AssertNotNull(coordinates, nameof(coordinates));

                using HttpMessage message = CreateGetAirQualityDailyForecastsRequest(format, coordinates, clientId, language, duration, context);
                return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> [Protocol Method] The `Get Air Quality Hourly Forecasts` API. </summary>
        public virtual Response GetAirQualityHourlyForecasts(string format, IEnumerable<double> coordinates, string clientId = default, string language = default, long? duration = default, bool? includePollutantDetails = default, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("MapsWeatherClient.GetAirQualityHourlyForecasts");
            scope.Start();
            try
            {
                Argument.AssertNotNull(coordinates, nameof(coordinates));

                using HttpMessage message = CreateGetAirQualityHourlyForecastsRequest(format, coordinates, clientId, language, duration, includePollutantDetails, context);
                return Pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> [Protocol Method] The `Get Air Quality Hourly Forecasts` API. </summary>
        public virtual async Task<Response> GetAirQualityHourlyForecastsAsync(string format, IEnumerable<double> coordinates, string clientId = default, string language = default, long? duration = default, bool? includePollutantDetails = default, RequestContext context = null)
        {
            using DiagnosticScope scope = ClientDiagnostics.CreateScope("MapsWeatherClient.GetAirQualityHourlyForecasts");
            scope.Start();
            try
            {
                Argument.AssertNotNull(coordinates, nameof(coordinates));

                using HttpMessage message = CreateGetAirQualityHourlyForecastsRequest(format, coordinates, clientId, language, duration, includePollutantDetails, context);
                return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAirQualityDailyForecastsRequest(string format, IEnumerable<double> coordinates, string clientId, string language, long? duration, RequestContext context)
        {
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/weather/airQuality/forecasts/daily/", false);
            uri.AppendPath(format, true);
            if (_apiVersion != null)
            {
                uri.AppendQuery("api-version", _apiVersion, true);
            }
            if (language != null)
            {
                uri.AppendQuery("language", language, true);
            }
            if (coordinates != null && !(coordinates is ChangeTrackingList<double> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("query", coordinates, ",", escape: true);
            }
            if (duration != null)
            {
                uri.AppendQuery("duration", TypeFormatters.ConvertToString(duration), true);
            }
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Uri = uri;
            request.Method = RequestMethod.Get;
            if (clientId != null)
            {
                request.Headers.SetValue("x-ms-client-id", clientId);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetAirQualityHourlyForecastsRequest(string format, IEnumerable<double> coordinates, string clientId, string language, long? duration, bool? includePollutantDetails, RequestContext context)
        {
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/weather/airQuality/forecasts/hourly/", false);
            uri.AppendPath(format, true);
            if (_apiVersion != null)
            {
                uri.AppendQuery("api-version", _apiVersion, true);
            }
            if (language != null)
            {
                uri.AppendQuery("language", language, true);
            }
            if (coordinates != null && !(coordinates is ChangeTrackingList<double> changeTrackingList && changeTrackingList.IsUndefined))
            {
                uri.AppendQueryDelimited("query", coordinates, ",", escape: true);
            }
            if (duration != null)
            {
                uri.AppendQuery("duration", TypeFormatters.ConvertToString(duration), true);
            }
            if (includePollutantDetails != null)
            {
                uri.AppendQuery("pollutants", TypeFormatters.ConvertToString(includePollutantDetails), true);
            }
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Uri = uri;
            request.Method = RequestMethod.Get;
            if (clientId != null)
            {
                request.Headers.SetValue("x-ms-client-id", clientId);
            }
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }
    }
}
