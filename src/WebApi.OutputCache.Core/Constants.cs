﻿namespace WebApi.OutputCache.Core
{
    public sealed class Constants
    {
        public const string ContentTypeKey = ":response-ct";
        public const string EtagKey = ":response-etag";
        public const string GenerationTimestampKey = ":response-generationtimestamp";
        public const string ResponseHeaders = ":response-customresponseheaders";
        public const string ContentHeaders = ":response-customcontentheaders";
    }
}
