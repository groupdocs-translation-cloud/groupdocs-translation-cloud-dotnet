/*
 * GroupDocs.Translation SDK
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 23.9.4
 * Contact: anton.perhunov@aspose.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = GroupDocs.Translation.Cloud.Sdk.Client.OpenAPIDateConverter;

namespace GroupDocs.Translation.Cloud.Sdk.Model
{
    /// <summary>
    /// Defines HttpStatusCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpStatusCode
    {
        /// <summary>
        /// Enum _100 for value: 100
        /// </summary>
        [EnumMember(Value = "100")]
        _100 = 1,

        /// <summary>
        /// Enum _101 for value: 101
        /// </summary>
        [EnumMember(Value = "101")]
        _101 = 2,

        /// <summary>
        /// Enum _102 for value: 102
        /// </summary>
        [EnumMember(Value = "102")]
        _102 = 3,

        /// <summary>
        /// Enum _103 for value: 103
        /// </summary>
        [EnumMember(Value = "103")]
        _103 = 4,

        /// <summary>
        /// Enum _200 for value: 200
        /// </summary>
        [EnumMember(Value = "200")]
        _200 = 5,

        /// <summary>
        /// Enum _201 for value: 201
        /// </summary>
        [EnumMember(Value = "201")]
        _201 = 6,

        /// <summary>
        /// Enum _202 for value: 202
        /// </summary>
        [EnumMember(Value = "202")]
        _202 = 7,

        /// <summary>
        /// Enum _203 for value: 203
        /// </summary>
        [EnumMember(Value = "203")]
        _203 = 8,

        /// <summary>
        /// Enum _204 for value: 204
        /// </summary>
        [EnumMember(Value = "204")]
        _204 = 9,

        /// <summary>
        /// Enum _205 for value: 205
        /// </summary>
        [EnumMember(Value = "205")]
        _205 = 10,

        /// <summary>
        /// Enum _206 for value: 206
        /// </summary>
        [EnumMember(Value = "206")]
        _206 = 11,

        /// <summary>
        /// Enum _207 for value: 207
        /// </summary>
        [EnumMember(Value = "207")]
        _207 = 12,

        /// <summary>
        /// Enum _208 for value: 208
        /// </summary>
        [EnumMember(Value = "208")]
        _208 = 13,

        /// <summary>
        /// Enum _226 for value: 226
        /// </summary>
        [EnumMember(Value = "226")]
        _226 = 14,

        /// <summary>
        /// Enum _300 for value: 300
        /// </summary>
        [EnumMember(Value = "300")]
        _300 = 15,

        /// <summary>
        /// Enum _301 for value: 301
        /// </summary>
        [EnumMember(Value = "301")]
        _301 = 16,

        /// <summary>
        /// Enum _302 for value: 302
        /// </summary>
        [EnumMember(Value = "302")]
        _302 = 17,

        /// <summary>
        /// Enum _303 for value: 303
        /// </summary>
        [EnumMember(Value = "303")]
        _303 = 18,

        /// <summary>
        /// Enum _304 for value: 304
        /// </summary>
        [EnumMember(Value = "304")]
        _304 = 19,

        /// <summary>
        /// Enum _305 for value: 305
        /// </summary>
        [EnumMember(Value = "305")]
        _305 = 20,

        /// <summary>
        /// Enum _306 for value: 306
        /// </summary>
        [EnumMember(Value = "306")]
        _306 = 21,

        /// <summary>
        /// Enum _307 for value: 307
        /// </summary>
        [EnumMember(Value = "307")]
        _307 = 22,

        /// <summary>
        /// Enum _308 for value: 308
        /// </summary>
        [EnumMember(Value = "308")]
        _308 = 23,

        /// <summary>
        /// Enum _400 for value: 400
        /// </summary>
        [EnumMember(Value = "400")]
        _400 = 24,

        /// <summary>
        /// Enum _401 for value: 401
        /// </summary>
        [EnumMember(Value = "401")]
        _401 = 25,

        /// <summary>
        /// Enum _402 for value: 402
        /// </summary>
        [EnumMember(Value = "402")]
        _402 = 26,

        /// <summary>
        /// Enum _403 for value: 403
        /// </summary>
        [EnumMember(Value = "403")]
        _403 = 27,

        /// <summary>
        /// Enum _404 for value: 404
        /// </summary>
        [EnumMember(Value = "404")]
        _404 = 28,

        /// <summary>
        /// Enum _405 for value: 405
        /// </summary>
        [EnumMember(Value = "405")]
        _405 = 29,

        /// <summary>
        /// Enum _406 for value: 406
        /// </summary>
        [EnumMember(Value = "406")]
        _406 = 30,

        /// <summary>
        /// Enum _407 for value: 407
        /// </summary>
        [EnumMember(Value = "407")]
        _407 = 31,

        /// <summary>
        /// Enum _408 for value: 408
        /// </summary>
        [EnumMember(Value = "408")]
        _408 = 32,

        /// <summary>
        /// Enum _409 for value: 409
        /// </summary>
        [EnumMember(Value = "409")]
        _409 = 33,

        /// <summary>
        /// Enum _410 for value: 410
        /// </summary>
        [EnumMember(Value = "410")]
        _410 = 34,

        /// <summary>
        /// Enum _411 for value: 411
        /// </summary>
        [EnumMember(Value = "411")]
        _411 = 35,

        /// <summary>
        /// Enum _412 for value: 412
        /// </summary>
        [EnumMember(Value = "412")]
        _412 = 36,

        /// <summary>
        /// Enum _413 for value: 413
        /// </summary>
        [EnumMember(Value = "413")]
        _413 = 37,

        /// <summary>
        /// Enum _414 for value: 414
        /// </summary>
        [EnumMember(Value = "414")]
        _414 = 38,

        /// <summary>
        /// Enum _415 for value: 415
        /// </summary>
        [EnumMember(Value = "415")]
        _415 = 39,

        /// <summary>
        /// Enum _416 for value: 416
        /// </summary>
        [EnumMember(Value = "416")]
        _416 = 40,

        /// <summary>
        /// Enum _417 for value: 417
        /// </summary>
        [EnumMember(Value = "417")]
        _417 = 41,

        /// <summary>
        /// Enum _421 for value: 421
        /// </summary>
        [EnumMember(Value = "421")]
        _421 = 42,

        /// <summary>
        /// Enum _422 for value: 422
        /// </summary>
        [EnumMember(Value = "422")]
        _422 = 43,

        /// <summary>
        /// Enum _423 for value: 423
        /// </summary>
        [EnumMember(Value = "423")]
        _423 = 44,

        /// <summary>
        /// Enum _424 for value: 424
        /// </summary>
        [EnumMember(Value = "424")]
        _424 = 45,

        /// <summary>
        /// Enum _426 for value: 426
        /// </summary>
        [EnumMember(Value = "426")]
        _426 = 46,

        /// <summary>
        /// Enum _428 for value: 428
        /// </summary>
        [EnumMember(Value = "428")]
        _428 = 47,

        /// <summary>
        /// Enum _429 for value: 429
        /// </summary>
        [EnumMember(Value = "429")]
        _429 = 48,

        /// <summary>
        /// Enum _431 for value: 431
        /// </summary>
        [EnumMember(Value = "431")]
        _431 = 49,

        /// <summary>
        /// Enum _451 for value: 451
        /// </summary>
        [EnumMember(Value = "451")]
        _451 = 50,

        /// <summary>
        /// Enum _500 for value: 500
        /// </summary>
        [EnumMember(Value = "500")]
        _500 = 51,

        /// <summary>
        /// Enum _501 for value: 501
        /// </summary>
        [EnumMember(Value = "501")]
        _501 = 52,

        /// <summary>
        /// Enum _502 for value: 502
        /// </summary>
        [EnumMember(Value = "502")]
        _502 = 53,

        /// <summary>
        /// Enum _503 for value: 503
        /// </summary>
        [EnumMember(Value = "503")]
        _503 = 54,

        /// <summary>
        /// Enum _504 for value: 504
        /// </summary>
        [EnumMember(Value = "504")]
        _504 = 55,

        /// <summary>
        /// Enum _505 for value: 505
        /// </summary>
        [EnumMember(Value = "505")]
        _505 = 56,

        /// <summary>
        /// Enum _506 for value: 506
        /// </summary>
        [EnumMember(Value = "506")]
        _506 = 57,

        /// <summary>
        /// Enum _507 for value: 507
        /// </summary>
        [EnumMember(Value = "507")]
        _507 = 58,

        /// <summary>
        /// Enum _508 for value: 508
        /// </summary>
        [EnumMember(Value = "508")]
        _508 = 59,

        /// <summary>
        /// Enum _510 for value: 510
        /// </summary>
        [EnumMember(Value = "510")]
        _510 = 60,

        /// <summary>
        /// Enum _511 for value: 511
        /// </summary>
        [EnumMember(Value = "511")]
        _511 = 61

    }

}
