﻿using System;
using Newtonsoft.Json;

namespace Imgur.API.JsonConverters
{
    /// <summary>
    ///     Converts Epoch (Unix) timestamps to DateTimeOffsets.
    /// </summary>
    public class EpochTimeConverter : JsonConverter
    {
        /// <summary>
        ///     Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (DateTimeOffset);
        }

        /// <summary>
        ///     Reads the JSON representation of the object.
        /// </summary>
        /// <exception cref="InvalidCastException"></exception>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer)
                throw new InvalidCastException("TokenType must be of type Integer.");

            var time = (long) reader.Value;

            var date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(time);
            return new DateTimeOffset(date);
        }

        /// <summary>
        ///     Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dateTimeOffset = (DateTimeOffset) value;

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var timeSpan = dateTimeOffset - epoch;

            var time = (long) timeSpan.TotalSeconds;

            serializer.Serialize(writer, time);
        }
    }
}